namespace SerialPortClientTest
{
    using System;
    using System.IO.Ports;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// Um... the main form.
    /// </summary>
    public partial class FrmMain : Form
    {
        // todo: update so can run multiple times
        private SerialPort port;
        private SimplePacketParser packetizer;
        private AddDataDelegate updateUiDelegate;
        private int numPacketsSoFar = 0;
        private DateTime startTime;
        private DateTime endTime;
        private SimplePacket[] packetBuffer;
        private bool areReading = false;
        private SimplePacket rxPacket = new SimplePacket();
        private int lastCounter;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmMain"/> class.
        /// </summary>
        public FrmMain()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Delegate used to pass data from Timer thread to Form threads.
        /// See for more info: https://stackoverflow.com/questions/11590945/how-to-display-the-data-read-in-datareceived-event-handler-of-serialport.
        /// </summary>
        /// <param name="seconds">Seconds that have elapsed. </param>
        /// <param name="freq">Computed frequency. </param>
        /// <param name="packets">The conmtents of packets that have been received. </param>
        public delegate void AddDataDelegate(double seconds, double freq, SimplePacket[] packets);

        /// <summary>
        /// Updates the UI after the packet set is collected.
        /// </summary>
        /// <param name="seconds">Length of run, in seconds.</param>
        /// <param name="freq">Frequency of the run, in Hz.</param>
        /// <param name="packets">An array of parsed packets received during the run.</param>
        public void UpdateUI(double seconds, double freq, SimplePacket[] packets)
        {
            // txtOut.AppendText(ToDisplay.ToString() + System.Environment.NewLine);
            this.lblFreq.Text = freq.ToString();
            this.lblSecs.Text = seconds.ToString();
            int numSamples = packets.Length;
            StringBuilder outString = new StringBuilder();
            outString.Clear();
            for (int i = 0; i < numSamples; i++)
            {
                outString.Append(packets[i].Counter);
                for (int j = 0; j < 8; j++)
                {
                    outString.Append(", " + packets[i].ChannelSet[j]);
                }

                outString.Append(System.Environment.NewLine);
            }

            this.txtOut.Text = outString.ToString();
            this.btnRun.Enabled = true;
            this.Cursor = Cursors.Default;
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int numbytes = this.port.BytesToRead;
            for (int i = 0; i < numbytes; i++)
            {
                // if (numPacketsSoFar < updNumPackets.Value)
                if (this.areReading == true)
                {
                    int inInt = this.port.ReadByte(); // ReadByte returns an int. Weird.
                    byte tempByte = (byte)inInt;
                    bool newPacket = this.packetizer.AddByte(tempByte, this.packetBuffer[this.numPacketsSoFar]);
                    if (newPacket)
                    {
                        if ((this.numPacketsSoFar > 0) && (this.packetBuffer[this.numPacketsSoFar].Counter != this.lastCounter + 1))
                        {
                            throw new Exception("oops -- out of sync");
                        }

                        this.lastCounter = this.packetBuffer[this.numPacketsSoFar].Counter;
                        this.numPacketsSoFar++;
                        newPacket = false;
                    }

                    if (this.numPacketsSoFar == (this.updNumPackets.Value - 1))
                    {
                        this.port.Close();
                        this.areReading = false;
                        this.endTime = DateTime.Now;
                        var diffInSeconds = (this.endTime - this.startTime).TotalSeconds;
                        double freq = Convert.ToDouble(this.updNumPackets.Value) / diffInSeconds;
                        this.lblFreq.Invoke(this.updateUiDelegate, new object[] { diffInSeconds, freq, this.packetBuffer });
                    }
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.updateUiDelegate = new AddDataDelegate(this.UpdateUI);
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            this.numPacketsSoFar = 0;
            this.txtOut.Clear();
            this.lblFreq.Text = string.Empty;
            this.lblSecs.Text = string.Empty;

            this.port = new SerialPort("COM" + this.updPortNum.Value, 115200); //460800
            this.port.DataReceived += new SerialDataReceivedEventHandler(this.Port_DataReceived);
            this.btnRun.Enabled = false;
            this.packetBuffer = new SimplePacket[(int)this.updNumPackets.Value];
            this.packetizer = new SimplePacketParser();
            for (int i = 0; i < (int)this.updNumPackets.Value; i++)
            {
                this.packetBuffer[i] = new SimplePacket();
            }

            this.port.Open();
            this.startTime = DateTime.Now;
            this.areReading = true;

            this.Cursor = Cursors.WaitCursor;
        }
    }
}

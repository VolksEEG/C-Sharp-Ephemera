
namespace SerialPortClientTest
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.updPortNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.updNumPackets = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSecs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFreq = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updPortNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updNumPackets)).BeginInit();
            this.SuspendLayout();
            // 
            // updPortNum
            // 
            this.updPortNum.Location = new System.Drawing.Point(117, 24);
            this.updPortNum.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.updPortNum.Name = "updPortNum";
            this.updPortNum.Size = new System.Drawing.Size(77, 29);
            this.updPortNum.TabIndex = 0;
            this.updPortNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updPortNum.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port #";
            // 
            // updNumPackets
            // 
            this.updNumPackets.Location = new System.Drawing.Point(342, 22);
            this.updNumPackets.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.updNumPackets.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.updNumPackets.Name = "updNumPackets";
            this.updNumPackets.Size = new System.Drawing.Size(150, 29);
            this.updNumPackets.TabIndex = 2;
            this.updNumPackets.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updNumPackets.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "# Packets";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(46, 85);
            this.btnRun.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(137, 42);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // txtOut
            // 
            this.txtOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOut.Location = new System.Drawing.Point(22, 138);
            this.txtOut.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOut.Size = new System.Drawing.Size(659, 690);
            this.txtOut.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seconds";
            // 
            // lblSecs
            // 
            this.lblSecs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecs.Location = new System.Drawing.Point(363, 94);
            this.lblSecs.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSecs.Name = "lblSecs";
            this.lblSecs.Size = new System.Drawing.Size(56, 30);
            this.lblSecs.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Freq";
            // 
            // lblFreq
            // 
            this.lblFreq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFreq.Location = new System.Drawing.Point(517, 90);
            this.lblFreq.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(80, 33);
            this.lblFreq.TabIndex = 9;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(706, 854);
            this.Controls.Add(this.lblFreq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSecs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updNumPackets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updPortNum);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmMain";
            this.Text = "Serial Port Test";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updPortNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updNumPackets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown updPortNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown updNumPackets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSecs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFreq;
    }
}


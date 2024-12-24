namespace DoNhietDo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCOM = new System.Windows.Forms.ComboBox();
            this.cboBaudrate = new System.Windows.Forms.ComboBox();
            this.butConnect = new System.Windows.Forms.Button();
            this.ButDisconnect = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.lbTrangthai = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataReceived = new System.Windows.Forms.TextBox();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do Cam Bien Nhiet Do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(5, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chon toc do truyen: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(5, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chon COM:";
            // 
            // cboCOM
            // 
            this.cboCOM.FormattingEnabled = true;
            this.cboCOM.Location = new System.Drawing.Point(183, 66);
            this.cboCOM.Name = "cboCOM";
            this.cboCOM.Size = new System.Drawing.Size(121, 21);
            this.cboCOM.TabIndex = 3;
            this.cboCOM.SelectedIndexChanged += new System.EventHandler(this.cboCOM_SelectedIndexChanged);
            // 
            // cboBaudrate
            // 
            this.cboBaudrate.FormattingEnabled = true;
            this.cboBaudrate.Location = new System.Drawing.Point(183, 127);
            this.cboBaudrate.Name = "cboBaudrate";
            this.cboBaudrate.Size = new System.Drawing.Size(121, 21);
            this.cboBaudrate.TabIndex = 4;
            // 
            // butConnect
            // 
            this.butConnect.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.butConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.butConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butConnect.Location = new System.Drawing.Point(21, 209);
            this.butConnect.Name = "butConnect";
            this.butConnect.Size = new System.Drawing.Size(74, 63);
            this.butConnect.TabIndex = 5;
            this.butConnect.Text = "Ket Noi";
            this.butConnect.UseVisualStyleBackColor = false;
            this.butConnect.Click += new System.EventHandler(this.butConnect_Click);
            // 
            // ButDisconnect
            // 
            this.ButDisconnect.BackColor = System.Drawing.SystemColors.Info;
            this.ButDisconnect.ForeColor = System.Drawing.Color.Red;
            this.ButDisconnect.Location = new System.Drawing.Point(123, 209);
            this.ButDisconnect.Name = "ButDisconnect";
            this.ButDisconnect.Size = new System.Drawing.Size(74, 63);
            this.ButDisconnect.TabIndex = 6;
            this.ButDisconnect.Text = "Ngat Ket Noi";
            this.ButDisconnect.UseVisualStyleBackColor = false;
            this.ButDisconnect.Click += new System.EventHandler(this.ButDisconnect_Click);
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Red;
            this.butExit.ForeColor = System.Drawing.Color.LightGray;
            this.butExit.Location = new System.Drawing.Point(230, 209);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(74, 63);
            this.butExit.TabIndex = 7;
            this.butExit.Text = "Thoat";
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // lbTrangthai
            // 
            this.lbTrangthai.AutoSize = true;
            this.lbTrangthai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbTrangthai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTrangthai.Location = new System.Drawing.Point(533, 96);
            this.lbTrangthai.Name = "lbTrangthai";
            this.lbTrangthai.Size = new System.Drawing.Size(117, 22);
            this.lbTrangthai.TabIndex = 8;
            this.lbTrangthai.Text = "Chua Ket Noi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(362, 96);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Trang Thai: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(490, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Du lieu Tu Arduino";
            // 
            // txtDataReceived
            // 
            this.txtDataReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtDataReceived.Location = new System.Drawing.Point(415, 209);
            this.txtDataReceived.Name = "txtDataReceived";
            this.txtDataReceived.Size = new System.Drawing.Size(289, 30);
            this.txtDataReceived.TabIndex = 11;
            this.txtDataReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataReceived.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // serCOM
            // 
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCOM_DataReceived);
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(847, 210);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(244, 29);
            this.txtMessages.TabIndex = 12;
            this.txtMessages.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(935, 181);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 659);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtMessages);
            this.Controls.Add(this.txtDataReceived);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTrangthai);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.ButDisconnect);
            this.Controls.Add(this.butConnect);
            this.Controls.Add(this.cboBaudrate);
            this.Controls.Add(this.cboCOM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCOM;
        private System.Windows.Forms.ComboBox cboBaudrate;
        private System.Windows.Forms.Button butConnect;
        private System.Windows.Forms.Button ButDisconnect;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label lbTrangthai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDataReceived;
        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.TextBox txtMessages;
        private System.Windows.Forms.Button btnConnect;
    }
}


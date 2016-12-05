namespace U101B117HW1_Add_1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.textCode = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnBuyPower = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textCounty = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblcode = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textZip = new System.Windows.Forms.TextBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtOk = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.Delay = new System.Windows.Forms.Timer(this.components);
            this.TimerCheck = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 329);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 304);
            this.listBox1.TabIndex = 15;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(196, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1024, 647);
            this.webBrowser1.TabIndex = 14;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.textCode);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnBuyPower);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btnCheckout);
            this.groupBox1.Controls.Add(this.btnCheck);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.textPhone);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.textCity);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.textCounty);
            this.groupBox1.Controls.Add(this.lblPwd);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.lblZip);
            this.groupBox1.Controls.Add(this.lblcode);
            this.groupBox1.Controls.Add(this.textID);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.textAddress);
            this.groupBox1.Controls.Add(this.textZip);
            this.groupBox1.Controls.Add(this.textPwd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 639);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "資料欄";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(116, 301);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(44, 23);
            this.btnSend.TabIndex = 22;
            this.btnSend.Text = "送出";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(9, 301);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(100, 22);
            this.textCode.TabIndex = 20;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(111, 215);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(49, 24);
            this.btnStop.TabIndex = 19;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnBuyPower
            // 
            this.btnBuyPower.Location = new System.Drawing.Point(9, 216);
            this.btnBuyPower.Name = "btnBuyPower";
            this.btnBuyPower.Size = new System.Drawing.Size(96, 24);
            this.btnBuyPower.TabIndex = 18;
            this.btnBuyPower.Text = "購買行動電源";
            this.btnBuyPower.UseVisualStyleBackColor = true;
            this.btnBuyPower.Click += new System.EventHandler(this.btnBuyPower_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(114, 246);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(46, 49);
            this.btnCheckout.TabIndex = 16;
            this.btnCheckout.Text = "結帳";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(62, 246);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(46, 49);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "檢測";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(9, 246);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(47, 49);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPhone.Location = new System.Drawing.Point(6, 194);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 16);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "電話：";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(60, 187);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 22);
            this.textPhone.TabIndex = 12;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblID.Location = new System.Drawing.Point(6, 27);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(56, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "帳號：";
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(112, 103);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(48, 22);
            this.textCity.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAddress.Location = new System.Drawing.Point(6, 135);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 16);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "地址：";
            // 
            // textCounty
            // 
            this.textCounty.Location = new System.Drawing.Point(60, 104);
            this.textCounty.Name = "textCounty";
            this.textCounty.Size = new System.Drawing.Size(48, 22);
            this.textCounty.TabIndex = 8;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPwd.Location = new System.Drawing.Point(6, 52);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(56, 16);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "密碼：";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(60, 76);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 22);
            this.textName.TabIndex = 7;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblZip.Location = new System.Drawing.Point(6, 160);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(56, 16);
            this.lblZip.TabIndex = 2;
            this.lblZip.Text = "區號：";
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblcode.Location = new System.Drawing.Point(6, 108);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(56, 16);
            this.lblcode.TabIndex = 6;
            this.lblcode.Text = "縣市：";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(60, 20);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 22);
            this.textID.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(6, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "姓名：";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(60, 128);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 22);
            this.textAddress.TabIndex = 3;
            // 
            // textZip
            // 
            this.textZip.Location = new System.Drawing.Point(60, 156);
            this.textZip.Name = "textZip";
            this.textZip.Size = new System.Drawing.Size(100, 22);
            this.textZip.TabIndex = 4;
            // 
            // textPwd
            // 
            this.textPwd.Location = new System.Drawing.Point(60, 48);
            this.textPwd.Name = "textPwd";
            this.textPwd.Size = new System.Drawing.Size(100, 22);
            this.textPwd.TabIndex = 4;
            this.textPwd.UseSystemPasswordChar = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtDate,
            this.txtOk,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 654);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1220, 24);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtDate
            // 
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(401, 19);
            this.txtDate.Spring = true;
            this.txtDate.Text = "txtDate";
            // 
            // txtOk
            // 
            this.txtOk.Name = "txtOk";
            this.txtOk.Size = new System.Drawing.Size(401, 19);
            this.txtOk.Spring = true;
            this.txtOk.Text = "成功：0 個";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(401, 19);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "By.shuangrain(2014.04.01)";
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // Delay
            // 
            this.Delay.Interval = 1000;
            this.Delay.Tick += new System.EventHandler(this.Delay_Tick);
            // 
            // TimerCheck
            // 
            this.TimerCheck.Interval = 1500;
            this.TimerCheck.Tick += new System.EventHandler(this.TimerCheck_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 678);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "小米行動電源輔助程式...";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textCounty;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textZip;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtDate;
        private System.Windows.Forms.ToolStripStatusLabel txtOk;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer Delay;
        private System.Windows.Forms.Timer TimerCheck;
        private System.Windows.Forms.Button btnBuyPower;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textCode;
    }
}


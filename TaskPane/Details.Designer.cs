namespace Wexcel
{
    partial class Details
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtWeibo = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnMe = new System.Windows.Forms.Button();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.btnTimeSetting = new System.Windows.Forms.Button();
            this.lblTimeSetting = new System.Windows.Forms.Label();
            this.txtTimeSetting = new System.Windows.Forms.TextBox();
            this.panelLogin.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.btnOk);
            this.panelLogin.Controls.Add(this.btnCancel);
            this.panelLogin.Controls.Add(this.txtAccount);
            this.panelLogin.Controls.Add(this.lblError);
            this.panelLogin.Controls.Add(this.lblPassword);
            this.panelLogin.Controls.Add(this.lblAccount);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(255, 413);
            this.panelLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(77, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(152, 21);
            this.txtPassword.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(32, 160);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(197, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(32, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(197, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccount.Location = new System.Drawing.Point(77, 47);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(152, 21);
            this.txtAccount.TabIndex = 2;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(30, 128);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 12);
            this.lblError.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(30, 90);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 12);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "密码：";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(30, 50);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(41, 12);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "账号：";
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.btnRefresh);
            this.panelAccount.Controls.Add(this.txtWeibo);
            this.panelAccount.Controls.Add(this.btnSend);
            this.panelAccount.Controls.Add(this.btnMe);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(255, 413);
            this.panelAccount.TabIndex = 6;
            this.panelAccount.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(15, 105);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(225, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "查看最新微博";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtWeibo
            // 
            this.txtWeibo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWeibo.Location = new System.Drawing.Point(15, 30);
            this.txtWeibo.Name = "txtWeibo";
            this.txtWeibo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWeibo.Size = new System.Drawing.Size(225, 21);
            this.txtWeibo.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(15, 65);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(225, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "发微博";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnMe
            // 
            this.btnMe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMe.Location = new System.Drawing.Point(15, 143);
            this.btnMe.Name = "btnMe";
            this.btnMe.Size = new System.Drawing.Size(225, 23);
            this.btnMe.TabIndex = 0;
            this.btnMe.Text = "查看个人信息";
            this.btnMe.UseVisualStyleBackColor = true;
            this.btnMe.Click += new System.EventHandler(this.btnMe_Click);
            // 
            // panelSetting
            // 
            this.panelSetting.Controls.Add(this.txtTimeSetting);
            this.panelSetting.Controls.Add(this.lblTimeSetting);
            this.panelSetting.Controls.Add(this.btnTimeSetting);
            this.panelSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSetting.Location = new System.Drawing.Point(0, 0);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(255, 413);
            this.panelSetting.TabIndex = 4;
            this.panelSetting.Visible = false;
            // 
            // btnTimeSetting
            // 
            this.btnTimeSetting.Location = new System.Drawing.Point(32, 105);
            this.btnTimeSetting.Name = "btnTimeSetting";
            this.btnTimeSetting.Size = new System.Drawing.Size(75, 23);
            this.btnTimeSetting.TabIndex = 0;
            this.btnTimeSetting.Text = "确定";
            this.btnTimeSetting.UseVisualStyleBackColor = true;
            this.btnTimeSetting.Click += new System.EventHandler(this.btnTimeSetting_Click);
            // 
            // lblTimeSetting
            // 
            this.lblTimeSetting.AutoSize = true;
            this.lblTimeSetting.Location = new System.Drawing.Point(30, 30);
            this.lblTimeSetting.Name = "lblTimeSetting";
            this.lblTimeSetting.Size = new System.Drawing.Size(89, 12);
            this.lblTimeSetting.TabIndex = 1;
            this.lblTimeSetting.Text = "输入时间（s）:";
            // 
            // txtTimeSetting
            // 
            this.txtTimeSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimeSetting.Location = new System.Drawing.Point(32, 66);
            this.txtTimeSetting.Name = "txtTimeSetting";
            this.txtTimeSetting.Size = new System.Drawing.Size(197, 21);
            this.txtTimeSetting.TabIndex = 2;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.panelAccount);
            this.Controls.Add(this.panelLogin);
            this.Name = "Details";
            this.Size = new System.Drawing.Size(255, 413);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnMe;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtWeibo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.TextBox txtTimeSetting;
        private System.Windows.Forms.Label lblTimeSetting;
        private System.Windows.Forms.Button btnTimeSetting;
    }
}

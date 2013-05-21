namespace Wexcel
{
    partial class Wexcel : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Wexcel()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            this.tabWexcel = this.Factory.CreateRibbonTab();
            this.grpAccount = this.Factory.CreateRibbonGroup();
            this.btnLogin = this.Factory.CreateRibbonButton();
            this.btnLogout = this.Factory.CreateRibbonButton();
            this.tabWexcel.SuspendLayout();
            this.grpAccount.SuspendLayout();
            // 
            // tabWexcel
            // 
            this.tabWexcel.Groups.Add(this.grpAccount);
            this.tabWexcel.Label = "Wexcel";
            this.tabWexcel.Name = "tabWexcel";
            // 
            // grpAccount
            // 
            this.grpAccount.Items.Add(this.btnLogin);
            this.grpAccount.Items.Add(this.btnLogout);
            this.grpAccount.Label = "账号";
            this.grpAccount.Name = "grpAccount";
            // 
            // btnLogin
            // 
            this.btnLogin.Label = "登录";
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLogin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Label = "注销";
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnLogout_Click);
            // 
            // Wexcel
            // 
            this.Name = "Wexcel";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tabWexcel);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Wexcel_Load);
            this.tabWexcel.ResumeLayout(false);
            this.tabWexcel.PerformLayout();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabWexcel;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpAccount;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLogin;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnLogout;
    }

    partial class ThisRibbonCollection
    {
        internal Wexcel Wexcel
        {
            get { return this.GetRibbon<Wexcel>(); }
        }
    }
}

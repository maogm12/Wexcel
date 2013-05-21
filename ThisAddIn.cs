using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools;
using System.Windows.Forms;

namespace Wexcel
{
    public partial class ThisAddIn
    {
        public CustomTaskPane taskPane = null;
        public Details taskPaneView = null;
        
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            taskPaneView = new Details();
            taskPane = this.CustomTaskPanes.Add(taskPaneView, "微博");
            taskPane.Width = 300;
            taskPane.Visible = false;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            Weibo.Instance.Logout();
        }


        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Wexcel
{
    public partial class Wexcel
    {
        private void Wexcel_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, RibbonControlEventArgs e)
        {
            if (Globals.ThisAddIn.taskPane != null)
            {
                Globals.ThisAddIn.taskPane.Visible = true;
                Globals.ThisAddIn.taskPaneView.ShowLogin();
            }
        }

        private void btnLogout_Click(object sender, RibbonControlEventArgs e)
        {
            if (Globals.ThisAddIn.taskPane != null)
            {
                Weibo.Instance.Logout();
                Globals.ThisAddIn.taskPaneView.ShowLogin();
                Globals.ThisAddIn.taskPane.Visible = false;
            }
        }
    }
}

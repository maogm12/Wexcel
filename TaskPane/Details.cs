using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NetDimension.Weibo;
using NetDimension.Json;

namespace Wexcel
{
    public partial class Details : UserControl
    {
        public Details()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Globals.ThisAddIn.taskPane != null)
            {
                Globals.ThisAddIn.taskPane.Visible = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string passport = this.txtAccount.Text;
            string password = this.txtPassword.Text;

            if (!Weibo.Instance.Login(passport, password))
            {
                lblError.Text = "登录失败";
            }
            else
            {
                panelAccount.Visible = true;
                panelLogin.Visible = false;
            }
        }

        private void btnMe_Click(object sender, EventArgs e)
        {
            Displayer.Instance.Clear();

            dynamic userInfo = Weibo.Instance.GetUserInfo();

            if (userInfo != null)
            {
                Displayer.Instance.display(1, 1, "ID");
                Displayer.Instance.display(1, 2, userInfo.idstr);

                Displayer.Instance.display(2, 1, "昵称");
                Displayer.Instance.display(2, 2, userInfo.screen_name);

                Displayer.Instance.display(3, 1, "个人描述");
                Displayer.Instance.display(3, 2, userInfo.description);

                Displayer.Instance.display(4, 1, "所在地");
                Displayer.Instance.display(4, 2, userInfo.location);

                Displayer.Instance.display(5, 1, "微博地址");
                Displayer.Instance.display(5, 2, userInfo.profile_url);

                Displayer.Instance.display(6, 1, "性别");
                if (userInfo.gender == "m")
                {
                    Displayer.Instance.display(6, 2, "男");
                }
                else if (userInfo.gender == "f") 
                {
                    Displayer.Instance.display(6, 2, "女");
                }
                else
                {
                    Displayer.Instance.display(6, 2, "未知");
                }

                Displayer.Instance.display(7, 1, "粉丝数");
                Displayer.Instance.display(7, 2, userInfo.followers_count);

                Displayer.Instance.display(8, 1, "关注数");
                Displayer.Instance.display(8, 2, userInfo.friends_count);

                Displayer.Instance.display(9, 1, "最近微博");
                Displayer.Instance.display(9, 2, userInfo.status.text);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string weibo = txtWeibo.Text;
            Weibo.Instance.SendWeibo(weibo);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Displayer.Instance.Clear();

            var homeTimeLine = Weibo.Instance.GetWeibo();
            int i = 1;
            foreach (var item in homeTimeLine.statuses)
            {
                Displayer.Instance.display(i, 1, item.user.name);
                Displayer.Instance.display(i, 2, item.created_at);
                Displayer.Instance.display(i, 3, item.text);
                i++;
            }
        }

        public void ShowLogin()
        {
            panelAccount.Visible = false;
            panelLogin.Visible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using NetDimension.Weibo;

namespace Wexcel
{
    class Weibo
    {
        private static Weibo instance = null;
        private Weibo() { }
        public static Weibo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Weibo();
                }
                return instance;
            }
        }

        static string AppKey = Properties.Settings.Default.Appkey;
        static string AppSecret = Properties.Settings.Default.AppSecrect;
        OAuth oauth = null;
        string accessToken = "";
        bool online = false;
        Client sina = null;

        public bool Login(string passport, string password)
        { 
            accessToken = Properties.Settings.Default.AccessToken;
            if (string.IsNullOrEmpty(accessToken))
            {
                try
                {
                    oauth = Authorize(passport, password);
                    online = true;
                    sina = new Client(oauth);
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
            else
            {
                /*
                oauth = new OAuth(AppKey, AppSecret, accessToken, "");
                TokenResult result = oauth.VerifierAccessToken();
                if (result == TokenResult.Success)
                {
                    //empty
                }
                else
                {

                    return false;
                }
                */

                return true;
            }

            return true;
        }

        public void Logout()
        {
            if (online)
            {
                sina.API.Dynamic.Account.EndSession();
            }
        }

        static OAuth Authorize(string passport, string password)
        {
            OAuth o = new OAuth(Properties.Settings.Default.Appkey, Properties.Settings.Default.AppSecrect, Properties.Settings.Default.CallbackUrl);
            if (!o.ClientLogin(passport, password))
            {
                throw new Exception("认证失败");
            }
            return o;
        }

        public dynamic GetUserInfo()
        {
            if (online)
            {
                string uid = sina.API.Entity.Account.GetUID();
                var userInfo = sina.API.Dynamic.Users.Show(uid);
                return userInfo;
            }
            else
                return null;
        }

        public dynamic GetWeibo()
        {
            if (online)
            {
                return sina.API.Dynamic.Statuses.HomeTimeline();
            }
            else
            {
                return null;
            }
        }

        public void SendWeibo(string wb, bool withTime = true)
        {
            if (String.IsNullOrWhiteSpace(wb))
                wb = "test weibo from Wexcel";

            if (withTime)
                sina.API.Entity.Statuses.Update(String.Format("{0} [at {1}]", wb, DateTime.Now.ToShortDateString()));
            else
                sina.API.Entity.Statuses.Update(wb);
            
            System.Windows.Forms.MessageBox.Show("发送成功");
        }
    }
}

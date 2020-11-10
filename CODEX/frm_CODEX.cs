using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using System.Reflection;
using SwitchUserControl;
using CODEX.Utils;
using System.IO;

namespace CODEX
{
    public partial class frm_CODEX : Form
    {
        public frm_CODEX()
        {
            InitializeComponent();
        }

        private void CODEX_Load(object sender, EventArgs e)
        {
            // loadingAnimation();
            btn_Home.PerformClick();
            checkUpdate();
        }

        #region sidebar
        private void btns_SideBar_Click(object sender, EventArgs e)
        {
            GunaButton btn = ((GunaButton)sender);
            pbox_top.Image = btn.OnHoverImage;
            lbl_top.Text = btn.Text;
            pnl_sidebar.Location = new Point(11, btn.Location.Y);
            SwitchUserControl.SwitchUserControl.Switch(pnl_main, GetUserControlInstance(btn.Text));
        }


        UserControl home, search, settings;
        private UserControl GetUserControlInstance(string buttonName)
        {
            switch (buttonName)
            {
                case "Home":
                    if (home == null)
                        home = CreateUserControl(buttonName);
                    return home;
                case "Search":
                    if (search == null)
                        search = CreateUserControl(buttonName);
                    return search;
                case "Settings":
                    if (settings == null)
                        settings = CreateUserControl(buttonName);
                    return settings;
                default:
                    return null;
            }
        }

        private void pbox_notification_Click(object sender, EventArgs e)
        {
            btn_Settings.PerformClick();
        }

        private UserControl CreateUserControl(string usercontrolName)
        {
            return (UserControl)Assembly.GetExecutingAssembly().CreateInstance($"CODEX.Views.{usercontrolName}.uc_{usercontrolName}"); ;
        }

        #endregion

        #region  checkUpdate
        private static string configIniPath = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\config.ini";
        INIFile ini = new INIFile(configIniPath);
        void checkUpdate()
        {
            string lastestVersion;
            using (var wc = new System.Net.WebClient())
                lastestVersion = wc.DownloadString(ini.IniReadValue("VERSION", "LastestVersionUrl"));
            if (!ini.IniReadValue("VERSION", "CurrentVersion").Equals(lastestVersion))
            {
                pbox_notification.Visible = true;
                pbox_show_notification.Visible = true;
            }
        }
            #endregion

        #region loading animation
            public void loadingAnimation()
            {
                pbox_top.Image = Properties.Resources.loading;
                lbl_top.Text = "Loading";
                LoadingAnimation.loading(pnl_main);
            }
            #endregion
        }
    }

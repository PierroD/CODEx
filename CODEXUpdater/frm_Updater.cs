using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CODEXUpdater.Utils;

namespace CODEXUpdater
{
    public partial class frm_updater : Form
    {
        public frm_updater()
        {
            InitializeComponent();
        }

        private void frm_updater_Load(object sender, EventArgs e)
        {
            LoadingAnimation.loading(pnl_loading);
        }

        private void frm_updater_Shown(object sender, EventArgs e)
        {
            timer_update.Start();
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            Process.Start($"{Directory.GetCurrentDirectory()}\\CODEx.exe");
            Application.Exit();
        }

        private static string configIniPath = $"{Directory.GetCurrentDirectory()}\\config.ini";
        INIFile ini = new INIFile(configIniPath);
        private string tempFolder = Path.GetTempPath() + "CODEX";
        private void timer_update_Tick(object sender, EventArgs e)
        {
            string[] updateDownload;
            using (var wc = new WebClient())
                updateDownload = wc.DownloadString(ini.IniReadValue("VERSION", "UpdateDownloadUrl")).Split(new[] { '\r', '\n' });

            if (!Directory.Exists(tempFolder))
            {
                Directory.CreateDirectory(tempFolder);
                lbl_action.Text = "Create temp download folder";
            }
            string zip_path = tempFolder + "\\" + Guid.NewGuid() + ".zip";
            updateActionLabel("Downloading update");
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFile(
                    // download link
                    new Uri(updateDownload[0]),
                    // physical link
                    zip_path
                    );
            }
            updateActionLabel("Extracting files and updating CODEx");
            string install_path = Directory.GetCurrentDirectory();
            using (var strm = File.OpenRead(zip_path))
            using (ZipArchive archive = new ZipArchive(strm))
                ZipArchiveExtensions.ExtractToDirectory(archive, install_path, true);

            updateActionLabel("Updating CODEx config file");
            ini.IniWriteValue("VERSION", "CurrentVersion", new WebClient().DownloadString(ini.IniReadValue("VERSION", "LastestVersionUrl")));
            updateActionLabel("Update is done");
            pnl_loading.Dispose();
            btn_end.Visible = true;
            timer_update.Stop();
        }

        void updateActionLabel(string content)
        {
            lbl_action.Text = content;
            lbl_action.Refresh();
        }
    }
}

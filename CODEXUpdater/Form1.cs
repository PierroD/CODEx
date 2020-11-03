using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private static string configIniPath = $"{Directory.GetCurrentDirectory()}\\config.ini";
        INIFile ini = new INIFile(configIniPath);
        private string tempFolder = Path.GetTempPath() + "CODEX";
        private void frm_updater_Shown(object sender, EventArgs e)
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
            lbl_action.Text = "Downloading update";
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileAsync(
                    // download link
                    new Uri(updateDownload.LastOrDefault()),
                    // physical link
                    zip_path
                    );
            }
            lbl_action.Text = "Extracting files and updating CODEx";
            string install_path = Directory.GetCurrentDirectory();
            using (var strm = File.OpenRead(zip_path))
            using (ZipArchive a = new ZipArchive(strm))
            {
                a.Entries.Where(o => o.Name != string.Empty).ToList().ForEach(f => f.ExtractToFile(Path.Combine(install_path, f.FullName), true));
            }
            ini.IniWriteValue("VERSION", "CurrentVersion", new WebClient().DownloadString(ini.IniReadValue("VERSION", "LastestVersionUrl")));
            btn_end.Visible = true;
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            // start codex
        }
    }
}

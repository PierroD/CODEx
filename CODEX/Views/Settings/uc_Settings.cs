using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CODEX.Utils;


namespace CODEX.Views.Settings
{
    public partial class uc_Settings : UserControl
    {
        public uc_Settings()
        {
            InitializeComponent();
        }

        private void uc_Settings_Load(object sender, EventArgs e)
        {
            ConfigPath();
            CheckLastestVersion();
            UpdateChanges();
        }

        private void btn_selectConfigFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    CheckIfConfigFolderExist(fbd.SelectedPath, false);

            }
        }


        #region configPath & CheckIfConfigFolderExist
        private static string configIniPath = $"{Directory.GetCurrentDirectory()}\\config.ini";
        INIFile ini = new INIFile(configIniPath);


        /// <summary>
        /// Return where the config files are located
        /// </summary>
        /// <returns>configPath</returns>
        void ConfigPath()
        {
            if (ini.IniReadValue("PATHS", "ConfigPath") != String.Empty)
                CheckIfConfigFolderExist(ini.IniReadValue("PATHS", "ConfigPath"), false);
            else
                CheckIfConfigFolderExist(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), true);
        }
        /// <summary>
        /// Check if the config folder exist, if not, it creates it
        /// </summary>
        /// <param name="folderPath"></param>
        /// <param name="createfolder"></param>
        /// <returns>
        /// the config folder path
        /// </returns>

        void CheckIfConfigFolderExist(string folderPath, bool createfolder)
        {
            if (createfolder)
                folderPath += "\\CODEx";
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);


            ini.IniWriteValue("PATHS", "ConfigPath", folderPath);
            tbox_configFolderPath.Text = folderPath;
        }
        #endregion

        void CheckLastestVersion()
        {
            string lastestVersion;
            using (var wc = new System.Net.WebClient())
                lastestVersion = wc.DownloadString(ini.IniReadValue("VERSION", "LastestVersionUrl"));
            if (!ini.IniReadValue("VERSION", "CurrentVersion").Equals(lastestVersion))
                btn_update.Visible = true;
        }

        void UpdateChanges()
        {
            using (var wc = new System.Net.WebClient())
                tbox_updates.Text = wc.DownloadString(ini.IniReadValue("VERSION", "UpdateChangesUrl")); 
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // start updater
        }
    }
}

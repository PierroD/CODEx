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
            InitializeSettings();
        }

        private static string configIniPath = $"{Directory.GetCurrentDirectory()}\\config.ini";
        INIFile ini = new INIFile(configIniPath);

        void InitializeSettings()
        {
            if (ini.IniReadValue("PATHS", "ConfigPath") != String.Empty)
                CheckIfConfigFolderExist(ini.IniReadValue("PATHS", "ConfigPath"), false);
            else
                CheckIfConfigFolderExist(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), true);
        }

        void CheckIfConfigFolderExist(string folderPath, bool createfolder)
        {
            if (createfolder)
                folderPath += "\\CODEx";
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);


            ini.IniWriteValue("PATHS", "ConfigPath", folderPath);
            tbox_configFolderPath.Text = folderPath;
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
    }
}

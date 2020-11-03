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
using Newtonsoft.Json;
using CODEX.Utils;
using CODEXOffsets;
using CODEX.Views.Home.MacroModel;
using System.Runtime.InteropServices;

namespace CODEX.Views.Home
{
    public partial class uc_Home : UserControl
    {
        public uc_Home()
        {
            InitializeComponent();
        }

        private void btn_saveConfigFile_Click(object sender, EventArgs e)
        {
            if (tbox_configName.Text != String.Empty && tbox_configName.Text != "Config name")
                SaveConfig(tbox_configName.Text);
        }

        string[] configs;
        private void cbox_config_Click(object sender, EventArgs e)
        {
            cbox_config.Items.Clear();
            string configFolder = ConfigPath();
            configs = Directory.GetFiles(configFolder, "*.cfg");
            foreach (string config in configs)
            {
                cbox_config.Items.Add(Path.GetFileName(config));
            }
        }

        private void cbox_keys_Click(object sender, EventArgs e)
        {
            cbox_keys.Items.Clear();
            foreach (int key in Enum.GetValues(typeof(Keys)))
            {
                cbox_keys.Items.Add(Enum.GetName(typeof(Keys), key));
            }
        }

        private void btn_addMacro_Click(object sender, EventArgs e)
        {
            addMacro(configs[cbox_config.SelectedIndex], KeyStringToInt(cbox_keys.Text));
        }

        private void btn_loadConfig_Click(object sender, EventArgs e)
        {
            ofd_home.InitialDirectory = ConfigPath();
            if (ofd_home.ShowDialog() == DialogResult.OK)
            {
                LoadConfigFile(ofd_home.FileNames);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbl_configName.Text = "Config :";
            tbox_console.Text = String.Empty;
            tbox_configName.Text = "Config name";
            pnl_macros.Controls.Clear();
        }

        #region DLLs
        [DllImport("User32.dll")]
        private static extern bool GetAsyncKeyState(System.Windows.Forms.Keys vKey);
        #endregion
        private void timer_macro_Tick(object sender, EventArgs e)
        {
            lbl_gameName.Text = COD.LongGameName();
            foreach (Macro macro in GetMacros())
            {
                if (GetAsyncKeyState((Keys)Enum.Parse(typeof(Keys), ((Keys)macro.Key).ToString())))
                    SendDvarToGame(File.ReadAllLines(macro.CfgPath));
            }
        }

        private List<Macro> GetMacros()
        {
            List<Macro> macros = new List<Macro>();
            foreach (uc_Macro ucMacro in pnl_macros.Controls)
            {
                macros.Add(new Macro { CfgPath = ucMacro.CfgPath, Key = ucMacro.Key });
            }
            return macros;
        }

        private void btn_sendConsole_Click(object sender, EventArgs e)
        {
            SendDvarToGame(tbox_console.Lines);
        }


        #region SaveConfig
        void SaveConfig(string configName)
        {
            SavingJson savingJson = new SavingJson();
            string configFolder = ConfigPath();
            string[] configs = Directory.GetFiles(configFolder);
            if (configs.Where(c => Path.GetFileNameWithoutExtension(c) == configName).Count() > 0)
            {
                File.Delete($"{configFolder}\\{configName}.json");
                File.Delete($"{configFolder}\\{configName}.cfg");
            }
            savingJson.CfgPath = $"{configFolder}\\{configName}.cfg";
            using (var sw = new StreamWriter($"{configFolder}\\{configName}.cfg", true))
            {
                foreach (string line in tbox_console.Lines)
                {
                    sw.WriteLine(line);
                }
            }

            savingJson.Macros = GetMacros();
            using (JsonWriter writer = new JsonTextWriter(new StreamWriter($"{configFolder}\\{configName}.json")))
            {
                new JsonSerializer().Serialize(writer, savingJson);
            }
            Notify($"{configName}'s config saved successfully", "CODEx", "Config saved");
        }
        #endregion

        #region Notify
        void Notify(string tipText, string mainText, string tipTitle)
        {
            ni_home.BalloonTipText = tipText;
            ni_home.Text = mainText;
            ni_home.BalloonTipTitle = tipTitle;
            ni_home.Visible = true;
            ni_home.ShowBalloonTip(1000, tipTitle, tipText, ToolTipIcon.Info);
        }
        #endregion

        #region addMacro
        void addMacro(string cfgPath, int key)
        {
            pnl_macros.Controls.Add(new uc_Macro
            {
                CfgPath = cfgPath,
                Key = key
            });
        }
        #endregion

        #region KeyStringToInt
        private int KeyStringToInt(string keyName)
        {
            return (int)(Keys)Enum.Parse(typeof(Keys), keyName, true);
        }
        #endregion

        #region configName (Enter/Leave/KeyPress)
        private void tbox_configName_Enter(object sender, EventArgs e)
        {
            if (tbox_configName.Text == "Config name")
                tbox_configName.Text = String.Empty;
        }

        private void tbox_configName_Leave(object sender, EventArgs e)
        {
            if (tbox_configName.Text == String.Empty)
                tbox_configName.Text = "Config name";
        }

        private void tbox_configName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btn_saveConfigFile.PerformClick();
        }
        #endregion

        #region LoadConfigFile
        void LoadConfigFile(string[] filenames)
        {
            foreach (string file in filenames)
            {
                var configFile = JsonConvert.DeserializeObject<SavingJson>(File.ReadAllText(file));
                lbl_configName.Text += $" {Path.GetFileName(configFile.CfgPath)}";
                tbox_console.Text += File.ReadAllText(configFile.CfgPath);
                tbox_configName.Text += $" {Path.GetFileNameWithoutExtension(configFile.CfgPath)}";
                foreach (Macro macro in configFile.Macros)
                {
                    addMacro(macro.CfgPath, macro.Key);
                }
            }
        }
        #endregion

        #region ConfigPath & CheckIfConfigFolderExist
        INIFile ini = new INIFile($"{Directory.GetCurrentDirectory()}\\config.ini");
        private string ConfigPath()
        {
            if (ini.IniReadValue("PATHS", "ConfigPath") != String.Empty)
                return CheckIfConfigFolderExist(ini.IniReadValue("PATHS", "ConfigPath"), false);
            else
                return CheckIfConfigFolderExist(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), true);
        }
        string CheckIfConfigFolderExist(string folderPath, bool createfolder)
        {
            if (createfolder)
                folderPath += "\\CODEx";
            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            return folderPath;
        }
        #endregion

        #region SendDvarToGame
        private void SendDvarToGame(string[] dvars)
        {
            string command="";
            foreach(string dvar in dvars)
            {
                command += $"{dvar};";
            }
            ExternalConsole.Send(command);
        }
        #endregion
    }

    #region savingJson classes
    class SavingJson
    {
        public string CfgPath { get; set; }
        public List<Macro> Macros { get; set; }
    }
    class Macro
    {
        public string CfgPath { get; set; }
        public int Key { get; set; }
    }
    #endregion
}

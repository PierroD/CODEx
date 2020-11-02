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
using CODEX.Views.Home.MacroModel;


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

        INIFile ini = new INIFile($"{Directory.GetCurrentDirectory()}\\config.ini");
        void SaveConfig(string configName)
        {
            SavingJson savingJson = new SavingJson();
            string configFolder = ini.IniReadValue("PATHS", "ConfigPath");
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
            savingJson.Macros = macros;
            using (JsonWriter writer = new JsonTextWriter(new StreamWriter($"{configFolder}\\{configName}.json")))
            {
                new JsonSerializer().Serialize(writer, savingJson);
            }
            Notify($"{configName}'s config saved successfully", "CODEx", "Config saved");
        }

        void Notify(string tipText, string mainText, string tipTitle)
        {
            ni_home.BalloonTipText = tipText;
            ni_home.Text = mainText;
            ni_home.BalloonTipTitle = tipTitle;
            ni_home.Visible = true;
            ni_home.ShowBalloonTip(1000, tipTitle, tipText, ToolTipIcon.Info);
        }
        string[] configs;
        private void cbox_config_Click(object sender, EventArgs e)
        {
            cbox_config.Items.Clear();
            string configFolder = ini.IniReadValue("PATHS", "ConfigPath");
            configs = Directory.GetFiles(configFolder, "*.cfg");
            foreach(string config in configs)
            {
                cbox_config.Items.Add(Path.GetFileName(config));
            }
        }

        private void cbox_keys_Click(object sender, EventArgs e)
        {
            cbox_keys.Items.Clear();
            foreach(int key in Enum.GetValues(typeof(Keys)))
            {
                cbox_keys.Items.Add(Enum.GetName(typeof(Keys), key));
            }
        }
        List<Macro> macros = new List<Macro>();
        private void btn_addMacro_Click(object sender, EventArgs e)
        {
            pnl_macros.Controls.Add(new uc_Macro
            {
                CfgPath = configs[cbox_config.SelectedIndex],
                Key = KeyStringToInt(cbox_keys.Text)
            });
            macros.Add(new Macro { CfgPath = configs[cbox_config.SelectedIndex], Key = KeyStringToInt(cbox_keys.Text)});
        }

        private int KeyStringToInt(string keyName)
        {
            return (int)(Keys)Enum.Parse(typeof(Keys), keyName, true);
        }

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

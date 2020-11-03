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

namespace CODEX.Views.Home.MacroModel
{
    public partial class uc_Macro : UserControl
    {
        public uc_Macro()
        {
            InitializeComponent();
        }

        public string CfgPath { get; set; }
        public int Key { get; set; }

        private void uc_Macro_Load(object sender, EventArgs e)
        {
            lbl_config.Text = Path.GetFileName(CfgPath);
            lbl_key.Text = Enum.GetName(typeof(Keys), Key);
        }

        private void pbox_trashMacro_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
    }
}

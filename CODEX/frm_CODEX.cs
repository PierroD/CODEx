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
using SwitchUserControl;
using CODEX.Views.Home;
using System.Reflection;

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
            btn_Home.PerformClick();
        }

        private void btns_SideBar_Click(object sender, EventArgs e)
        {
            GunaButton btn = ((GunaButton)sender);
            pbox_top.Image = btn.Image;
            lbl_top.Text = btn.Text;
            pnl_sidebar.Location = new Point(11, btn.Location.Y);
            SwitchUserControl.SwitchUserControl.Switch(pnl_main, (UserControl)Assembly.GetExecutingAssembly().CreateInstance($"CODEX.Views.Home.uc_{btn.Text}"));
        }

    }
}

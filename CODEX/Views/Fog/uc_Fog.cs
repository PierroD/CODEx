using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using CODEX.Utils;
using CODEXOffsets;

namespace CODEX.Views.Fog
{
    public partial class uc_Fog : UserControl
    {
        public uc_Fog()
        {
            InitializeComponent();
        }

        Trainer t = new Trainer();

        #region fog
        private void colorWheel_Fog_ColorChanged(object sender, EventArgs e)
        {
            num_fogRed.Value = (long)colorWheel_Fog.Color.R;
            num_fogGreen.Value = (long)colorWheel_Fog.Color.G;
            num_fogBlue.Value = (long)colorWheel_Fog.Color.B;
            if (rbtn_base.Checked)
            {
                setFogAndDofValue("FogBaseColorR", num_fogRed.Value);
                setFogAndDofValue("FogBaseColorG", num_fogGreen.Value);
                setFogAndDofValue("FogBaseColorB", num_fogBlue.Value);
            }
            if (rbtn_far.Checked)
            {
                setFogAndDofValue("FogFarColorR", num_fogRed.Value);
                setFogAndDofValue("FogFarColorG", num_fogGreen.Value);
                setFogAndDofValue("FogFarColorB", num_fogBlue.Value);
            }
            if (rbtn_both.Checked)
            {
                setFogAndDofValue("FogBaseColorR", num_fogRed.Value);
                setFogAndDofValue("FogBaseColorG", num_fogGreen.Value);
                setFogAndDofValue("FogBaseColorB", num_fogBlue.Value);
                setFogAndDofValue("FogFarColorR", num_fogRed.Value);
                setFogAndDofValue("FogFarColorG", num_fogGreen.Value);
                setFogAndDofValue("FogFarColorB", num_fogBlue.Value);


            }
        }
        /// <summary>
        /// Fixe the white color was equals to 127;127;127
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void whiteColorFixe(object sender, EventArgs e)
        {
            if (num_fogRed.Value == 127 && num_fogGreen.Value == 127 && num_fogBlue.Value == 127)
            {
                num_fogRed.Value = 255;
                num_fogGreen.Value = 255;
                num_fogBlue.Value = 255;
            }
        }

        /// <summary>
        /// Generic way to set a trackbar.value to a label text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fogTbars_ToLbls(object sender, EventArgs e)
        {
            GunaTrackBar tbar = ((GunaTrackBar)sender);
            string option = tbar.Name.Substring(5);
            if (option != "FogBias")
            {
                this.Controls.Find($"lbl_value{option}", true).FirstOrDefault().Text = tbar.Value.ToString();
                setFogAndDofValue(option, (tbar.Value / 100));
            }
            else
            {
                this.Controls.Find($"lbl_value{option}", true).FirstOrDefault().Text = (tbar.Value - 37).ToString();
                setFogAndDofValue(option, (tbar.Value - 37));
            }

        }


        #endregion
        #region DOF (Depth of Field)
        /// <summary>
        /// Generic way to set a trackbar.value to a label text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dofTbars_ToLbls(object sender, EventArgs e)
        {
            GunaTrackBar tbar = ((GunaTrackBar)sender);
            string option = tbar.Name.Substring(5);
            if (option != "DOFfarBlur")
            {
                this.Controls.Find($"lbl_value{option}", true).FirstOrDefault().Text = ((double)tbar.Value).ToString();
                setFogAndDofValue(option, tbar.Value);
            }
            else
            {
                this.Controls.Find($"lbl_value{option}", true).FirstOrDefault().Text = ((double)tbar.Value / 100).ToString();
                setFogAndDofValue(option, (tbar.Value / 100));
            }
        }

        private void cbox_DOFenable_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_DOFenable.Checked)
                ExternalConsole.Send("r_Dof_Tweak 1;r_Dof_Bias 1;r_Dof_Enable 1;");
            else
                ExternalConsole.Send("r_Dof_Tweak 0;r_Dof_Bias 0;r_Dof_Enable 0;");
        }

        private void btn_copyToClipboard_Click(object sender, EventArgs e)
        {
            string commands = "r_Dof_Tweak 1;\nr_Dof_Bias 1;\nr_Dof_Enable 1;";
            commands += $"r_Dof_NearBlur {tbar_DOFnearBlur.Value};\n";
            commands += $"r_Dof_NearStart {tbar_DOFnearStart.Value};\n";
            commands += $"r_Dof_NearEnd {tbar_DOFnearEnd.Value};\n";
            commands += $"r_Dof_FarBlur {tbar_DOFfarBlur.Value};\n";
            commands += $"r_Dof_FarStart {tbar_DOFfarStart.Value};\n";
            commands += $"r_Dof_FarEnd {tbar_DOFfarEnd.Value};\n";
            Clipboard.SetText(commands);
            Notify($"Depth of field sttings has been copied to the clipboard", "CODEx", "Copied DVAR to the clipboard");
        }

        #endregion

        /// <summary>
        /// Generic way to send data to a COD (async to not make the ui laggy)
        /// </summary>
        /// <param name="address"></param>
        /// <param name="value"></param>
        private async void setFogAndDofValue(string address, float value)
        {
            await Task.Run(() =>
            {
                if (COD.checkGame() && COD.GameName() == "t6mp")
                {
                    dynamic cod = COD.Game();
                    t.Process_Handle(COD.GameName());
                    t.WriteFloat(cod.GetType().GetProperty(address).GetValue(cod), value);
                }
            });
        }

        #region Notify
        /// <summary>
        /// Notify Icon, to inform the user
        /// </summary>
        /// <param name="tipText"></param>
        /// <param name="mainText"></param>
        /// <param name="tipTitle"></param>
        void Notify(string tipText, string mainText, string tipTitle)
        {
            ni_foganddof.BalloonTipText = tipText;
            ni_foganddof.Text = mainText;
            ni_foganddof.BalloonTipTitle = tipTitle;
            ni_foganddof.Visible = true;
            ni_foganddof.ShowBalloonTip(1000, tipTitle, tipText, ToolTipIcon.Info);
            ni_foganddof.Visible = false;
        }
        #endregion
    }
}

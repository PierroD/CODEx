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
                setFogValue("FogBaseColorR", num_fogRed.Value);
                setFogValue("FogBaseColorG", num_fogGreen.Value);
                setFogValue("FogBaseColorB", num_fogBlue.Value);
            }
            if (rbtn_far.Checked)
            {
                setFogValue("FogFarColorR", num_fogRed.Value);
                setFogValue("FogFarColorG", num_fogGreen.Value);
                setFogValue("FogFarColorB", num_fogBlue.Value);
            }
            if (rbtn_both.Checked)
            {
                setFogValue("FogBaseColorR", num_fogRed.Value);
                setFogValue("FogBaseColorG", num_fogGreen.Value);
                setFogValue("FogBaseColorB", num_fogBlue.Value);
                setFogValue("FogFarColorR", num_fogRed.Value);
                setFogValue("FogFarColorG", num_fogGreen.Value);
                setFogValue("FogFarColorB", num_fogBlue.Value);


            }
        }

        private void whiteColorFixe(object sender, EventArgs e)
        {
            if (num_fogRed.Value == 127 && num_fogGreen.Value == 127 && num_fogBlue.Value == 127)
            {
                num_fogRed.Value = 255;
                num_fogGreen.Value = 255;
                num_fogBlue.Value = 255;
            }
        }

        private void fogTbars_ToLbls(object sender, EventArgs e)
        {
            GunaTrackBar tbar = ((GunaTrackBar)sender);
            string option = tbar.Name.Substring(5);
            switch (option)
            {
                case "FogBias":
                    this.Controls.Find($"lbl_value{option}", true).FirstOrDefault().Text = (tbar.Value - 37).ToString();
                    setFogValue(option, (tbar.Value - 37));
                    break;
                case "FogBaseExposure":
                    this.Controls.Find($"lbl_value{option}", true).FirstOrDefault().Text = ((double)tbar.Value / 100).ToString();
                    setFogValue(option, (tbar.Value / 100));
                    break;
                case "FogFarExposure":
                    this.Controls.Find($"lbl_value{option}", true).FirstOrDefault().Text = ((double)tbar.Value / 100).ToString();
                    setFogValue(option, (tbar.Value / 100));
                    break;
                default:
                    this.Controls.Find($"lbl_value{option}", true).FirstOrDefault().Text = tbar.Value.ToString();
                    setFogValue(option, tbar.Value);
                    break;
            }
        }

        private async void setFogValue(string address, float value)
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
        #endregion

        private void dofTbars_ToLbls(object sender, EventArgs e)
        {
            GunaTrackBar tbar = ((GunaTrackBar)sender);
            string option = tbar.Name.Substring(5);

        }
    }
}

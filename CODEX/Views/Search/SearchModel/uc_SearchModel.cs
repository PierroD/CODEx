using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODEX.Views.Search.SearchModel
{
    public partial class uc_SearchModel : UserControl
    {
        public uc_SearchModel()
        {
            InitializeComponent();
        }

        public string dvarName { get; set; }
        public string dvarDescription { get; set; }

        private void uc_SearchModel_Load(object sender, EventArgs e)
        {
            lbl_dvarName.Text = dvarName;
            lbl_dvarDescription.Text = dvarDescription;
        }

        private void pbox_copyDvar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dvarName);
            Notify($"The following DVAR {Environment.NewLine + dvarName} has been copied to the clipboard", "CODEx", "Copied DVAR to the clipboard");
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
            ni_searchModel.BalloonTipText = tipText;
            ni_searchModel.Text = mainText;
            ni_searchModel.BalloonTipTitle = tipTitle;
            ni_searchModel.Visible = true;
            ni_searchModel.ShowBalloonTip(1000, tipTitle, tipText, ToolTipIcon.Info);
            ni_searchModel.Visible = false;
        }
        #endregion
    }
}

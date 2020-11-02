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
    }
}

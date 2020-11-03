using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODEX.Utils.Loading
{
    public partial class uc_Loading : UserControl
    {
        public uc_Loading()
        {
            InitializeComponent();
        }

        private void timer_circleAnimation_Tick(object sender, EventArgs e)
        {
            LoadingCircleAnimation();
        }

        private void timer_textAnimation_Tick(object sender, EventArgs e)
        {
            LoadingTextAnimation();
        }

        #region circle animation
        int direction = 1;
        void LoadingCircleAnimation()
        {
            if (pbar_loading.Value == 70 || pbar_loading.Value == 0)
                direction = (direction == 1) ? -1 : 1; // change direction

            pbar_loading.Value += direction;
        }
        #endregion

        #region text animation
        int loadingCount = 0;
        void LoadingTextAnimation()
        {
            if (loadingCount < 3)
                lbl_titleLoading.Text += " .";
            else
            {
                lbl_titleLoading.Text = "Updating";
                loadingCount = -1;
            }

            loadingCount++;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwitchUserControl;
using System.Windows.Forms;
using CODEX.Utils.Loading;

namespace CODEX.Utils
{
    public class LoadingAnimation
    {
        public static void loading(Panel pnl)
        {
            SwitchUserControl.SwitchUserControl.Switch(pnl, new uc_Loading());

        }
    }
}

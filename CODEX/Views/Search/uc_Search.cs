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

namespace CODEX.Views.Search
{
    public partial class uc_Search : UserControl
    {
        public uc_Search()
        {
            InitializeComponent();
        }

        private static string JSONPath = $"{Directory.GetCurrentDirectory() }\\DVARList";
        private DVARList DvarLists;
        private void uc_Search_Load(object sender, EventArgs e)
        {
            DvarLists = LoadDvarLists();
        }

        #region LoadDvarLists
        private DVARList LoadDvarLists()
        {
            string[] folders = Directory.GetDirectories(JSONPath);
            DVARList dvarList = new DVARList();
            foreach (string folderPath in folders)
            {
                Game game = new Game();
                game.GameName = Path.GetFileNameWithoutExtension(folderPath); ;
                string[] files = Directory.GetFiles(folderPath);
                foreach (string filePath in files)
                {
                    List<Command> commands = new List<Command>();
                    using (var reader = new StreamReader(filePath))
                    {
                        string line = null;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (!string.IsNullOrEmpty(line))
                            {
                                commands.Add(JsonConvert.DeserializeObject<Command>(line));
                            }
                        }
                    }
                    if (game.Commands != null)
                        game.Commands.Concat(commands);
                    else
                        game.Commands = commands;
                }
                if (dvarList.Games == null)
                    dvarList.Games = new List<Game>();

                dvarList.Games.Add(game);
            }
            return dvarList;
        }
        #endregion

        #region search bar
        private void tbox_searchBar_Enter(object sender, EventArgs e)
        {
            if (tbox_searchBar.Text == "Search . . .")
                tbox_searchBar.Text = String.Empty;
        }

        private void tbox_searchBar_Leave(object sender, EventArgs e)
        {
            if (tbox_searchBar.Text == String.Empty)
                tbox_searchBar.Text = "Search . . .";
        }

        private void tbox_searchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SearchDvars(tbox_searchBar.Text);
        }

        #endregion

        #region Search
        void SearchDvars(string dvar)
        {
            Game searchingGame = DvarLists.Games.Where(g => g.GameName == cbox_SelectedDvarList.Text).FirstOrDefault();

        }
        #endregion
    }
    #region classes
    public class DVARList
    {
        public List<Game> Games { get; set; }
    }

    public class Game
    {
        public string GameName { get; set; }
        public List<Command> Commands { get; set; }
    }
    public class Command
    {
        public string Content { get; set; }
        public string Description { get; set; }

    }
    #endregion
}

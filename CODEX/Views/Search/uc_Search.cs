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
using CODEX.Views.Search.SearchModel;

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
            LoadSelectedDvarList();
            DvarLists = LoadDvarLists();
            if (cbox_SelectedDvarList.Text != String.Empty)
                SearchDvars("");
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cbox_SelectedDvarList.Text != String.Empty)
                SearchDvars(tbox_searchBar.Text);
            if (tbox_searchBar.Text == "Search . . .")
                SearchDvars("");
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

        #region LoadSelectedDvarList
        void LoadSelectedDvarList()
        {
            string[] games = Directory.GetDirectories(JSONPath);
            foreach(string game in games)
            {
                cbox_SelectedDvarList.Items.Add(new DirectoryInfo(game).Name);
            }
            if (games.Count() > 0)
                cbox_SelectedDvarList.SelectedIndex = 0;
        }
        #endregion

        #region search bar (Enter/Leave/KeyPress)
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

        #region SearchDvars
        void SearchDvars(string dvar)
        {
            pnl_dvars.Controls.Clear();
            Game game = DvarLists.Games.Where(g => g.GameName == cbox_SelectedDvarList.Text).FirstOrDefault();
            List<Command> commands = game.Commands.Where(c => c.Content.Contains(dvar) || c.Description.Contains(dvar)).ToList();
            foreach (Command command in commands)
            {
                pnl_dvars.Controls.Add(new uc_SearchModel
                {
                    dvarName = command.Content,
                    dvarDescription = command.Description
                });
            }
            lbl_result.Text = $"Result : {commands.Count()}/{game.Commands.Count()}";
        }
        #endregion
 
    }
    #region DVARList classes
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

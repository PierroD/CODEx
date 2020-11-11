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
using System.Reflection;

namespace CODEX.Views.Search
{
    public partial class uc_Search : UserControl
    {
        public uc_Search()
        {
            InitializeComponent();
        }

        private static string JSONPath = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) }\\DVARList";
        private DVARList DvarLists;
        private void uc_Search_Load(object sender, EventArgs e)
        {
            LoadSelectedDvarList();
            DvarLists = LoadDvarLists();
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cbox_SelectedDvarList.Text != String.Empty && cbox_SelectedDvarList.Text != "Search . . .")
                SearchDvars(tbox_searchBar.Text);

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
                string[] files = Directory.GetFiles(folderPath, "*.json");
                foreach (string filePath in files)
                {
                    var commands = JsonConvert.DeserializeObject<List<Command>>(File.ReadAllText(filePath));
                    if (game.Commands != null)
                        game.Commands.Concat(commands);
                    else
                        game.Commands = commands.ToList();
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
            foreach (string game in games)
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
            List<uc_SearchModel> searchResult = new List<uc_SearchModel>();
            foreach (Command command in commands)
            {
                searchResult.Add(new uc_SearchModel
                {
                    dvarName = command.Content,
                    dvarDescription = command.Description
                });
            }
            pnl_dvars.SuspendLayout();
            pnl_dvars.Controls.AddRange(searchResult.ToArray());
            pnl_dvars.ResumeLayout();
            this.ResumeLayout();
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

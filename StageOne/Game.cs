using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StageOne
{
    public partial class Game : Form
    {
        private Login _login_form;

        public Game(Login login)
        {
            _login_form = login;
            InitializeComponent();
        }

        private void update_chat_button_Click(object sender, EventArgs e)
        {
            GameDAO db_connection = new();
            UpdateListbox(chat_box, db_connection.GetChat());
        }

        private void update_leaderboard_button_Click(object sender, EventArgs e)
        {
            GameDAO db_connection = new();
            UpdateListbox(leaderboard_box, db_connection.GetLeaderboard());
        }

        private void UpdateListbox(ListBox listbox, List<String> list)
        {
            listbox.Items.Clear();

            list.ForEach(item =>
            {
                listbox.Items.Add(item);
            });
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            GameDAO db_connection = new();
            Boolean admin_result = db_connection.checkIsAdmin();

        }
    }
}

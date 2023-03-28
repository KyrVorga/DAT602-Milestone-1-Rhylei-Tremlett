using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        {   var listbox = chat_box.Items;
            

            GameDAO db_connection = new();


            List<String> list = db_connection.GetChat();

            list.ForEach(item =>
            {
                listbox.Add(item);
            });
        }
    }
}

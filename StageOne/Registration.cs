using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StageOne
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string username = username_input.Text;
            string password = password_input.Text;
            string email = email_input.Text;

            LoginAndRegistrationDAO db_connection = new();


            if (db_connection.RegisterUser(username, password, email) == "Error")
            {
                MessageBox.Show("Account creation failed, please try again.");
            }
            else
            {
                MessageBox.Show("Account created successfully.");
                this.Hide();
                //Game game = new Game(this);
                //game.Show();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StageOne
{
    public partial class SettingsUser : Form
    {
        private Game _game;

        public SettingsUser(Game game)
        {
            _game = game;
            InitializeComponent();
        }

        private void SettingsUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            _game.Show();
        }
    }
}

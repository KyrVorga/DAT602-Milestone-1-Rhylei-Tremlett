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
    public partial class SettingsAdmin : Form
    {
        private Game _game;
        public SettingsAdmin()
        {
            InitializeComponent();
        }
        public SettingsAdmin(Game? game)
            : this()
        {
            _game = game;
            InitializeComponent();
        }
    }
}

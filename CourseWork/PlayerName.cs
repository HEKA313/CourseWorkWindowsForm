using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class PlayerName : Form
    {
        public PlayerName()
        {
            InitializeComponent();
        }

        private void buttonPlayerNameOK_Click(object sender, EventArgs e)
        {
            MainForm.playerName = InputPlayerName.Text;
            Close();
        }
    }
}

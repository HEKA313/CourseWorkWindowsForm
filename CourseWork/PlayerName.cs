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
			buttonPlayerNameOK.Enabled = false;
		}

		public PlayerName(bool begin)
		{
			InitializeComponent();
			buttonPlayerNameCancel.Visible = false;
			buttonPlayerNameOK.Enabled = false;
		}

		private void buttonPlayerNameOK_Click(object sender, EventArgs e)
		{
			MainForm.playerName = InputPlayerName.Text;
			Close();
		}

		private void buttonPlayerNameCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

        private void InputPlayerName_TextChanged(object sender, EventArgs e)
        {
			if (!string.IsNullOrEmpty(InputPlayerName.Text)) buttonPlayerNameOK.Enabled = true;
			else buttonPlayerNameOK.Enabled = false;
        }
    }
}

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
	public partial class ErrorsCount : Form
	{
		public ErrorsCount()
		{
			InitializeComponent();
		}

        private void buttonErrorsOK_Click(object sender, EventArgs e)
        {
			MainForm.possibleErrors = Convert.ToInt32(errorSelection.Value);
			Close();
		}

        private void buttonErrorsCancel_Click(object sender, EventArgs e)
        {
			Close();
		}
	}
}

using Microsoft.Data.Sqlite;
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
    public partial class FormDefeat : Form
    {
        SqliteConnection connection = ConnectDB.ConnectToTheDB();

        public FormDefeat()
        {
            InitializeComponent();
            GenerateFormDefeat();
        }

        public void GenerateFormDefeat()
        {
			DateTime time = new DateTime(DateTime.MaxValue.Ticks);
			int movesCount = 0;
			var reader = ConnectDB.SelectFromTheDB(connection, @"SELECT EXISTS(SELECT _id FROM Recordsman WHERE Name == """ +
                MainForm.playerName + @""" AND DifficultyGame = """ + MainForm.complexity + @""" AND Field = """ + MainForm.field +
                @""") AS Name;");
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					if (reader.GetBoolean(0))
					{
						reader = ConnectDB.SelectFromTheDB(connection, @"SELECT Time, MovesCount FROM Recordsman WHERE Name = """ + MainForm.playerName + @"""");
						if (reader.HasRows)
						{
							while (reader.Read())
							{
								time = reader.GetDateTime(0);
								labelBestTimeCount.Text = Convert.ToDateTime(time.ToString()).ToLongTimeString();

							}
						}
						else
						{
							labelBestTimeCount.Text = Convert.ToDateTime(MainForm.time).ToLongTimeString();
						}
					}
					else
					{
						labelBestTimeCount.Text = Convert.ToDateTime(MainForm.time).ToLongTimeString();
					}
				}
			}
			else
			{
				labelBestTimeCount.Text = Convert.ToDateTime(MainForm.time).ToLongTimeString();
			}

			labelMovesCount.Text = MainForm.moves.ToString();
			labelTimeCount.Text = MainForm.time;
			labelHintsCount.Text = MainForm.hints.ToString();
		}

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

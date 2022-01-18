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
	public partial class TableOfRecords : Form
	{
		public static List<string[]> tableOfRecords = new List<string[]>();
		SqliteConnection connection = ConnectDB.ConnectToTheDB();

		public TableOfRecords()
		{
			InitializeComponent();
			SelectFromTheDB();
		}

		public void SelectFromTheDB()
		{
			var i = 0;
			var reader = ConnectDB.SelectFromTheDB(connection, @"SELECT * FROM Recordsman");
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					tableOfRecords.Add(new string[] {
						i++.ToString(),
						reader["Name"].ToString(),
						reader["DifficultyGame"].ToString(),
						reader["Field"].ToString(),
						reader["Time"].ToString(),
						reader["MovesCount"].ToString(),
						reader["HintsCount"].ToString()
					});
				}
			}
			AddToTheDataGridView();
		}

		public void AddToTheDataGridView()
		{
			for (int i = 0; i < tableOfRecords.Count(); i++)
			{
				for (int j = 0; j < tableOfRecords[i].Length; j++)
				{
					dataGridView1.Rows.Add();
					dataGridView1.Rows[i].Cells[j].Value = tableOfRecords[i][j].ToString();
				}
			}
		}

		private void TableOfRecords_FormClosing(object sender, FormClosingEventArgs e)
		{
			
		}

		private void TableOfRecords_FormClosed(object sender, FormClosedEventArgs e)
		{
			while (dataGridView1.Rows.Count > 1)
				for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
					dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
		}
	}
}

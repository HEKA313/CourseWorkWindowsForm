using Microsoft.Data.Sqlite;
using System;
using System.Collections;
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
        readonly SqliteConnection connection = ConnectDB.ConnectToTheDB();

		public TableOfRecords()
		{
			tableOfRecords.Clear();
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
                dataGridView1.Rows.Add();
                for (int j = 0; j < tableOfRecords[i].Length; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = tableOfRecords[i][j].ToString();
                }
            }
        }
	}
}

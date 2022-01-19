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
	public partial class FormWin : Form
	{
		SqliteConnection connection = ConnectDB.ConnectToTheDB();

		public FormWin()
		{
			InitializeComponent();
			GenerateFormWin();
		}

		public void GenerateFormWin()
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
								movesCount = reader.GetInt32(1);
								labelBestTimeCount.Text = Convert.ToDateTime(time.ToString()).ToLongTimeString();
								label2.Text = "Вы сыграли лучше " + HowMuchBetter() + "% игроков";

							}
						}
						else
						{
							labelBestTimeCount.Text = Convert.ToDateTime(MainForm.time).ToLongTimeString();
						}
						TimeAndMovesComparison(time, MainForm.time, movesCount, MainForm.moves);
					}
					else
					{
						labelBestTimeCount.Text = Convert.ToDateTime(MainForm.time).ToLongTimeString();
						InsertNewPlayer(MainForm.time, MainForm.moves);
					}
				}
			}
			else
			{
				labelBestTimeCount.Text = Convert.ToDateTime(MainForm.time).ToLongTimeString();
				label2.Text = "Вы сыграли лучше 100% игроков";
			}

			labelMovesCount.Text = MainForm.moves.ToString();
			labelTimeCount.Text = MainForm.time;
			labelHintsCount.Text = MainForm.hints.ToString();
		}

		public double HowMuchBetter()
		{
			var timePlayer = Convert.ToDateTime(MainForm.time).Ticks;
			int movesPlayer = MainForm.moves, hintsPlayer = MainForm.hints;
			var reader = ConnectDB.SelectFromTheDB(connection, @"SELECT Time, MovesCount, HintsCount FROM Recordsman WHERE DifficultyGame = """ +
				MainForm.complexity + @""" AND Field = """ + MainForm.field + @"""AND Name != """ + MainForm.playerName + @""";");
			double percent = 100;
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					List<long> timeFromDB = new List<long>((int)reader.GetDateTime(0).Ticks);
					List<int> movesFromDB = new List<int>(reader.GetInt32(1));
					List<int> hintsFromDB = new List<int>(reader.GetInt32(2));

					double percentTime = timePlayer / timeFromDB.Min() * 100;
					double percentMoves = movesPlayer / movesFromDB.Min() * 100;
					double percentHints = hintsPlayer / hintsFromDB.Min() * 100;

					if (timePlayer > timeFromDB.Min()) percentTime = 100;

					if (movesPlayer < movesFromDB.Min()) percentMoves = 100;

					if (hintsPlayer < hintsFromDB.Min()) percentHints = 100;

					percent = (percentTime + percentHints + percentMoves) / 3;
					percent = Math.Floor(percent);
				}
			}
			return percent;
		}

		public void InsertNewPlayer(string time, int moves)
		{
			ConnectDB.UpdateAndInsertTheDB(connection, @"INSERT INTO Recordsman('Name', 'DifficultyGame', 'Field', 'Time', 'MovesCount',
			'HintsCount') VALUES(""" + MainForm.playerName + @""", """ + MainForm.complexity + @""", """ + MainForm.field + @""", """ +
			time + @""", """ + moves.ToString() + @""", """ + MainForm.hints + @""")");
		}

		public void TimeAndMovesComparison(DateTime bestTime, string _time, int bestMoves, int moves)
		{
			var time = Convert.ToDateTime(_time);

			// Запись лучшего времени в бд
			if (time < bestTime)
			{
				// UPDATE Recordsman SET Time = time WHERE Name == playerName;
				ConnectDB.UpdateAndInsertTheDB(connection, @"UPDATE Recordsman SET Time = """ + _time + @""" WHERE Name == """ +
					MainForm.playerName + @"""");
			}

			// Запись лучшего количества ходов в бд
			if (moves < bestMoves)
			{
				// UPDATE Recordsman SET MovesCount = moves WHERE Name == playerName;
				ConnectDB.UpdateAndInsertTheDB(connection, @"UPDATE Recordsman SET MovesCount = """ + MainForm.moves + @""" WHERE Name == """ +
					MainForm.playerName + @"""");
			}
		}

		// Нажатие на кнопку "Новая игра" в форме победы
		private void buttonNewGame_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonBestTime_MouseMove(object sender, MouseEventArgs e)
		{
			// Всплывающее окно информации о том, сколько человек превзошел игрок
		}

		private void labelMovesCount_Click(object sender, EventArgs e)
		{

		}

		private void FormWin_Load(object sender, EventArgs e)
		{

		}
	}
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace CourseWork
{
	public partial class MainForm : Form
	{
		public static string complexity;
		public static string field;
		public static int hints;
		static Button pressedButton;
		public const int n = 3;
		const int sizeButton = 50;
		public static int[,] map = new int[n * n, n * n];
		public static Button[,] buttons = new Button[n * n, n * n];
		static DateTime date;
		static List<int[]> history = new List<int[]>();
		public static int moves;
		static bool stopTimer = false;
		static Dictionary<Control, Color> controls = new Dictionary<Control, Color>();
		public static string playerName;
		public static string time;

		public MainForm()
		{
			InitializeComponent();
			PlayerName();
			GenerateMap();
			FillingInConstants();
		}

		public void FillingInConstants()
		{
			if (простаяToolStripMenuItem.Checked) complexity = "Простая";
			if (средняяToolStripMenuItem.Checked) complexity = "Средняя";
			if (сложнаяToolStripMenuItem.Checked) complexity = "Сложная";

			if (ToolStripMenuItem9x9.Checked) field = "9x9";
			if (ToolStripMenuItem19х16.Checked) field = "16x16";
			if (ToolStripMenuItem125х25.Checked) field = "25x25";
		}

		public void GenerateMap()
		{
			date = DateTime.Now;
			history.Clear();

			for (int i = 0; i < n * n; i++)
			{
				for (int j = 0; j < n * n; j++)
				{
					map[i, j] = (i * n + i / n + j) % (n * n) + 1;
					buttons[i, j] = new Button();
				}
			}

			MatrixTransposition();
			SwapRowsInBlock();
			SwapColumnsInBlock();
			SwapBlocksInRow();
			SwapBlocksInColumn();

			Random r = new Random();

			for (int i = 0; i < 40; i++)
			{
				ShuffleMap(r.Next(0, 5));
			}

			button2.Enabled = false;
			CreateMap();
			HideCells();

			TimerStart();
		}

		public static void HideCells()
		{
			int N = 40;
			Random random = new Random();

			while (N > 0)
			{
				for (int i = 0; i < n * n; i++)
				{
					for (int j = 0; j < n * n; j++)
					{
						if (!string.IsNullOrEmpty(buttons[i, j].Text))
						{
							int a = random.Next(0, 3);
							buttons[i, j].Text = a == 0 ? "" : buttons[i, j].Text;
							buttons[i, j].Enabled = a == 0;

							if (a == 0)
								N--;
							if (N <= 0)
								break;
						}
					}

					if (N <= 0)
						break;
				}
			}
		}

		public static void ShuffleMap(int i)
		{
			switch (i)
			{
				case 0:
					MatrixTransposition();
					break;
				case 1:
					SwapRowsInBlock();
					break;
				case 2:
					SwapColumnsInBlock();
					break;
				case 3:
					SwapBlocksInRow();
					break;
				case 4:
					SwapBlocksInColumn();
					break;
				default:
					MatrixTransposition();
					break;
			}
		}

		public static void SwapBlocksInColumn()
		{
			Random random = new Random();
			var block1 = random.Next(0, n);
			var block2 = random.Next(0, n);
			while (block1 == block2)
				block2 = random.Next(0, n);
			block1 *= n;
			block2 *= n;
			for (int i = 0; i < n * n; i++)
			{
				var k = block2;
				for (int j = block1; j < block1 + n; j++)
				{
					var temp = map[i, j];
					map[i, j] = map[i, k];
					map[i, k] = temp;
					k++;
				}
			}
		}

		public static void SwapBlocksInRow()
		{
			Random random = new Random();
			var block1 = random.Next(0, n);
			var block2 = random.Next(0, n);
			while (block1 == block2)
				block2 = random.Next(0, n);
			block1 *= n;
			block2 *= n;
			for (int i = 0; i < n * n; i++)
			{
				var k = block2;
				for (int j = block1; j < block1 + n; j++)
				{
					var temp = map[j, i];
					map[j, i] = map[k, i];
					map[k, i] = temp;
					k++;
				}
			}
		}

		public static void SwapRowsInBlock()
		{
			Random random = new Random();
			var block = random.Next(0, n);
			var row1 = random.Next(0, n);
			var line1 = block * n + row1;
			var row2 = random.Next(0, n);
			while (row1 == row2)
				row2 = random.Next(0, n);
			var line2 = block * n + row2;
			for (int i = 0; i < n * n; i++)
			{
				var temp = map[line1, i];
				map[line1, i] = map[line2, i];
				map[line2, i] = temp;
			}
		}

		public static void SwapColumnsInBlock()
		{
			Random random = new Random();
			var block = random.Next(0, n);
			var row1 = random.Next(0, n);
			var line1 = block * n + row1;
			var row2 = random.Next(0, n);
			while (row1 == row2)
				row2 = random.Next(0, n);
			var line2 = block * n + row2;
			for (int i = 0; i < n * n; i++)
			{
				var temp = map[i, line1];
				map[i, line1] = map[i, line2];
				map[i, line2] = temp;
			}
		}

		public static void MatrixTransposition()
		{
			int[,] tMap = new int[n * n, n * n];
			for (int i = 0; i < n * n; i++)
			{
				for (int j = 0; j < n * n; j++)
				{
					tMap[i, j] = map[j, i];
				}
			}
			map = tMap;
		}

		public void CreateMap()
		{
			for (int i = 0; i < n * n; i++)
			{
				for (int j = 0; j < n * n; j++)
				{
					Button button = new Button();
					buttons[i, j] = button;
					button.Size = new Size(sizeButton, sizeButton);
					button.Text = map[i, j].ToString();
					button.Click += OnCellPressed;
					button.Location = new Point(15 + j * sizeButton, 30 + i * sizeButton);
					Controls.Add(button);
				}
			}
		}

		public static void OnCellPressed(object sender, EventArgs e)
		{
			pressedButton = sender as Button;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < n * n; i++)
			{
				for (int j = 0; j < n * n; j++)
				{
					Controls.Remove(buttons[i, j]);
				}
			}

			GenerateMap();
		}

		public void TimerStart()
		{
			Timer timer = new Timer
			{
				Interval = 10
			};
			timer.Tick += new EventHandler(timer1_Tick);
			timer.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (!stopTimer)
			{
				long tick = DateTime.Now.Ticks - date.Ticks;
				DateTime stopWatch = new DateTime();
				stopWatch = stopWatch.AddTicks(tick);
				label1.Text = string.Format("{0:HH:mm:ss}", stopWatch);
				time = label1.Text;
			}
		}

		private void Form1_Load_1(object sender, EventArgs e)
		{

		}

		void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			int codeKey = e.KeyValue;
			bool move = false;
			switch (codeKey)
			{
				case (char)Keys.D1:
					pressedButton.Text = "1";
					move = true;
					break;
				case (char)Keys.D2:
					pressedButton.Text = "2";
					move = true;
					break;
				case (char)Keys.D3:
					pressedButton.Text = "3";
					move = true;
					break;
				case (char)Keys.D4:
					pressedButton.Text = "4";
					move = true;
					break;
				case (char)Keys.D5:
					pressedButton.Text = "5";
					move = true;
					break;
				case (char)Keys.D6:
					pressedButton.Text = "6";
					move = true;
					break;
				case (char)Keys.D7:
					pressedButton.Text = "7";
					move = true;
					break;
				case (char)Keys.D8:
					pressedButton.Text = "8";
					move = true;
					break;
				case (char)Keys.D9:
					pressedButton.Text = "9";
					move = true;
					break;
			}

			if (move)
			{
				moves++;
			}

			if (!button2.Enabled)
			{
				button2.Enabled = true;
			}
			AddToHistory(codeKey);
			Check_Sudoku();
		}

		public void AddToHistory(int codeKey)
		{
			for (int i = 0; i < n * n; i++)
			{
				for (int j = 0; j < n * n; j++)
				{
					if (pressedButton == buttons[i, j])
					{
						history.Add(new int[] { i, j, codeKey });
					}
				}
			}
		}

		public void Check_Sudoku()
		{
			bool checkMap = true, checkEmpty = true;
			for (int i = 0; i < n * n; i++)
			{
				for (int j = 0; j < n * n; j++)
				{
					var btnText = buttons[i, j].Text;
					if (btnText != map[i, j].ToString() && !string.IsNullOrEmpty(btnText))
					{
						buttons[i, j].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
						buttons[i, j].FlatAppearance.BorderSize = 2;
						buttons[i, j].FlatAppearance.BorderColor = System.Drawing.Color.Red;
					}
					else
					{
						buttons[i, j].FlatStyle = System.Windows.Forms.FlatStyle.System;
					}
					if (btnText != map[i, j].ToString())
					{
						checkMap = false;
					}
					else if (string.IsNullOrEmpty(btnText))
					{
						checkEmpty = false;
					}
				}
			}
			if (checkMap && checkEmpty)
			{
				// Запускаем диалоговое окно выигрыша
				FormWin();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int[] tmp = history[history.Count - 1];

			if (history.Count == 1)
			{
				buttons[tmp[0], tmp[1]].Text = "";
			}
			else
			{
				int[] tmpPred = history[history.Count - 2];
				if (tmp[0] != tmpPred[0] || tmp[1] != tmpPred[1])
				{
					buttons[tmp[0], tmp[1]].Text = "";
				}
				else
				{
					buttons[tmp[0], tmp[1]].Text = char.ToString(Convert.ToChar(tmpPred[2]));
				}
			}

			history.RemoveAt(history.Count - 1);
			moves++;
			Check_Sudoku();

			if (history.Count == 0)
			{
				button2.Enabled = false;
			}
		}

		public void Blackout()
		{
			stopTimer = true;
			controls.Add(this, this.BackColor);
			foreach (Control control in this.Controls)
			{
				controls.Add(control, control.BackColor);
				control.BackColor = Color.LightGray;
			}
			this.BackColor = Color.LightGray;
		}

		public void Lightening()
		{
			foreach (var item in controls)
			{
				item.Key.BackColor = item.Value;
			}
			controls.Clear();
			stopTimer = false;
		}

		// Запуск окна выигрыша
		public void FormWin()
		{
			stopTimer = true;
			Form formWin = new FormWin();
			formWin.ShowDialog();
			stopTimer = false;
			NewGame();
			GenerateMap();
		}

		private void таблицаРекордовToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TableOfRecords();
		}

		public void TableOfRecords()
		{
			stopTimer = true;
			TableOfRecords tableOfRecords = new TableOfRecords();
			tableOfRecords.ShowDialog();
			tableOfRecords.Dispose();
			stopTimer = false;
			NewGame();
			GenerateMap();
		}

		private void сменитьИгрокаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PlayerName();
			GenerateMap();
		}

		public void NewGame()
		{
			for (int i = 0; i < n * n; i++)
			{
				for (int j = 0; j < n * n; j++)
				{
					Controls.Remove(buttons[i, j]);
				}
			}
		}

		public void PlayerName()
		{
			Form formPlayerName = new PlayerName();
			formPlayerName.ShowDialog();

			NewGame();

		}

        private void buttonHint_Click(object sender, EventArgs e)
        {
			Random random = new Random();
			var z = random.Next(1, 10);
			var k = 0;
			for (int i = 0; i < n * n; i++)
			{
				for (int j = 0; j < n * n; j++)
				{
					if (string.IsNullOrEmpty(buttons[i, j].Text))
					{
						k++;
					}
					if (k == z)
					{
						buttons[i, j].Text = map[i, j].ToString();
						break;
					}
				}
				if (k == z) break;
			}
		}

        private void количествоОшибокToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        public static int fontSize;
        public static int hideCells = 3;
        public bool notMakeMistake = false;
        public int N;
        public static string complexity = "Простая";
        public static string field = "9x9";
        public static int hints = 0;
        public static int possibleErrors = 3;
        public int errors = 0;
        static Button pressedButton;
        public static int n = 3;
        public static int sizeButton = 50;
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
            PlayerNameBegin();
            GenerateMap();
        }

        public void PlayerNameBegin()
        {
            Form formPlayerName = new PlayerName(true);
            formPlayerName.ShowDialog();
            labelPlayerName.Text = playerName;

            NewGame();
        }

        public void GenerateMap()
        {
            errors = 0;
            labelErrorsCount.Text = errors.ToString();

            date = DateTime.Now;
            history.Clear();

            if (ToolStripMenuItem9x9.Checked)
            {
                fontSize = 16;
                // 9x9 - 718; 540 (size окна) 500; 9 (Имя) 523; 38(Подсказка) 611; 38(назад) 528; 80(Время лейбл) 528; 121(таймер)
                // 528; 161 (ошибки лейбл) 528; 202 (ошибки) 528; 244(ходы лейбл) 528; 273(ходы)
                this.WindowState = FormWindowState.Normal;
                n = 3;
                if (простаяToolStripMenuItem.Checked) N = 40;
                else if (средняяToolStripMenuItem.Checked) N = 50;
                else if (сложнаяToolStripMenuItem.Checked) N = 59;
                hideCells = 3;
                this.Width = 718;
                this.Height = 540;
                sizeButton = 50;
                labelPlayerName.Location = new Point(500, 9);
                buttonHint.Location = new Point(523, 38);
                button2.Location = new Point(611, 38);
                labelTime.Location = new Point(528, 80);
                label1.Location = new Point(528, 121);
                labelErrors.Location = new Point(528, 161);
                labelErrorsCount.Location = new Point(528, 202);
                labelMoves.Location = new Point(528, 244);
                labelMovesCount.Location = new Point(528, 273);
                buttonNotes.Location = new Point(533, 305);
            }
            else if (ToolStripMenuItem16х16.Checked)
            {
                // 16x16 - 1000; 800 (size окна) 782; 9 (Имя) 805; 38(Подсказка) 893; 38(назад) 810; 80(Время лейбл) 810; 121(таймер)
                // 810; 161 (ошибки лейбл) 810; 202 (ошибки) 810; 244(ходы лейбл) 810; 273(ходы
                fontSize = 14;
                this.WindowState = FormWindowState.Normal;
                n = 4;
                hideCells = 7;
                if (простаяToolStripMenuItem.Checked) N = 126;
                else if (средняяToolStripMenuItem.Checked) N = 158;
                else if (сложнаяToolStripMenuItem.Checked) N = 186;
                this.Width = 1000;
                this.Height = 800;
                sizeButton = 45;
                labelPlayerName.Location = new Point(782, 9);
                buttonHint.Location = new Point(805, 38);
                button2.Location = new Point(893, 38);
                labelTime.Location = new Point(810, 80);
                label1.Location = new Point(810, 121);
                labelErrors.Location = new Point(810, 161);
                labelErrorsCount.Location = new Point(810, 202);
                labelMoves.Location = new Point(810, 244);
                labelMovesCount.Location = new Point(810, 273);
                buttonNotes.Location = new Point(810, 305);
            }
            else if (ToolStripMenuItem25х25.Checked)
            {
                fontSize = 12;
                n = 5;
                hideCells = 16;
                if (простаяToolStripMenuItem.Checked) N = 308;
                else if (средняяToolStripMenuItem.Checked) N = 385;
                else if (сложнаяToolStripMenuItem.Checked) N = 455;
                this.WindowState = FormWindowState.Maximized;
                sizeButton = 37;
                labelPlayerName.Location = new Point(982, 9);
                buttonHint.Location = new Point(1005, 38);
                button2.Location = new Point(1093, 38);
                labelTime.Location = new Point(1010, 80);
                label1.Location = new Point(1010, 121);
                labelErrors.Location = new Point(1010, 161);
                labelErrorsCount.Location = new Point(1010, 202);
                labelMoves.Location = new Point(1010, 244);
                labelMovesCount.Location = new Point(1010, 273);
                buttonNotes.Location = new Point(1010, 305);
            }

            map = new int[n * n, n * n];
            buttons = new Button[n * n, n * n];

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
            HideCells(N);

            TimerStart();
        }

        public void HideCells(int count)
        {
            Random random = new Random();

            while (count > 0)
            {
                for (int i = 0; i < n * n; i++)
                {
                    for (int j = 0; j < n * n; j++)
                    {
                        if (!string.IsNullOrEmpty(buttons[i, j].Text))
                        {
                            int a = random.Next(0, hideCells);
                            buttons[i, j].Text = a == 0 ? "" : buttons[i, j].Text;
                            buttons[i, j].Enabled = a == 0;

                            if (a == 0)
                                count--;
                            if (count <= 0)
                                break;
                        }
                    }

                    if (count <= 0)
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
                    button.Font = new Font("Yu Gothic", fontSize, FontStyle.Bold);
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

        public bool Right(string number)
        {
            bool check = false;

            for (int i = 0; i < n * n; i++)
                for (int j = 0; j < n * n; j++)
                    if (pressedButton == buttons[i, j] && int.Parse(number) == map[i, j])
                        check = true;

            return check;
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int codeKey = e.KeyValue;
            bool move = false;
            try
            {
                switch (codeKey)
                {
                    case (char)Keys.D1:
                        if (notMakeMistake)
                        {
                            if (Right("1"))
                            {
                                pressedButton.Text = "1";
                                move = true;
                            }
                        }
                        else
                        {
                            pressedButton.Text = "1";
                            move = true;
                        }
                        break;
                    case (char)Keys.D2:
                        if (notMakeMistake)
                        {
                            if (Right("2"))
                            {
                                pressedButton.Text = "2";
                                move = true;
                            }
                        }
                        else
                        {
                            pressedButton.Text = "2";
                            move = true;
                        }
                        break;
                    case (char)Keys.D3:
                        if (notMakeMistake)
                        {
                            if (Right("3"))
                            {
                                pressedButton.Text = "3";
                                move = true;
                            }
                        }
                        else
                        {
                            pressedButton.Text = "3";
                            move = true;
                        }
                        break;
                    case (char)Keys.D4:
                        if (notMakeMistake)
                        {
                            if (Right("4"))
                            {
                                pressedButton.Text = "4";
                                move = true;
                            }
                        }
                        else
                        {
                            pressedButton.Text = "4";
                            move = true;
                        }
                        break;
                    case (char)Keys.D5:
                        if (notMakeMistake)
                        {
                            if (Right("5"))
                            {
                                pressedButton.Text = "5";
                                move = true;
                            }
                        }
                        else
                        {
                            pressedButton.Text = "5";
                            move = true;
                        }
                        break;
                    case (char)Keys.D6:
                        if (notMakeMistake)
                        {
                            if (Right("6"))
                            {
                                pressedButton.Text = "6";
                                move = true;
                            }
                        }
                        else
                        {
                            pressedButton.Text = "6";
                            move = true;
                        }
                        break;
                    case (char)Keys.D7:
                        if (notMakeMistake)
                        {
                            if (Right("7"))
                            {
                                pressedButton.Text = "7";
                                move = true;
                            }
                        }
                        else
                        {
                            pressedButton.Text = "7";
                            move = true;
                        }
                        break;
                    case (char)Keys.D8:
                        if (notMakeMistake)
                        {
                            if (Right("8"))
                            {
                                pressedButton.Text = "8";
                                move = true;
                            }
                        }
                        else
                        {
                            pressedButton.Text = "8";
                            move = true;
                        }
                        break;
                    case (char)Keys.D9:
                        if (notMakeMistake)
                        {
                            if (Right("9"))
                            {
                                pressedButton.Text = "9";
                                move = true;
                            }
                        }
                        else
                        {
                            pressedButton.Text = "9";
                            move = true;
                        }
                        break;
                }
                if (move)
                {
                    moves++;
                    labelMovesCount.Text = moves.ToString();
                    if (!button2.Enabled)
                    {
                        button2.Enabled = true;
                    }
                    AddToHistory(codeKey);
                    Check_Sudoku();
                    CheckButton(pressedButton);
                }
            }
            catch (NullReferenceException)
            {

            }
        }

        public void CheckButton(Button button)
        {
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    if (pressedButton == buttons[i, j])
                    {
                        if (int.Parse(pressedButton.Text) != map[i, j])
                        {
                            errors++;
                            labelErrorsCount.Text = errors.ToString();
                        }
                    }
                }
            }
            if (errors == 3)
            {
                // Форма поражения
                formDefeat();
            }
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

        // Запуск окна поражения
        public void formDefeat()
        {
            stopTimer = true;
            Form formDefeat = new FormDefeat();
            formDefeat.ShowDialog();
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
            labelPlayerName.Text = playerName;

            NewGame();

        }

        private void buttonHint_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            var z = random.Next(1, 40);
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
            hints++;
            moves++;
            labelMovesCount.Text = moves.ToString();
        }

        public void ErrorsCount()
        {
            Form errorsCount = new ErrorsCount();
            errorsCount.ShowDialog();

            NewGame();
        }

        private void количествоОшибокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ErrorsCount();
            NewGame();
            GenerateMap();
        }

        private void недопуститьОшибкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notMakeMistake = true;
            стандартныйToolStripMenuItem.Checked = false;
            NewGame();
            GenerateMap();
        }

        private void стандартныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notMakeMistake = false;
            недопуститьОшибкиToolStripMenuItem.Checked = false;
            NewGame();
            GenerateMap();
        }

        private void простаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            N = 40;
            простаяToolStripMenuItem.Checked = true;
            средняяToolStripMenuItem.Checked = false;
            сложнаяToolStripMenuItem.Checked = false;
            NewGame();
            GenerateMap();
        }

        private void средняяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            N = 50;
            средняяToolStripMenuItem.Checked = true;
            простаяToolStripMenuItem.Checked = false;
            сложнаяToolStripMenuItem.Checked = false;
            NewGame();
            GenerateMap();
        }

        private void сложнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            N = 59;
            сложнаяToolStripMenuItem.Checked = true;
            простаяToolStripMenuItem.Checked = false;
            средняяToolStripMenuItem.Checked = false;
            NewGame();
            GenerateMap();
        }

        private void ToolStripMenuItem9x9_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem9x9.Checked = true;
            ToolStripMenuItem16х16.Checked = false;
            ToolStripMenuItem25х25.Checked = false;
            NewGame();
            n = 3;
            GenerateMap();
        }

        private void ToolStripMenuItem16х16_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem9x9.Checked = false;
            ToolStripMenuItem16х16.Checked = true;
            ToolStripMenuItem25х25.Checked = false;
            NewGame();
            n = 4;
            GenerateMap();
        }

        private void ToolStripMenuItem25х25_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem9x9.Checked = false;
            ToolStripMenuItem16х16.Checked = false;
            ToolStripMenuItem25х25.Checked = true;
            NewGame();
            n = 5;
            GenerateMap();
        }

        private void buttonNotes_Click(object sender, EventArgs e)
        {

        }
    
        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

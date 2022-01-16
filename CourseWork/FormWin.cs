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
        public FormWin()
        {
            InitializeComponent();
            GenerateFormWin();
        }

        public void GenerateFormWin()
        {
            labelMovesCount.Text = Convert.ToString(MainForm.moves);
            labelTimeCount.Text = MainForm.time;

        }

        // Нажатие на кнопку "Новая игра" в форме победы
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            SaveToTableOfRecords();
            Close();
        }

        public void SaveToTableOfRecords()
        {
            // Сохранение в таблицу лидеров
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

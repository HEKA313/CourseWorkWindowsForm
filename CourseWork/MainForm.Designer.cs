namespace CourseWork
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаРекордовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоОшибокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьИгрокаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.размерПоляToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem9x9 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem16х16 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem25х25 = new System.Windows.Forms.ToolStripMenuItem();
            this.сложностьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.простаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.средняяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.недопуститьОшибкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простойToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.среднийToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сложныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспертToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.среднийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерПоляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.х9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.х16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.х25ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.buttonHint = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelErrors = new System.Windows.Forms.Label();
            this.labelErrorsCount = new System.Windows.Forms.Label();
            this.labelMoves = new System.Windows.Forms.Label();
            this.labelMovesCount = new System.Windows.Forms.Label();
            this.buttonNotes = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem1,
            this.размерПоляToolStripMenuItem1,
            this.сложностьToolStripMenuItem1,
            this.режимToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 1;
            // 
            // менюToolStripMenuItem1
            // 
            this.менюToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.таблицаРекордовToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.сменитьИгрокаToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.менюToolStripMenuItem1.Name = "менюToolStripMenuItem1";
            this.менюToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem1.Text = "Меню";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // таблицаРекордовToolStripMenuItem
            // 
            this.таблицаРекордовToolStripMenuItem.Name = "таблицаРекордовToolStripMenuItem";
            this.таблицаРекордовToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.таблицаРекордовToolStripMenuItem.Text = "Таблица рекордов";
            this.таблицаРекордовToolStripMenuItem.Click += new System.EventHandler(this.таблицаРекордовToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.количествоОшибокToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // количествоОшибокToolStripMenuItem
            // 
            this.количествоОшибокToolStripMenuItem.Name = "количествоОшибокToolStripMenuItem";
            this.количествоОшибокToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.количествоОшибокToolStripMenuItem.Text = "Количество ошибок";
            this.количествоОшибокToolStripMenuItem.Click += new System.EventHandler(this.количествоОшибокToolStripMenuItem_Click);
            // 
            // сменитьИгрокаToolStripMenuItem
            // 
            this.сменитьИгрокаToolStripMenuItem.Name = "сменитьИгрокаToolStripMenuItem";
            this.сменитьИгрокаToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.сменитьИгрокаToolStripMenuItem.Text = "Сменить игрока";
            this.сменитьИгрокаToolStripMenuItem.Click += new System.EventHandler(this.сменитьИгрокаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // размерПоляToolStripMenuItem1
            // 
            this.размерПоляToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem9x9,
            this.ToolStripMenuItem16х16,
            this.ToolStripMenuItem25х25});
            this.размерПоляToolStripMenuItem1.Name = "размерПоляToolStripMenuItem1";
            this.размерПоляToolStripMenuItem1.Size = new System.Drawing.Size(89, 20);
            this.размерПоляToolStripMenuItem1.Text = "Размер поля";
            // 
            // ToolStripMenuItem9x9
            // 
            this.ToolStripMenuItem9x9.Checked = true;
            this.ToolStripMenuItem9x9.CheckOnClick = true;
            this.ToolStripMenuItem9x9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItem9x9.Name = "ToolStripMenuItem9x9";
            this.ToolStripMenuItem9x9.Size = new System.Drawing.Size(103, 22);
            this.ToolStripMenuItem9x9.Text = "9х9";
            this.ToolStripMenuItem9x9.Click += new System.EventHandler(this.ToolStripMenuItem9x9_Click);
            // 
            // ToolStripMenuItem16х16
            // 
            this.ToolStripMenuItem16х16.CheckOnClick = true;
            this.ToolStripMenuItem16х16.Name = "ToolStripMenuItem16х16";
            this.ToolStripMenuItem16х16.Size = new System.Drawing.Size(103, 22);
            this.ToolStripMenuItem16х16.Text = "16х16";
            this.ToolStripMenuItem16х16.Click += new System.EventHandler(this.ToolStripMenuItem16х16_Click);
            // 
            // ToolStripMenuItem25х25
            // 
            this.ToolStripMenuItem25х25.CheckOnClick = true;
            this.ToolStripMenuItem25х25.Name = "ToolStripMenuItem25х25";
            this.ToolStripMenuItem25х25.Size = new System.Drawing.Size(103, 22);
            this.ToolStripMenuItem25х25.Text = "25х25";
            this.ToolStripMenuItem25х25.Click += new System.EventHandler(this.ToolStripMenuItem25х25_Click);
            // 
            // сложностьToolStripMenuItem1
            // 
            this.сложностьToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.простаяToolStripMenuItem,
            this.средняяToolStripMenuItem,
            this.сложнаяToolStripMenuItem});
            this.сложностьToolStripMenuItem1.Name = "сложностьToolStripMenuItem1";
            this.сложностьToolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.сложностьToolStripMenuItem1.Text = "Сложность";
            // 
            // простаяToolStripMenuItem
            // 
            this.простаяToolStripMenuItem.Checked = true;
            this.простаяToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.простаяToolStripMenuItem.Name = "простаяToolStripMenuItem";
            this.простаяToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.простаяToolStripMenuItem.Text = "Простая";
            this.простаяToolStripMenuItem.Click += new System.EventHandler(this.простаяToolStripMenuItem_Click);
            // 
            // средняяToolStripMenuItem
            // 
            this.средняяToolStripMenuItem.Name = "средняяToolStripMenuItem";
            this.средняяToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.средняяToolStripMenuItem.Text = "Средняя";
            this.средняяToolStripMenuItem.Click += new System.EventHandler(this.средняяToolStripMenuItem_Click);
            // 
            // сложнаяToolStripMenuItem
            // 
            this.сложнаяToolStripMenuItem.Name = "сложнаяToolStripMenuItem";
            this.сложнаяToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.сложнаяToolStripMenuItem.Text = "Сложная";
            this.сложнаяToolStripMenuItem.Click += new System.EventHandler(this.сложнаяToolStripMenuItem_Click);
            // 
            // режимToolStripMenuItem1
            // 
            this.режимToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартныйToolStripMenuItem,
            this.недопуститьОшибкиToolStripMenuItem});
            this.режимToolStripMenuItem1.Name = "режимToolStripMenuItem1";
            this.режимToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.режимToolStripMenuItem1.Text = "Режим";
            // 
            // стандартныйToolStripMenuItem
            // 
            this.стандартныйToolStripMenuItem.Checked = true;
            this.стандартныйToolStripMenuItem.CheckOnClick = true;
            this.стандартныйToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.стандартныйToolStripMenuItem.Name = "стандартныйToolStripMenuItem";
            this.стандартныйToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.стандартныйToolStripMenuItem.Text = "Стандартный";
            this.стандартныйToolStripMenuItem.Click += new System.EventHandler(this.стандартныйToolStripMenuItem_Click);
            // 
            // недопуститьОшибкиToolStripMenuItem
            // 
            this.недопуститьОшибкиToolStripMenuItem.CheckOnClick = true;
            this.недопуститьОшибкиToolStripMenuItem.Name = "недопуститьОшибкиToolStripMenuItem";
            this.недопуститьОшибкиToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.недопуститьОшибкиToolStripMenuItem.Text = "Не допустить ошибки";
            this.недопуститьОшибкиToolStripMenuItem.Click += new System.EventHandler(this.недопуститьОшибкиToolStripMenuItem_Click);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // сложностьToolStripMenuItem
            // 
            this.сложностьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.простойToolStripMenuItem1,
            this.среднийToolStripMenuItem1,
            this.сложныйToolStripMenuItem,
            this.экспертToolStripMenuItem});
            this.сложностьToolStripMenuItem.Name = "сложностьToolStripMenuItem";
            this.сложностьToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.сложностьToolStripMenuItem.Text = "Сложность";
            // 
            // простойToolStripMenuItem1
            // 
            this.простойToolStripMenuItem1.CheckOnClick = true;
            this.простойToolStripMenuItem1.Name = "простойToolStripMenuItem1";
            this.простойToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.простойToolStripMenuItem1.Text = "Простой";
            // 
            // среднийToolStripMenuItem1
            // 
            this.среднийToolStripMenuItem1.CheckOnClick = true;
            this.среднийToolStripMenuItem1.Name = "среднийToolStripMenuItem1";
            this.среднийToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.среднийToolStripMenuItem1.Text = "Средний";
            // 
            // сложныйToolStripMenuItem
            // 
            this.сложныйToolStripMenuItem.CheckOnClick = true;
            this.сложныйToolStripMenuItem.Name = "сложныйToolStripMenuItem";
            this.сложныйToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.сложныйToolStripMenuItem.Text = "Сложный";
            // 
            // экспертToolStripMenuItem
            // 
            this.экспертToolStripMenuItem.CheckOnClick = true;
            this.экспертToolStripMenuItem.Name = "экспертToolStripMenuItem";
            this.экспертToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.экспертToolStripMenuItem.Text = "Эксперт";
            // 
            // режимToolStripMenuItem
            // 
            this.режимToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.простойToolStripMenuItem,
            this.среднийToolStripMenuItem});
            this.режимToolStripMenuItem.Name = "режимToolStripMenuItem";
            this.режимToolStripMenuItem.Size = new System.Drawing.Size(70, 26);
            this.режимToolStripMenuItem.Text = "Режим";
            // 
            // простойToolStripMenuItem
            // 
            this.простойToolStripMenuItem.CheckOnClick = true;
            this.простойToolStripMenuItem.Name = "простойToolStripMenuItem";
            this.простойToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.простойToolStripMenuItem.Text = "Стандартный";
            // 
            // среднийToolStripMenuItem
            // 
            this.среднийToolStripMenuItem.CheckOnClick = true;
            this.среднийToolStripMenuItem.Name = "среднийToolStripMenuItem";
            this.среднийToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.среднийToolStripMenuItem.Text = "Предотвращение ошибок";
            // 
            // размерПоляToolStripMenuItem
            // 
            this.размерПоляToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.х9ToolStripMenuItem,
            this.х16ToolStripMenuItem,
            this.х25ToolStripMenuItem});
            this.размерПоляToolStripMenuItem.Name = "размерПоляToolStripMenuItem";
            this.размерПоляToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.размерПоляToolStripMenuItem.Text = "Размер поля";
            // 
            // х9ToolStripMenuItem
            // 
            this.х9ToolStripMenuItem.CheckOnClick = true;
            this.х9ToolStripMenuItem.Name = "х9ToolStripMenuItem";
            this.х9ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.х9ToolStripMenuItem.Text = "9х9";
            // 
            // х16ToolStripMenuItem
            // 
            this.х16ToolStripMenuItem.CheckOnClick = true;
            this.х16ToolStripMenuItem.Name = "х16ToolStripMenuItem";
            this.х16ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.х16ToolStripMenuItem.Text = "16х16";
            // 
            // х25ToolStripMenuItem
            // 
            this.х25ToolStripMenuItem.CheckOnClick = true;
            this.х25ToolStripMenuItem.Name = "х25ToolStripMenuItem";
            this.х25ToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.х25ToolStripMenuItem.Text = "25х25";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(611, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(528, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerName.Location = new System.Drawing.Point(500, 9);
            this.labelPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(77, 29);
            this.labelPlayerName.TabIndex = 6;
            this.labelPlayerName.Text = "label2";
            this.labelPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonHint
            // 
            this.buttonHint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonHint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHint.Location = new System.Drawing.Point(523, 38);
            this.buttonHint.Name = "buttonHint";
            this.buttonHint.Size = new System.Drawing.Size(82, 30);
            this.buttonHint.TabIndex = 7;
            this.buttonHint.Text = "Подсказка";
            this.buttonHint.UseVisualStyleBackColor = true;
            this.buttonHint.Click += new System.EventHandler(this.buttonHint_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelTime.Location = new System.Drawing.Point(528, 80);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(123, 29);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "Время";
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelErrors.Location = new System.Drawing.Point(528, 161);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(145, 29);
            this.labelErrors.TabIndex = 9;
            this.labelErrors.Text = "Ошибки";
            // 
            // labelErrorsCount
            // 
            this.labelErrorsCount.AutoSize = true;
            this.labelErrorsCount.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelErrorsCount.Location = new System.Drawing.Point(528, 202);
            this.labelErrorsCount.Name = "labelErrorsCount";
            this.labelErrorsCount.Size = new System.Drawing.Size(77, 29);
            this.labelErrorsCount.TabIndex = 10;
            this.labelErrorsCount.Text = "label3";
            // 
            // labelMoves
            // 
            this.labelMoves.AutoSize = true;
            this.labelMoves.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelMoves.Location = new System.Drawing.Point(528, 244);
            this.labelMoves.Name = "labelMoves";
            this.labelMoves.Size = new System.Drawing.Size(101, 29);
            this.labelMoves.TabIndex = 11;
            this.labelMoves.Text = "Ходы";
            // 
            // labelMovesCount
            // 
            this.labelMovesCount.AutoSize = true;
            this.labelMovesCount.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelMovesCount.Location = new System.Drawing.Point(528, 273);
            this.labelMovesCount.Name = "labelMovesCount";
            this.labelMovesCount.Size = new System.Drawing.Size(77, 29);
            this.labelMovesCount.TabIndex = 12;
            this.labelMovesCount.Text = "label3";
            // 
            // buttonNotes
            // 
            this.buttonNotes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNotes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonNotes.Location = new System.Drawing.Point(533, 305);
            this.buttonNotes.Name = "buttonNotes";
            this.buttonNotes.Size = new System.Drawing.Size(82, 30);
            this.buttonNotes.TabIndex = 13;
            this.buttonNotes.Text = "Заметки";
            this.buttonNotes.UseVisualStyleBackColor = true;
            this.buttonNotes.Click += new System.EventHandler(this.buttonNotes_Click);
            // 
            // MainForm
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(702, 501);
            this.Controls.Add(this.buttonNotes);
            this.Controls.Add(this.labelMovesCount);
            this.Controls.Add(this.labelMoves);
            this.Controls.Add(this.labelErrorsCount);
            this.Controls.Add(this.labelErrors);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonHint);
            this.Controls.Add(this.labelPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem простойToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem среднийToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сложныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспертToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem простойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem среднийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерПоляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem х9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem х16ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem х25ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаРекордовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоОшибокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem режимToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem стандартныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem недопуститьОшибкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерПоляToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem9x9;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem16х16;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem25х25;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem сменитьИгрокаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложностьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem простаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem средняяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложнаяToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.Button buttonHint;
        public System.Windows.Forms.Label labelTime;
        public System.Windows.Forms.Label labelErrors;
        public System.Windows.Forms.Label labelErrorsCount;
        public System.Windows.Forms.Label labelMoves;
        public System.Windows.Forms.Label labelMovesCount;
        private System.Windows.Forms.Button buttonNotes;
    }
}


namespace CourseWork
{
    partial class FormWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWin = new System.Windows.Forms.Label();
            this.labelMoves = new System.Windows.Forms.Label();
            this.labelMovesCount = new System.Windows.Forms.Label();
            this.labelTimeCount = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelHints = new System.Windows.Forms.Label();
            this.labelHintsCount = new System.Windows.Forms.Label();
            this.labelBestTime = new System.Windows.Forms.Label();
            this.labelBestTimeCount = new System.Windows.Forms.Label();
            this.buttonBestTime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWin.Location = new System.Drawing.Point(38, 15);
            this.labelWin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(263, 29);
            this.labelWin.TabIndex = 0;
            this.labelWin.Text = "Поздравляем!";
            // 
            // labelMoves
            // 
            this.labelMoves.AutoSize = true;
            this.labelMoves.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoves.Location = new System.Drawing.Point(9, 76);
            this.labelMoves.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoves.Name = "labelMoves";
            this.labelMoves.Size = new System.Drawing.Size(60, 26);
            this.labelMoves.TabIndex = 1;
            this.labelMoves.Text = "Ходы";
            // 
            // labelMovesCount
            // 
            this.labelMovesCount.AutoSize = true;
            this.labelMovesCount.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMovesCount.Location = new System.Drawing.Point(248, 76);
            this.labelMovesCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMovesCount.Name = "labelMovesCount";
            this.labelMovesCount.Size = new System.Drawing.Size(61, 26);
            this.labelMovesCount.TabIndex = 2;
            this.labelMovesCount.Text = "label1";
            this.labelMovesCount.Click += new System.EventHandler(this.labelMovesCount_Click);
            // 
            // labelTimeCount
            // 
            this.labelTimeCount.AutoSize = true;
            this.labelTimeCount.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeCount.Location = new System.Drawing.Point(248, 111);
            this.labelTimeCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeCount.Name = "labelTimeCount";
            this.labelTimeCount.Size = new System.Drawing.Size(61, 26);
            this.labelTimeCount.TabIndex = 3;
            this.labelTimeCount.Text = "label1";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(9, 111);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(68, 26);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Время";
            // 
            // labelHints
            // 
            this.labelHints.AutoSize = true;
            this.labelHints.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHints.Location = new System.Drawing.Point(9, 164);
            this.labelHints.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHints.Name = "labelHints";
            this.labelHints.Size = new System.Drawing.Size(107, 26);
            this.labelHints.TabIndex = 5;
            this.labelHints.Text = "Подсказки";
            // 
            // labelHintsCount
            // 
            this.labelHintsCount.AutoSize = true;
            this.labelHintsCount.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHintsCount.Location = new System.Drawing.Point(248, 164);
            this.labelHintsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHintsCount.Name = "labelHintsCount";
            this.labelHintsCount.Size = new System.Drawing.Size(61, 26);
            this.labelHintsCount.TabIndex = 6;
            this.labelHintsCount.Text = "label1";
            // 
            // labelBestTime
            // 
            this.labelBestTime.AutoSize = true;
            this.labelBestTime.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBestTime.Location = new System.Drawing.Point(9, 219);
            this.labelBestTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBestTime.Name = "labelBestTime";
            this.labelBestTime.Size = new System.Drawing.Size(139, 26);
            this.labelBestTime.TabIndex = 7;
            this.labelBestTime.Text = "Лучшее время";
            // 
            // labelBestTimeCount
            // 
            this.labelBestTimeCount.AutoSize = true;
            this.labelBestTimeCount.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBestTimeCount.Location = new System.Drawing.Point(248, 219);
            this.labelBestTimeCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBestTimeCount.Name = "labelBestTimeCount";
            this.labelBestTimeCount.Size = new System.Drawing.Size(61, 26);
            this.labelBestTimeCount.TabIndex = 8;
            this.labelBestTimeCount.Text = "label1";
            // 
            // buttonBestTime
            // 
            this.buttonBestTime.Location = new System.Drawing.Point(302, 219);
            this.buttonBestTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBestTime.Name = "buttonBestTime";
            this.buttonBestTime.Size = new System.Drawing.Size(21, 25);
            this.buttonBestTime.TabIndex = 9;
            this.buttonBestTime.UseVisualStyleBackColor = true;
            this.buttonBestTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonBestTime_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Вы сыграли лучше 99% игроков";
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewGame.Location = new System.Drawing.Point(99, 353);
            this.buttonNewGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(142, 51);
            this.buttonNewGame.TabIndex = 11;
            this.buttonNewGame.Text = "Новая игра";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // FormWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 423);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBestTime);
            this.Controls.Add(this.labelBestTimeCount);
            this.Controls.Add(this.labelBestTime);
            this.Controls.Add(this.labelHintsCount);
            this.Controls.Add(this.labelHints);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTimeCount);
            this.Controls.Add(this.labelMovesCount);
            this.Controls.Add(this.labelMoves);
            this.Controls.Add(this.labelWin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormWin";
            this.Text = "TableOfRecords";
            this.Load += new System.EventHandler(this.FormWin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Label labelMoves;
        private System.Windows.Forms.Label labelMovesCount;
        private System.Windows.Forms.Label labelTimeCount;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelHints;
        private System.Windows.Forms.Label labelHintsCount;
        private System.Windows.Forms.Label labelBestTime;
        private System.Windows.Forms.Label labelBestTimeCount;
        private System.Windows.Forms.Button buttonBestTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNewGame;
    }
}
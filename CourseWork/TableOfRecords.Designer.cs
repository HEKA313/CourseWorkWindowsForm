namespace CourseWork
{
    partial class TableOfRecords
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultyGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovesCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HintsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.DifficultyGame,
            this.Time,
            this.MovesCount,
            this.HintsCount});
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(679, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.Frozen = true;
            this.Name.HeaderText = "Имя";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 125;
            // 
            // DifficultyGame
            // 
            this.DifficultyGame.Frozen = true;
            this.DifficultyGame.HeaderText = "Сложность игры";
            this.DifficultyGame.MinimumWidth = 6;
            this.DifficultyGame.Name = "DifficultyGame";
            this.DifficultyGame.ReadOnly = true;
            this.DifficultyGame.Width = 125;
            // 
            // Time
            // 
            this.Time.Frozen = true;
            this.Time.HeaderText = "Время";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 125;
            // 
            // MovesCount
            // 
            this.MovesCount.Frozen = true;
            this.MovesCount.HeaderText = "Количество ходов";
            this.MovesCount.MinimumWidth = 6;
            this.MovesCount.Name = "MovesCount";
            this.MovesCount.ReadOnly = true;
            this.MovesCount.Width = 125;
            // 
            // HintsCount
            // 
            this.HintsCount.Frozen = true;
            this.HintsCount.HeaderText = "Количество подсказок";
            this.HintsCount.MinimumWidth = 6;
            this.HintsCount.Name = "HintsCount";
            this.HintsCount.ReadOnly = true;
            this.HintsCount.Width = 125;
            // 
            // TableOfRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 365);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TableOfRecords";
            this.Text = "TableOfRecords";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private new System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultyGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovesCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn HintsCount;
    }
}
namespace CourseWork
{
    partial class PlayerName
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
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.InputPlayerName = new System.Windows.Forms.TextBox();
            this.buttonPlayerNameCancel = new System.Windows.Forms.Button();
            this.buttonPlayerNameOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerName.Location = new System.Drawing.Point(9, 7);
            this.labelPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(117, 26);
            this.labelPlayerName.TabIndex = 4;
            this.labelPlayerName.Text = "Имя игрока";
            // 
            // InputPlayerName
            // 
            this.InputPlayerName.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputPlayerName.Location = new System.Drawing.Point(14, 35);
            this.InputPlayerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputPlayerName.Name = "InputPlayerName";
            this.InputPlayerName.Size = new System.Drawing.Size(282, 32);
            this.InputPlayerName.TabIndex = 13;
            // 
            // buttonPlayerNameCancel
            // 
            this.buttonPlayerNameCancel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlayerNameCancel.Location = new System.Drawing.Point(107, 118);
            this.buttonPlayerNameCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPlayerNameCancel.Name = "buttonPlayerNameCancel";
            this.buttonPlayerNameCancel.Size = new System.Drawing.Size(93, 41);
            this.buttonPlayerNameCancel.TabIndex = 14;
            this.buttonPlayerNameCancel.Text = "Отмена";
            this.buttonPlayerNameCancel.UseVisualStyleBackColor = true;
            // 
            // buttonPlayerNameOK
            // 
            this.buttonPlayerNameOK.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlayerNameOK.Location = new System.Drawing.Point(206, 118);
            this.buttonPlayerNameOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPlayerNameOK.Name = "buttonPlayerNameOK";
            this.buttonPlayerNameOK.Size = new System.Drawing.Size(88, 41);
            this.buttonPlayerNameOK.TabIndex = 0;
            this.buttonPlayerNameOK.Text = "ОК";
            this.buttonPlayerNameOK.UseVisualStyleBackColor = true;
            this.buttonPlayerNameOK.Click += new System.EventHandler(this.buttonPlayerNameOK_Click);
            // 
            // PlayerName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 169);
            this.Controls.Add(this.buttonPlayerNameOK);
            this.Controls.Add(this.buttonPlayerNameCancel);
            this.Controls.Add(this.InputPlayerName);
            this.Controls.Add(this.labelPlayerName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlayerName";
            this.Text = "PlayerName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.TextBox InputPlayerName;
        private System.Windows.Forms.Button buttonPlayerNameCancel;
        private System.Windows.Forms.Button buttonPlayerNameOK;
    }
}
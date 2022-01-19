namespace CourseWork
{
    partial class ErrorsCount
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
            this.errorSelection = new System.Windows.Forms.NumericUpDown();
            this.labelErrorsCount = new System.Windows.Forms.Label();
            this.buttonErrorsOK = new System.Windows.Forms.Button();
            this.buttonErrorsCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // errorSelection
            // 
            this.errorSelection.Font = new System.Drawing.Font("Palatino Linotype", 13.8F);
            this.errorSelection.Location = new System.Drawing.Point(12, 38);
            this.errorSelection.Name = "errorSelection";
            this.errorSelection.Size = new System.Drawing.Size(49, 32);
            this.errorSelection.TabIndex = 0;
            // 
            // labelErrorsCount
            // 
            this.labelErrorsCount.AutoSize = true;
            this.labelErrorsCount.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorsCount.Location = new System.Drawing.Point(7, 9);
            this.labelErrorsCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErrorsCount.Name = "labelErrorsCount";
            this.labelErrorsCount.Size = new System.Drawing.Size(279, 26);
            this.labelErrorsCount.TabIndex = 2;
            this.labelErrorsCount.Text = "Выберите количество ошибок";
            // 
            // buttonErrorsOK
            // 
            this.buttonErrorsOK.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonErrorsOK.Location = new System.Drawing.Point(193, 98);
            this.buttonErrorsOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonErrorsOK.Name = "buttonErrorsOK";
            this.buttonErrorsOK.Size = new System.Drawing.Size(88, 41);
            this.buttonErrorsOK.TabIndex = 15;
            this.buttonErrorsOK.Text = "ОК";
            this.buttonErrorsOK.UseVisualStyleBackColor = true;
            this.buttonErrorsOK.Click += new System.EventHandler(this.buttonErrorsOK_Click);
            // 
            // buttonErrorsCancel
            // 
            this.buttonErrorsCancel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonErrorsCancel.Location = new System.Drawing.Point(94, 98);
            this.buttonErrorsCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonErrorsCancel.Name = "buttonErrorsCancel";
            this.buttonErrorsCancel.Size = new System.Drawing.Size(93, 41);
            this.buttonErrorsCancel.TabIndex = 16;
            this.buttonErrorsCancel.Text = "Отмена";
            this.buttonErrorsCancel.UseVisualStyleBackColor = true;
            this.buttonErrorsCancel.Click += new System.EventHandler(this.buttonErrorsCancel_Click);
            // 
            // ErrorsCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 150);
            this.Controls.Add(this.buttonErrorsOK);
            this.Controls.Add(this.buttonErrorsCancel);
            this.Controls.Add(this.labelErrorsCount);
            this.Controls.Add(this.errorSelection);
            this.Name = "ErrorsCount";
            this.Text = "ErrorsCount";
            ((System.ComponentModel.ISupportInitialize)(this.errorSelection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown errorSelection;
        private System.Windows.Forms.Label labelErrorsCount;
        private System.Windows.Forms.Button buttonErrorsOK;
        private System.Windows.Forms.Button buttonErrorsCancel;
    }
}
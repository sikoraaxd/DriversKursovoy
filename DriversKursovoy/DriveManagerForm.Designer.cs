
namespace DriversKursovoy
{
    partial class DriveManagerForm
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
            this.HelloLabel = new System.Windows.Forms.Label();
            this.Autopark = new System.Windows.Forms.Button();
            this.DriversSchedule = new System.Windows.Forms.Button();
            this.SignOut = new System.Windows.Forms.Button();
            this.PathNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HelloLabel.Location = new System.Drawing.Point(12, 11);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(289, 24);
            this.HelloLabel.TabIndex = 2;
            this.HelloLabel.Text = "Добро пожаловать, user_name!";
            // 
            // Autopark
            // 
            this.Autopark.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Autopark.Location = new System.Drawing.Point(12, 61);
            this.Autopark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Autopark.Name = "Autopark";
            this.Autopark.Size = new System.Drawing.Size(384, 58);
            this.Autopark.TabIndex = 3;
            this.Autopark.Text = "Автопарк";
            this.Autopark.UseVisualStyleBackColor = true;
            this.Autopark.Click += new System.EventHandler(this.Autopark_Click);
            // 
            // DriversSchedule
            // 
            this.DriversSchedule.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DriversSchedule.Location = new System.Drawing.Point(12, 127);
            this.DriversSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DriversSchedule.Name = "DriversSchedule";
            this.DriversSchedule.Size = new System.Drawing.Size(384, 58);
            this.DriversSchedule.TabIndex = 4;
            this.DriversSchedule.Text = "Расписание водителей";
            this.DriversSchedule.UseVisualStyleBackColor = true;
            this.DriversSchedule.Click += new System.EventHandler(this.DriversSchedule_Click);
            // 
            // SignOut
            // 
            this.SignOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignOut.Location = new System.Drawing.Point(12, 259);
            this.SignOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(384, 58);
            this.SignOut.TabIndex = 5;
            this.SignOut.Text = "Выход";
            this.SignOut.UseVisualStyleBackColor = true;
            // 
            // PathNumbers
            // 
            this.PathNumbers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathNumbers.Location = new System.Drawing.Point(12, 193);
            this.PathNumbers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PathNumbers.Name = "PathNumbers";
            this.PathNumbers.Size = new System.Drawing.Size(384, 58);
            this.PathNumbers.TabIndex = 6;
            this.PathNumbers.Text = "Маршрутные пути";
            this.PathNumbers.UseVisualStyleBackColor = true;
            this.PathNumbers.Click += new System.EventHandler(this.PathNumbers_Click);
            // 
            // DriveManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 336);
            this.Controls.Add(this.PathNumbers);
            this.Controls.Add(this.SignOut);
            this.Controls.Add(this.DriversSchedule);
            this.Controls.Add(this.Autopark);
            this.Controls.Add(this.HelloLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DriveManagerForm";
            this.Text = "Менеджер водителей";
            this.Load += new System.EventHandler(this.DriveManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button Autopark;
        private System.Windows.Forms.Button DriversSchedule;
        private System.Windows.Forms.Button SignOut;
        private Button PathNumbers;
    }
}
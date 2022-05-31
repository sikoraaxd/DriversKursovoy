
namespace DriversKursovoy
{
    partial class DriverForm
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
            this.components = new System.ComponentModel.Container();
            this.HelloLabel = new System.Windows.Forms.Label();
            this.SignOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Schedule = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.NextDrive = new System.Windows.Forms.TextBox();
            this.AutoNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HelloLabel.Location = new System.Drawing.Point(12, 24);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(289, 24);
            this.HelloLabel.TabIndex = 1;
            this.HelloLabel.Text = "Добро пожаловать, user_name!";
            // 
            // SignOut
            // 
            this.SignOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignOut.Location = new System.Drawing.Point(696, 16);
            this.SignOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(123, 45);
            this.SignOut.TabIndex = 21;
            this.SignOut.Text = "Выйти";
            this.SignOut.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ваше расписание:";
            // 
            // Schedule
            // 
            this.Schedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.Schedule.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Schedule.Location = new System.Drawing.Point(12, 128);
            this.Schedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(806, 465);
            this.Schedule.TabIndex = 23;
            this.Schedule.UseCompatibleStateImageBehavior = false;
            this.Schedule.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Понедельник";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Вторник";
            this.columnHeader2.Width = 115;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Среда";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Четверг";
            this.columnHeader4.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Пятница";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Суббота";
            this.columnHeader6.Width = 115;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Воскресенье";
            this.columnHeader7.Width = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ближайший выезд:";
            // 
            // NextDrive
            // 
            this.NextDrive.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextDrive.Location = new System.Drawing.Point(194, 606);
            this.NextDrive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NextDrive.Name = "NextDrive";
            this.NextDrive.ReadOnly = true;
            this.NextDrive.Size = new System.Drawing.Size(121, 36);
            this.NextDrive.TabIndex = 25;
            // 
            // AutoNumber
            // 
            this.AutoNumber.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutoNumber.Location = new System.Drawing.Point(696, 606);
            this.AutoNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AutoNumber.Name = "AutoNumber";
            this.AutoNumber.ReadOnly = true;
            this.AutoNumber.Size = new System.Drawing.Size(121, 36);
            this.AutoNumber.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(507, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Номер автомобиля:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 679);
            this.Controls.Add(this.AutoNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NextDrive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Schedule);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignOut);
            this.Controls.Add(this.HelloLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DriverForm";
            this.Text = "Водитель";
            this.Load += new System.EventHandler(this.DriverForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Button SignOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView Schedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NextDrive;
        private System.Windows.Forms.TextBox AutoNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Timer timer1;
    }
}
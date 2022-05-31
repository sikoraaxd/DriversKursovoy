
namespace DriversKursovoy
{
    partial class DriversScheduleForm
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
            this.Schedule = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DriverBox = new System.Windows.Forms.ComboBox();
            this.DayOfWeekBox = new System.Windows.Forms.ComboBox();
            this.TimeBox = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.carNumBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.Schedule.Location = new System.Drawing.Point(12, 160);
            this.Schedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(806, 453);
            this.Schedule.TabIndex = 24;
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
            this.label1.Location = new System.Drawing.Point(54, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Водитель:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "День недели:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Время выезда:";
            // 
            // DriverBox
            // 
            this.DriverBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DriverBox.FormattingEnabled = true;
            this.DriverBox.Location = new System.Drawing.Point(155, 23);
            this.DriverBox.Name = "DriverBox";
            this.DriverBox.Size = new System.Drawing.Size(307, 32);
            this.DriverBox.TabIndex = 28;
            this.DriverBox.SelectedIndexChanged += new System.EventHandler(this.DriverBox_SelectedIndexChanged);
            // 
            // DayOfWeekBox
            // 
            this.DayOfWeekBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DayOfWeekBox.FormattingEnabled = true;
            this.DayOfWeekBox.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"});
            this.DayOfWeekBox.Location = new System.Drawing.Point(155, 65);
            this.DayOfWeekBox.Name = "DayOfWeekBox";
            this.DayOfWeekBox.Size = new System.Drawing.Size(307, 32);
            this.DayOfWeekBox.TabIndex = 29;
            // 
            // TimeBox
            // 
            this.TimeBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeBox.FormattingEnabled = true;
            this.TimeBox.Items.AddRange(new object[] {
            "6:30",
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00"});
            this.TimeBox.Location = new System.Drawing.Point(155, 106);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(307, 32);
            this.TimeBox.TabIndex = 30;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add.Location = new System.Drawing.Point(478, 106);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(154, 32);
            this.Add.TabIndex = 31;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Delete.Location = new System.Drawing.Point(663, 106);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(155, 32);
            this.Delete.TabIndex = 32;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // carNumBox
            // 
            this.carNumBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carNumBox.FormattingEnabled = true;
            this.carNumBox.Location = new System.Drawing.Point(606, 23);
            this.carNumBox.Name = "carNumBox";
            this.carNumBox.Size = new System.Drawing.Size(212, 32);
            this.carNumBox.TabIndex = 34;
            this.carNumBox.SelectedIndexChanged += new System.EventHandler(this.carNumBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(478, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Автомобиль:";
            // 
            // DriversScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 623);
            this.Controls.Add(this.carNumBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.TimeBox);
            this.Controls.Add(this.DayOfWeekBox);
            this.Controls.Add(this.DriverBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Schedule);
            this.Name = "DriversScheduleForm";
            this.Text = "Расписание водителей";
            this.Load += new System.EventHandler(this.DriversScheduleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView Schedule;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox DriverBox;
        private ComboBox DayOfWeekBox;
        private ComboBox TimeBox;
        private Button Add;
        private Button Delete;
        private ComboBox carNumBox;
        private Label label4;
    }
}
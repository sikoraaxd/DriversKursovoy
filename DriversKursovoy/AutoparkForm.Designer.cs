
namespace DriversKursovoy
{
    partial class AutoparkForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.SortByWayNum = new System.Windows.Forms.Button();
            this.SortByName = new System.Windows.Forms.Button();
            this.DeleteCar = new System.Windows.Forms.Button();
            this.ChangeCar = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AutoNameInput = new System.Windows.Forms.TextBox();
            this.AutoNumInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoList = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.WayNumInput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(234, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 24);
            this.label9.TabIndex = 37;
            this.label9.Text = "Информация";
            // 
            // SortByWayNum
            // 
            this.SortByWayNum.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortByWayNum.Location = new System.Drawing.Point(771, 555);
            this.SortByWayNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortByWayNum.Name = "SortByWayNum";
            this.SortByWayNum.Size = new System.Drawing.Size(209, 45);
            this.SortByWayNum.TabIndex = 36;
            this.SortByWayNum.Text = "По номеру маршрута";
            this.SortByWayNum.UseVisualStyleBackColor = true;
            // 
            // SortByName
            // 
            this.SortByName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortByName.Location = new System.Drawing.Point(771, 486);
            this.SortByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortByName.Name = "SortByName";
            this.SortByName.Size = new System.Drawing.Size(209, 45);
            this.SortByName.TabIndex = 35;
            this.SortByName.Text = "По марке";
            this.SortByName.UseVisualStyleBackColor = true;
            // 
            // DeleteCar
            // 
            this.DeleteCar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteCar.Location = new System.Drawing.Point(538, 626);
            this.DeleteCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteCar.Name = "DeleteCar";
            this.DeleteCar.Size = new System.Drawing.Size(209, 45);
            this.DeleteCar.TabIndex = 34;
            this.DeleteCar.Text = "Удалить";
            this.DeleteCar.UseVisualStyleBackColor = true;
            this.DeleteCar.Click += new System.EventHandler(this.DeleteCar_Click);
            // 
            // ChangeCar
            // 
            this.ChangeCar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeCar.Location = new System.Drawing.Point(538, 555);
            this.ChangeCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeCar.Name = "ChangeCar";
            this.ChangeCar.Size = new System.Drawing.Size(209, 45);
            this.ChangeCar.TabIndex = 33;
            this.ChangeCar.Text = "Изменить";
            this.ChangeCar.UseVisualStyleBackColor = true;
            this.ChangeCar.Click += new System.EventHandler(this.ChangeCar_Click);
            // 
            // AddUser
            // 
            this.AddUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddUser.Location = new System.Drawing.Point(538, 486);
            this.AddUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(209, 45);
            this.AddUser.TabIndex = 32;
            this.AddUser.Text = "Добавить";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(814, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "Сортировка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(569, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Редактирование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(32, 634);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Марка, модель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 562);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Номер маршрута:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Номер машины:";
            // 
            // AutoNameInput
            // 
            this.AutoNameInput.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutoNameInput.Location = new System.Drawing.Point(184, 626);
            this.AutoNameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AutoNameInput.Name = "AutoNameInput";
            this.AutoNameInput.Size = new System.Drawing.Size(302, 36);
            this.AutoNameInput.TabIndex = 24;
            // 
            // AutoNumInput
            // 
            this.AutoNumInput.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutoNumInput.Location = new System.Drawing.Point(184, 486);
            this.AutoNumInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AutoNumInput.Name = "AutoNumInput";
            this.AutoNumInput.Size = new System.Drawing.Size(302, 36);
            this.AutoNumInput.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Машины";
            // 
            // AutoList
            // 
            this.AutoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.AutoList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutoList.Location = new System.Drawing.Point(12, 62);
            this.AutoList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AutoList.Name = "AutoList";
            this.AutoList.Size = new System.Drawing.Size(968, 349);
            this.AutoList.TabIndex = 20;
            this.AutoList.UseCompatibleStateImageBehavior = false;
            this.AutoList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Модель";
            this.columnHeader2.Width = 479;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Номер машины";
            this.columnHeader3.Width = 242;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Номер маршрута";
            this.columnHeader4.Width = 242;
            // 
            // WayNumInput
            // 
            this.WayNumInput.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WayNumInput.FormattingEnabled = true;
            this.WayNumInput.Location = new System.Drawing.Point(184, 556);
            this.WayNumInput.Name = "WayNumInput";
            this.WayNumInput.Size = new System.Drawing.Size(302, 39);
            this.WayNumInput.TabIndex = 38;
            // 
            // AutoparkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 700);
            this.Controls.Add(this.WayNumInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SortByWayNum);
            this.Controls.Add(this.SortByName);
            this.Controls.Add(this.DeleteCar);
            this.Controls.Add(this.ChangeCar);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AutoNameInput);
            this.Controls.Add(this.AutoNumInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AutoList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AutoparkForm";
            this.Text = "Автопарк";
            this.Load += new System.EventHandler(this.AutoparkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SortByWayNum;
        private System.Windows.Forms.Button SortByName;
        private System.Windows.Forms.Button DeleteCar;
        private System.Windows.Forms.Button ChangeCar;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AutoNameInput;
        private System.Windows.Forms.TextBox AutoNumInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView AutoList;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private ComboBox WayNumInput;
    }
}
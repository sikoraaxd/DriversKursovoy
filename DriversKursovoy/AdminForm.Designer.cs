
namespace DriversKursovoy
{
    partial class AdminForm
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
            this.UsersList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.FioInput = new System.Windows.Forms.TextBox();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RoleBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AddUser = new System.Windows.Forms.Button();
            this.ChangeUser = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.SortByFIO = new System.Windows.Forms.Button();
            this.SortByRole = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SignOut = new System.Windows.Forms.Button();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HelloLabel.Location = new System.Drawing.Point(12, 31);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(289, 24);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "Добро пожаловать, user_name!";
            // 
            // UsersList
            // 
            this.UsersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.UsersList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsersList.FullRowSelect = true;
            this.UsersList.GridLines = true;
            this.UsersList.Location = new System.Drawing.Point(16, 125);
            this.UsersList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(968, 349);
            this.UsersList.TabIndex = 1;
            this.UsersList.UseCompatibleStateImageBehavior = false;
            this.UsersList.View = System.Windows.Forms.View.Details;
            this.UsersList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.UserChanged);
            this.UsersList.SelectedIndexChanged += new System.EventHandler(this.UsersList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 1;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО";
            this.columnHeader2.Width = 242;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Логин";
            this.columnHeader3.Width = 242;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Пароль";
            this.columnHeader4.Width = 242;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Роль";
            this.columnHeader5.Width = 242;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пользователи";
            // 
            // FioInput
            // 
            this.FioInput.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FioInput.Location = new System.Drawing.Point(110, 549);
            this.FioInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FioInput.Name = "FioInput";
            this.FioInput.Size = new System.Drawing.Size(380, 36);
            this.FioInput.TabIndex = 3;
            // 
            // LoginInput
            // 
            this.LoginInput.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginInput.Location = new System.Drawing.Point(110, 618);
            this.LoginInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(380, 36);
            this.LoginInput.TabIndex = 4;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordInput.Location = new System.Drawing.Point(110, 689);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(380, 36);
            this.PasswordInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 556);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "ФИО:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 625);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Логин:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 696);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Пароль:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(39, 760);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Роль:";
            // 
            // RoleBox
            // 
            this.RoleBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoleBox.FormattingEnabled = true;
            this.RoleBox.Items.AddRange(new object[] {
            "Администратор",
            "Менеджер поездок",
            "Водитель"});
            this.RoleBox.Location = new System.Drawing.Point(110, 752);
            this.RoleBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(380, 36);
            this.RoleBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(562, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Редактирование";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(807, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Сортировка";
            // 
            // AddUser
            // 
            this.AddUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddUser.Location = new System.Drawing.Point(531, 549);
            this.AddUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(209, 45);
            this.AddUser.TabIndex = 14;
            this.AddUser.Text = "Добавить";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // ChangeUser
            // 
            this.ChangeUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeUser.Location = new System.Drawing.Point(531, 618);
            this.ChangeUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeUser.Name = "ChangeUser";
            this.ChangeUser.Size = new System.Drawing.Size(209, 45);
            this.ChangeUser.TabIndex = 15;
            this.ChangeUser.Text = "Изменить";
            this.ChangeUser.UseVisualStyleBackColor = true;
            this.ChangeUser.Click += new System.EventHandler(this.ChangeUser_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteUser.Location = new System.Drawing.Point(531, 689);
            this.DeleteUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(209, 45);
            this.DeleteUser.TabIndex = 16;
            this.DeleteUser.Text = "Удалить";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // SortByFIO
            // 
            this.SortByFIO.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortByFIO.Location = new System.Drawing.Point(764, 549);
            this.SortByFIO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortByFIO.Name = "SortByFIO";
            this.SortByFIO.Size = new System.Drawing.Size(209, 45);
            this.SortByFIO.TabIndex = 17;
            this.SortByFIO.Text = "По ФИО";
            this.SortByFIO.UseVisualStyleBackColor = true;
            this.SortByFIO.Click += new System.EventHandler(this.SortByFIO_Click);
            // 
            // SortByRole
            // 
            this.SortByRole.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SortByRole.Location = new System.Drawing.Point(764, 618);
            this.SortByRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortByRole.Name = "SortByRole";
            this.SortByRole.Size = new System.Drawing.Size(209, 45);
            this.SortByRole.TabIndex = 18;
            this.SortByRole.Text = "По роли";
            this.SortByRole.UseVisualStyleBackColor = true;
            this.SortByRole.Click += new System.EventHandler(this.SortByRole_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(238, 491);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Информация";
            // 
            // SignOut
            // 
            this.SignOut.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignOut.Location = new System.Drawing.Point(861, 24);
            this.SignOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(123, 45);
            this.SignOut.TabIndex = 20;
            this.SignOut.Text = "Выйти";
            this.SignOut.UseVisualStyleBackColor = true;
            // 
            // IdBox
            // 
            this.IdBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdBox.Location = new System.Drawing.Point(158, 85);
            this.IdBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdBox.Name = "IdBox";
            this.IdBox.ReadOnly = true;
            this.IdBox.Size = new System.Drawing.Size(36, 36);
            this.IdBox.TabIndex = 21;
            this.IdBox.Visible = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 825);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.SignOut);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SortByRole);
            this.Controls.Add(this.SortByFIO);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.ChangeUser);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RoleBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.LoginInput);
            this.Controls.Add(this.FioInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsersList);
            this.Controls.Add(this.HelloLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminForm";
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.ListView UsersList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FioInput;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RoleBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button ChangeUser;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button SortByFIO;
        private System.Windows.Forms.Button SortByRole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SignOut;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private TextBox IdBox;
    }
}
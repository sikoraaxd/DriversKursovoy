namespace DriversKursovoy
{
    partial class PathNumbersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.PathNumbersBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.pathNumEditBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите маршрутный путь:";
            // 
            // PathNumbersBox
            // 
            this.PathNumbersBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathNumbersBox.FormattingEnabled = true;
            this.PathNumbersBox.Location = new System.Drawing.Point(279, 16);
            this.PathNumbersBox.Name = "PathNumbersBox";
            this.PathNumbersBox.Size = new System.Drawing.Size(286, 33);
            this.PathNumbersBox.TabIndex = 1;
            this.PathNumbersBox.SelectedIndexChanged += new System.EventHandler(this.PathNumbersBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(550, 431);
            this.textBox1.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(382, 511);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(183, 31);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(583, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(208, 382);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.pathNumChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Маршрутный номер";
            this.columnHeader2.Width = 200;
            // 
            // pathNumEditBox
            // 
            this.pathNumEditBox.Location = new System.Drawing.Point(583, 404);
            this.pathNumEditBox.Name = "pathNumEditBox";
            this.pathNumEditBox.Size = new System.Drawing.Size(208, 27);
            this.pathNumEditBox.TabIndex = 5;
            // 
            // IdBox
            // 
            this.IdBox.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdBox.Location = new System.Drawing.Point(340, 506);
            this.IdBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IdBox.Name = "IdBox";
            this.IdBox.ReadOnly = true;
            this.IdBox.Size = new System.Drawing.Size(36, 36);
            this.IdBox.TabIndex = 22;
            this.IdBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(583, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 31);
            this.button2.TabIndex = 24;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(583, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 31);
            this.button3.TabIndex = 25;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PathNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 549);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.pathNumEditBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PathNumbersBox);
            this.Controls.Add(this.label1);
            this.Name = "PathNumbersForm";
            this.Text = "Маршрутные пути ";
            this.Load += new System.EventHandler(this.PathNumbersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox PathNumbersBox;
        private TextBox textBox1;
        private Button SaveButton;
        private ListView listView1;
        private ColumnHeader columnHeader2;
        private TextBox pathNumEditBox;
        private TextBox IdBox;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
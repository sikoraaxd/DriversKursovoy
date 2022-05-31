using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DriversKursovoy.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DriversKursovoy
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void ShowDB()
        {
            UsersList.Items.Clear();
            using(ApplicationContext db = new ApplicationContext())
            {
                foreach(User user in db.Users)
                {
                    string[] row = { user.Id.ToString(), user.Name, user.Login, user.Password, user.Role };
                    var listViewItem = new ListViewItem(row);
                    UsersList.Items.Add(listViewItem);
                }
            }
        }

        private void ClearText()
        {
            FioInput.Clear();
            LoginInput.Clear();
            PasswordInput.Clear();
            RoleBox.SelectedIndex = -1;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            HelloLabel.Text = HelloLabel.Text.Replace("user_name", ExtendedData.CurrentUser);
            ShowDB();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            if (FioInput.Text == "" || LoginInput.Text == "" || PasswordInput.Text == "" || RoleBox.SelectedIndex == -1)
                return;
            if (FioInput.Text.Length > 40 || LoginInput.Text.Length > 40 || PasswordInput.Text.Length > 20)
                return;
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach(User user in db.Users)
                    if (user.Login == LoginInput.Text)
                        return;
                User newUser = new User();
                newUser.Id = Guid.NewGuid();
                newUser.Name = FioInput.Text;
                newUser.Login = LoginInput.Text;
                newUser.Password = PasswordInput.Text;
                newUser.Role = RoleBox.Text;
                Schedule userSchedule = new Schedule();
                newUser.DaysOfWork = JsonConvert.SerializeObject(userSchedule);
                db.Users.Add(newUser);
                db.SaveChanges();
            }
            ShowDB();
            ClearText();
        }

        private void ChangeUser_Click(object sender, EventArgs e)
        {
            if (FioInput.Text == "" || LoginInput.Text == "" || PasswordInput.Text == "" || RoleBox.SelectedIndex == -1)
                return;
            if (FioInput.Text.Length > 40 || LoginInput.Text.Length > 40 || PasswordInput.Text.Length > 20)
                return;
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (User user in db.Users)
                    if (LoginInput.Text == user.Login && user.Id.ToString() != IdBox.Text)
                        return;
                User targetedUser = db.Users.Where(u => u.Id.ToString() == IdBox.Text).First();
                targetedUser.Login = LoginInput.Text;
                targetedUser.Name = FioInput.Text;
                targetedUser.Password = PasswordInput.Text;
                targetedUser.Role = RoleBox.Text;
                db.SaveChanges();
            }
            ShowDB();
            ClearText();
        }

        private void UserChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            IdBox.Text = UsersList.Items[e.ItemIndex].SubItems[0].Text;
            FioInput.Text = UsersList.Items[e.ItemIndex].SubItems[1].Text;
            LoginInput.Text = UsersList.Items[e.ItemIndex].SubItems[2].Text;
            PasswordInput.Text = UsersList.Items[e.ItemIndex].SubItems[3].Text;
            RoleBox.Text = UsersList.Items[e.ItemIndex].SubItems[4].Text;
        }

        private void UsersList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                User user = db.Users.Where(u => u.Id.ToString() == IdBox.Text).FirstOrDefault();
                db.Users.Remove(user);
                db.SaveChanges();
                ShowDB();
            }
        }

        private void SortByFIO_Click(object sender, EventArgs e)
        {

        }

        private void SortByRole_Click(object sender, EventArgs e)
        {
            
        }
    }
}

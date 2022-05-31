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

namespace DriversKursovoy
{
    public partial class AuthorisationForm : Form
    {
        public AuthorisationForm()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            User currentUser= new User();
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach(User user in db.Users)
                {
                    if(user.Login == LoginInput.Text)
                        if (user.Password == PasswordInput.Text)
                            currentUser = user;
                }
            }
            if (currentUser.Name == "")
                return;

            ExtendedData.CurrentUser = currentUser.Name;

            if(currentUser.Role == "Администратор")
            {
                AdminForm adminForm = new AdminForm();
                Hide();
                adminForm.ShowDialog();
            }
            else if (currentUser.Role == "Менеджер поездок")
            {
                DriveManagerForm driveManagerForm = new DriveManagerForm();
                Hide();
                driveManagerForm.ShowDialog();
            }
            else if (currentUser.Role == "Водитель")
            {
                DriverForm driverForm = new DriverForm();
                Hide();
                driverForm.ShowDialog();
            }
            Show();
        }

        private void AuthorisationForm_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                if (users.Count == 0)
                {
                    User adminUser = new User { Id = Guid.NewGuid(), 
                                                Name = "admin", 
                                                Login = "admin", 
                                                Password = "admin", 
                                                Role = "Администратор",
                                                DaysOfWork = "{}" };
                    db.Users.Add(adminUser);
                    db.SaveChanges();
                }
            }
        }
    }
}

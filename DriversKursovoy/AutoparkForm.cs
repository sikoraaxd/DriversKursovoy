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
    public partial class AutoparkForm : Form
    {
        public AutoparkForm()
        {
            InitializeComponent();
        }

        private void ClearTxt()
        {
            AutoNameInput.Clear();
            AutoNumInput.Clear();
            WayNumInput.SelectedIndex = -1;
        }

        private void ShowDB()
        {
            AutoList.Items.Clear();
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (Car car in db.Cars)
                {
                    string[] row = { car.Model, car.Number, car.PathNumber };
                    var listViewItem = new ListViewItem(row);
                    AutoList.Items.Add(listViewItem);
                }
            }
        }

        private void AutoparkForm_Load(object sender, EventArgs e)
        {
            ShowDB();
            using(ApplicationContext db = new ApplicationContext())
            {
                foreach(var pathNum in db.PathNumbers.ToList())
                {
                    WayNumInput.Items.Add(pathNum.Number);
                }
            }
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            if (AutoNumInput.Text == "" || AutoNameInput.Text == "" || WayNumInput.Text == "")
                return;
            if (AutoNumInput.Text.Length > 10 || AutoNameInput.Text.Length > 40 || WayNumInput.Text.Length > 5)
                return;
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (Car _car in db.Cars)
                    if (AutoNumInput.Text == _car.Number)
                        return;
                Car car = new Car();
                car.Number = AutoNumInput.Text;
                car.Model = AutoNameInput.Text;
                car.PathNumber = WayNumInput.Text;
                car.drivers = new List<Guid>();
                db.Cars.Add(car);
                db.SaveChanges();
            }
            ShowDB();
            ClearTxt();
        }

        private void ChangeCar_Click(object sender, EventArgs e)
        {
            if (AutoNumInput.Text == "" || AutoNameInput.Text == "" || WayNumInput.Text == "")
                return;
            if (AutoNumInput.Text.Length > 10 || AutoNameInput.Text.Length > 40 || WayNumInput.Text.Length > 5)
                return;
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (Car car in db.Cars)
                    if (AutoNumInput.Text == car.Number)
                        return;
                Car targetedCar = db.Cars.Where(u => u.Number == AutoNumInput.Text).First();
                targetedCar.Number = AutoNumInput.Text;
                targetedCar.Model = AutoNameInput.Text;
                targetedCar.PathNumber = WayNumInput.Text;
                db.SaveChanges();
            }
            ShowDB();
            ClearTxt();
        }

        private void DeleteCar_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Car car = db.Cars.Where(u => u.Number == AutoNumInput.Text).FirstOrDefault();
                db.Cars.Remove(car);
                db.SaveChanges();
                ShowDB();
            }
        }
    }
}

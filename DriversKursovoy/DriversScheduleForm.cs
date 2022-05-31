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
    public partial class DriversScheduleForm : Form
    {
        public DriversScheduleForm()
        {
            InitializeComponent();
        }

        private void FillDriversBox()
        {
            
            using(ApplicationContext db = new ApplicationContext())
            {
                Npgsql.NpgsqlConnection pgcon = new Npgsql.NpgsqlConnection(db.Database.GetConnectionString());
                pgcon.Open();
                Npgsql.NpgsqlCommand pgcom1 = new Npgsql.NpgsqlCommand(@"get_drivers_names", pgcon);
                pgcom1.CommandType = CommandType.StoredProcedure;
                Npgsql.NpgsqlDataReader npgsqlDataReader1 = pgcom1.ExecuteReader();
                while(npgsqlDataReader1.Read())
                {
                    string driver = npgsqlDataReader1.GetString(0);
                    DriverBox.Items.Add(driver);
                }
                npgsqlDataReader1.Close();
                pgcon.Close();
            }
        }

        private void DriversScheduleForm_Load(object sender, EventArgs e)
        {
            FillDriversBox();
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (Car car in db.Cars)
                    carNumBox.Items.Add(car.Number);

            }
        }

        private Schedule GetUserSchedule()
        {
            Data.Schedule userScedule = new Data.Schedule();
            using(ApplicationContext db = new ApplicationContext())
            {
                string stringSchedule = db.Users.Where(u => u.Name == DriverBox.Text).First().DaysOfWork;
                userScedule = JsonConvert.DeserializeObject<Data.Schedule>(stringSchedule);
            }
            return userScedule;
        }

        private void ShowDB()
        {
            Schedule.Items.Clear();
            Data.Schedule userSchedule = GetUserSchedule();
            string minutes = "30";
            int hour = 6;
            for (int i = 0; i < 60; i++)
            {
                string time = Convert.ToString(hour) + ":" + minutes;
                string[] raw = new string[7];
                if (userSchedule.Monday.Contains(time))
                    raw[0] = time;
                else raw[0] = "-";
                if (userSchedule.Tuesday.Contains(time))
                    raw[1] = time;
                else raw[1] = "-";
                if (userSchedule.Wednesday.Contains(time))
                    raw[2] = time;
                else raw[2] = "-";
                if (userSchedule.Thursday.Contains(time))
                    raw[3] = time;
                else raw[3] = "-";
                if (userSchedule.Friday.Contains(time))
                    raw[4] = time;
                else raw[4] = "-";
                if (userSchedule.Saturday.Contains(time))
                    raw[5] = time;
                else raw[5] = "-";
                if (userSchedule.Sunday.Contains(time))
                    raw[6] = time;
                else raw[6] = "-";

                ListViewItem listViewItem = new ListViewItem(raw);
                Schedule.Items.Add(listViewItem);

                if (minutes == "00")
                    minutes = "30";
                else
                {
                    minutes = "00";
                    hour++;
                }
            }
        }

        private void DriverBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowDB();
            using (ApplicationContext db = new ApplicationContext())
            {
                int tempCount = 0;
                foreach(Car car in db.Cars.ToList())
                {
                    if(car.drivers.Contains(db.Users.Where(d => d.Name == DriverBox.Text).First().Id))
                        tempCount++;
                }
                if(tempCount > 0)
                    carNumBox.SelectedIndex = db.Cars.ToList().IndexOf(db.Cars.ToList().
                                            Where(c => c.drivers.Contains(db.Users.
                                            Where(u => u.Name == DriverBox.Text).First().Id)).First());
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int dayOfWeek = DayOfWeekBox.SelectedIndex;
            Data.Schedule userSchedule = GetUserSchedule();
            if(dayOfWeek == 0)
                if(!userSchedule.Monday.Contains(TimeBox.Text))
                    userSchedule.Monday.Add(TimeBox.Text);
            if (dayOfWeek == 1)
                if (!userSchedule.Tuesday.Contains(TimeBox.Text))
                    userSchedule.Tuesday.Add(TimeBox.Text);
            if (dayOfWeek == 2)
                if (!userSchedule.Wednesday.Contains(TimeBox.Text))
                    userSchedule.Wednesday.Add(TimeBox.Text);
            if (dayOfWeek == 3)
                if (!userSchedule.Thursday.Contains(TimeBox.Text))
                    userSchedule.Thursday.Add(TimeBox.Text);
            if (dayOfWeek == 4)
                if (!userSchedule.Friday.Contains(TimeBox.Text))
                    userSchedule.Friday.Add(TimeBox.Text);
            if (dayOfWeek == 5)
                if (!userSchedule.Saturday.Contains(TimeBox.Text))
                    userSchedule.Saturday.Add(TimeBox.Text);
            if (dayOfWeek == 6)
                if (!userSchedule.Sunday.Contains(TimeBox.Text))
                    userSchedule.Sunday.Add(TimeBox.Text);
            using (ApplicationContext db = new ApplicationContext())
            {
                User targetedUser = db.Users.Where(u => u.Name == DriverBox.Text).FirstOrDefault();
                targetedUser.DaysOfWork = JsonConvert.SerializeObject(userSchedule);
                db.SaveChanges();
            }
            ShowDB();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int dayOfWeek = DayOfWeekBox.SelectedIndex;
            Data.Schedule userSchedule = GetUserSchedule();
            if (dayOfWeek == 0)
                if (userSchedule.Monday.Contains(TimeBox.Text))
                    userSchedule.Monday.Remove(TimeBox.Text);
            if (dayOfWeek == 1)
                if (userSchedule.Tuesday.Contains(TimeBox.Text))
                    userSchedule.Tuesday.Remove(TimeBox.Text);
            if (dayOfWeek == 2)
                if (userSchedule.Wednesday.Contains(TimeBox.Text))
                    userSchedule.Wednesday.Remove(TimeBox.Text);
            if (dayOfWeek == 3)
                if (userSchedule.Thursday.Contains(TimeBox.Text))
                    userSchedule.Thursday.Remove(TimeBox.Text);
            if (dayOfWeek == 4)
                if (userSchedule.Friday.Contains(TimeBox.Text))
                    userSchedule.Friday.Remove(TimeBox.Text);
            if (dayOfWeek == 5)
                if (userSchedule.Saturday.Contains(TimeBox.Text))
                    userSchedule.Saturday.Remove(TimeBox.Text); 
            if (dayOfWeek == 6)
                if (userSchedule.Sunday.Contains(TimeBox.Text))
                    userSchedule.Sunday.Remove(TimeBox.Text);
            
            using(ApplicationContext db = new ApplicationContext())
            {
                User targetedUser = db.Users.Where(u => u.Name == DriverBox.Text).FirstOrDefault();
                targetedUser.DaysOfWork = JsonConvert.SerializeObject(userSchedule);
                db.SaveChanges();
            }
            ShowDB();
        }

        private void carNumBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                Guid userGuid = db.Users.Where(u => u.Name == DriverBox.Text).First().Id;
                foreach(Car car in db.Cars.ToList())
                    if(car.drivers.Contains(userGuid))
                    {
                        Car targetedCar = db.Cars.Where(c => c.Number == car.Number).FirstOrDefault();
                        targetedCar.drivers.Remove(userGuid);
                        db.SaveChanges();
                    }
                Car targetCar = db.Cars.Where(c => c.Number == carNumBox.Text).FirstOrDefault();
                targetCar.drivers.Add(userGuid);
                db.SaveChanges();
            }
            
        }
    }
}

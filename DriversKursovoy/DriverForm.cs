using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using DriversKursovoy.Data;
using Newtonsoft.Json;

namespace DriversKursovoy
{
    public partial class DriverForm : Form
    {
        public DriverForm()
        {
            InitializeComponent();
            timer1.Interval = 60000;
            timer1.Start();
        }

        private void ShowDB()
        {
            Schedule.Items.Clear();
            string stringSchedule = "";
            using (ApplicationContext db = new ApplicationContext())
            {
                stringSchedule = db.Users.Where(u => u.Name == ExtendedData.CurrentUser).First().DaysOfWork;
            }
            Data.Schedule userSchedule = JsonConvert.DeserializeObject<Data.Schedule>(stringSchedule);
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

        private void getNearDrive(int DayOfWeek, int cHour, int cMinute, Guid userId)
        {
            using(ApplicationContext db = new ApplicationContext())
            {
                Schedule schedule = JsonConvert.DeserializeObject<Schedule>(db.Users.Where(u => u.Id == userId).FirstOrDefault().DaysOfWork);
                List<string> hoursOfWork = new List<string>();
                switch (DayOfWeek)
                {
                    case 0:
                        hoursOfWork = schedule.Sunday;
                        break;
                    case 1:
                        hoursOfWork = schedule.Monday;
                        break;
                    case 2:
                        hoursOfWork = schedule.Tuesday;
                        break;
                    case 3:
                        hoursOfWork = schedule.Wednesday;
                        break;
                    case 4:
                        hoursOfWork = schedule.Thursday;
                        break;
                    case 5:
                        hoursOfWork = schedule.Friday;
                        break;
                    case 6:
                        hoursOfWork = schedule.Saturday;
                        break;
                }
                string cTime = ((Convert.ToString(cHour).Length == 2) ? Convert.ToString(cHour) : "0" + Convert.ToString(cHour)) + ":" + 
                               ((Convert.ToString(cMinute).Length == 2)? Convert.ToString(cMinute) : "0" + Convert.ToString(cMinute));
                if (hoursOfWork.Count == 0)
                    NextDrive.Text = "Нет";
                else
                {
                    DateTime cTimestamp = DateTime.ParseExact(cTime, "HH:mm", CultureInfo.InvariantCulture);
                    DateTime nextDriveTime = cTimestamp;
                    foreach(string time in hoursOfWork)
                    {
                        DateTime tTimestamp = DateTime.ParseExact(time, "HH:mm", CultureInfo.InvariantCulture);
                        if (tTimestamp > cTimestamp && nextDriveTime < tTimestamp)
                            nextDriveTime = tTimestamp;
                    }
                    NextDrive.Text = nextDriveTime.Hour.ToString() + ":" + nextDriveTime.Minute.ToString();
                }
                
            }
            
        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            HelloLabel.Text = HelloLabel.Text.Replace("user_name", ExtendedData.CurrentUser);
            ShowDB();
            Guid currentUserGuid;
            using (ApplicationContext db = new ApplicationContext())
            {
                currentUserGuid = db.Users.Where(u => u.Name == ExtendedData.CurrentUser).FirstOrDefault().Id;
                string carNumber = db.Cars.Where(c => c.drivers.Contains(currentUserGuid)).First().Number;
                AutoNumber.Text = carNumber;
            }
            DateTime date = DateTime.Now;
            getNearDrive(((int)date.DayOfWeek), date.Hour, date.Minute, currentUserGuid);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DriverForm_Load(null, null);
        }
    }
}

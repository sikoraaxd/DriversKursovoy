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
    public partial class DriveManagerForm : Form
    {
        public DriveManagerForm()
        {
            InitializeComponent();
        }

        private void Autopark_Click(object sender, EventArgs e)
        {
            AutoparkForm autoparkForm = new AutoparkForm();
            Hide();
            autoparkForm.ShowDialog();
            Show();
        }

        private void ShowDB()
        {
            
        }

        private void ClearText()
        {

        }


        private void DriveManagerForm_Load(object sender, EventArgs e)
        {
            HelloLabel.Text = HelloLabel.Text.Replace("user_name", ExtendedData.CurrentUser);
            ShowDB();
        }

        private void DriversSchedule_Click(object sender, EventArgs e)
        {
            DriversScheduleForm scheduleForm = new DriversScheduleForm();
            Hide();
            scheduleForm.ShowDialog();
            Show();
        }

        private void DeleteDrive_Click(object sender, EventArgs e)
        {

        }

        private void StartDriving_Click(object sender, EventArgs e)
        {

        }

        private void StopDriving_Click(object sender, EventArgs e)
        {

        }

        private void PathNumbers_Click(object sender, EventArgs e)
        {
            PathNumbersForm pnf = new PathNumbersForm();
            Hide();
            pnf.ShowDialog();
            Show();
        }
    }
}

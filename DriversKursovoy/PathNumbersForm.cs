using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DriversKursovoy
{
    public partial class PathNumbersForm : Form
    {
        public PathNumbersForm()
        {
            InitializeComponent();
        }

        private void pathNumChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            IdBox.Text = listView1.Items[e.ItemIndex].SubItems[0].Text;
            pathNumEditBox.Text = listView1.Items[e.ItemIndex].SubItems[0].Text;
        }

        private void PathNumbersForm_Load(object sender, EventArgs e)
        {
            ClearTxt();
            PathNumbersBox.Items.Clear();
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (var pathNumber in db.PathNumbers.ToList())
                {
                    PathNumbersBox.Items.Add(pathNumber.Number);
                    ListViewItem listViewItem = new ListViewItem(pathNumber.Number);
                    listView1.Items.Add(listViewItem);
                }
            }
        }

        private void ClearTxt()
        {
            PathNumbersBox.SelectedIndex = -1;
            textBox1.Clear();
            IdBox.Clear();
            listView1.Items.Clear();
            pathNumEditBox.Clear();
        }

        private void PathNumbersBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            using (ApplicationContext db = new ApplicationContext())
            {
                Dictionary<int, string> dict = JsonConvert.DeserializeObject<Dictionary<int, string>>
                    (db.PathNumbers.Where(pn => pn.Number == PathNumbersBox.Text).FirstOrDefault().PathSequence);
                foreach (var key in dict.Keys)
                {
                    textBox1.Text += dict[key] + "\n\r";
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (PathNumbersBox.Text == "")
                return;
            using (ApplicationContext db = new ApplicationContext())
            {
                Dictionary<int, string> dict = new Dictionary<int, string>();
                int i = 1;
                foreach (var str in textBox1.Lines)
                    dict.Add(i++, str);
                Data.PathNumber pathNum = db.PathNumbers.Where(pn => pn.Number == PathNumbersBox.Text).First();
                pathNum.PathSequence = JsonConvert.SerializeObject(dict);
                db.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Data.PathNumber pathNum = new Data.PathNumber();
                pathNum.Number = pathNumEditBox.Text;
                pathNum.PathSequence = "{}";
                db.PathNumbers.Add(pathNum);
                db.SaveChanges();
            }
            ClearTxt();
            PathNumbersForm_Load(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Data.PathNumber pathNum = db.PathNumbers.Where(pn => pn.Number == IdBox.Text).First();
                pathNum.Number = pathNumEditBox.Text;
                db.SaveChanges();
            }
            ClearTxt();
            PathNumbersForm_Load(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Data.PathNumber pathNum = db.PathNumbers.Where(pn => pn.Number == IdBox.Text).First();
                db.PathNumbers.Remove(pathNum);
                db.SaveChanges();
            }
            ClearTxt();
            PathNumbersForm_Load(null, null);
        }
    }
}
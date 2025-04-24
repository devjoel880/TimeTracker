using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class AddMode : Form
    {
        public AddMode()
        {
            InitializeComponent();
        }

        private void AddMode_Load(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string modeName = textBox1.Text;
            int hours = (int)hour.Value;
            int minutes = (int)minute.Value;
            int totalMinutes = (hours * 60) + minutes;  // convert to minutes to fit the db Model

            if (modeName != " " && hours != 0  || minutes != 0)
            {
                dbCon db = new dbCon();
                db.SaveMode(modeName, totalMinutes);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter details to be saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}

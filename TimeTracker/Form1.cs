using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace TimeTracker
{
    public partial class Form1 : Form
    {
        string dbPath = @"DataSource=TimeTracker.db";
        private TimeSpan remainingTime;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadModes();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (remainingTime.TotalSeconds <= 0)
            {
                MessageBox.Show("No duration set. Please select a valid mode first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            timer1.Interval = 1000; // 1 second
            timer1.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddMode addPage = new AddMode();
            addPage.ShowDialog();
            LoadModes();
        }

        public void LoadModes()
        {
            comboBox1.Items.Clear();
            dbCon dbCon = new dbCon();
            using (var connection = new SqliteConnection(dbCon.dbPath))
            {
                connection.Open();
                string query = "SELECT modeName FROM Mode";
                using (var cmd = new SqliteCommand(query, connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            dbCon db = new dbCon();
            using (var connection = new SqliteConnection(db.dbPath))
            {
                connection.Open();
                string query = "DELETE FROM Mode";
                using (var cmd = new SqliteCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("All Modes have been cleared", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string selectedMode = comboBox1.SelectedItem.ToString(); -> This doeas the same thing as the line below

            string selectedMode = comboBox1.Text;
            dbCon db = new dbCon();
            using (var connection = new SqliteConnection(db.dbPath))
            {
                connection.Open();
                string query = "SELECT durationInMinutes FROM Mode WHERE modeName = @modeName";
                using (var cmd = new SqliteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@modeName", selectedMode);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int totalMinutes = reader.GetInt32(0);
                            TimeSpan time = TimeSpan.FromMinutes(totalMinutes);
                            remainingTime = time;
                            timerValue.Text = time.ToString(@"hh\:mm\:ss");

                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remainingTime.TotalSeconds > 0)
            {
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                timerValue.Text = remainingTime.ToString(@"hh\:mm\:ss");
            }
            else
            {
                timer1.Stop();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("alarm.wav");
                player.Play();

                DialogResult result = MessageBox.Show("Time is up!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    player.Stop();
                }
            }
        }
    }
}

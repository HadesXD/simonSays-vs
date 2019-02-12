using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Simon
{
    public partial class Simon : Form
    {
        public Simon (string username) //Start
        {
            InitializeComponent();
            this.userIme = username;

            UserLabel.Text = "Current User: " + this.userIme;

            using (SQLiteConnection Conn = new SQLiteConnection("Data Source = database.sqlite"))
            {
                Conn.Open();

                using (SQLiteCommand createCommand = new SQLiteCommand(Conn))
                {
                    createCommand.CommandText = "SELECT score FROM uporabniki WHERE username = '" + this.userIme + "';";
                    SQLiteDataReader result = createCommand.ExecuteReader();
                    result.Read();
                    int kek = result.GetInt32(0);
                    createCommand.Dispose();

                    HighScoreLabel.Text = "Current highscore: " + kek;
                }

                Conn.Close();
            }
        }

        //1
        string userIme;
        int Stevec = 0;
        List<int> vzorec = new List<int>();
        Random random = new Random();
        bool playingBack = false;
        int time = 500;
        //4

        private void GreenButton_Click(object sender, EventArgs e)
        {
            testCorrect(0);
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            testCorrect(1);
        }

        private void YellowButton_Click(object sender, EventArgs e)
        {
            testCorrect(2);
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            testCorrect(3);
        }

        //5
        void testCorrect(int color)
        {
            if (playingBack)
            {
                return;
            }

            if (vzorec[Stevec] == color)
            {
                Stevec++;
            }
            //6 fail
            else
            {
                try
                {
                    using (SQLiteConnection Conn = new SQLiteConnection("Data Source = database.sqlite"))
                    {
                        Conn.Open();

                        using (SQLiteCommand createCommand = new SQLiteCommand(Conn))
                        {
                            createCommand.CommandText = "SELECT score FROM uporabniki WHERE username = '" + this.userIme + "';";
                            SQLiteDataReader result = createCommand.ExecuteReader();
                            result.Read();
                            int kek = result.GetInt32(0);

                            if (kek < vzorec.Count || kek == 0)
                            {
                                createCommand.Dispose();
                                MessageBox.Show("New high score!");
                                createCommand.CommandText = "UPDATE uporabniki SET score = " + vzorec.Count + " WHERE username = '" + this.userIme + "';";
                                createCommand.ExecuteNonQuery();
                                createCommand.Dispose();

                            }
                            else
                            {
                                MessageBox.Show("Failure");
                            }

                        }

                        Conn.Close();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
                MessageBox.Show("You failed, final score " + vzorec.Count.ToString());
                Stevec = 0;
                vzorec = new List<int>();
                new Thread(playBack).Start();
            }

            //6 win
            if (Stevec >= vzorec.Count)
            {
                vzorec.Add(random.Next(0, 4));
                Stevec = 0;
                new Thread(playBack).Start();
            }

            using (SQLiteConnection Conn = new SQLiteConnection("Data Source = database.sqlite"))
            {
                Conn.Open();
                using (SQLiteCommand createCommand = new SQLiteCommand(Conn))
                {
                    createCommand.CommandText = "SELECT score FROM uporabniki WHERE username = '" + this.userIme + "';";
                    SQLiteDataReader result = createCommand.ExecuteReader();
                    result.Read();
                    int kek = result.GetInt32(0);
                    createCommand.Dispose();
                    HighScoreLabel.Text = "Current highscore: " + kek;
                }
                Conn.Close();
            }

            ScoreLabel.Text = ("Score " + vzorec.Count.ToString());
            PatternLabel.Text = ("Pattern: " + Stevec.ToString());
        }

        //3
        void playBack()
        {
            playingBack = true;

            foreach (int color in vzorec)
            {
                switch (color)
                {
                    case 0:
                        GreenButton.BackColor = Color.Green;
                        Thread.Sleep(time);
                        GreenButton.BackColor = Color.Transparent;
                        break;
                    case 1:
                        RedButton.BackColor = Color.Red;
                        Thread.Sleep(time);
                        RedButton.BackColor = Color.Transparent;
                        break;
                    case 2:
                        YellowButton.BackColor = Color.Yellow;
                        Thread.Sleep(time);
                        YellowButton.BackColor = Color.Transparent;
                        break;
                    case 3:
                        BlueButton.BackColor = Color.Blue;
                        Thread.Sleep(time);
                        BlueButton.BackColor = Color.Transparent;
                        break;
                }
                Thread.Sleep(300);
            }
            playingBack = false;
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            time = 800;
            MessageBox.Show("Izbrali ste Easy");
        }

        private void MediumButton_Click(object sender, EventArgs e)
        {
            time = 500;
            MessageBox.Show("Izbrali ste Medium");
        }

        private void HardButton_Click(object sender, EventArgs e)
        {
            time = 150;
            MessageBox.Show("Izbrali ste Hard");
        }

        //2
        private void Simon_Load(object sender, EventArgs e)
        {
            vzorec.Add(random.Next(0, 4));
            new Thread(playBack).Start();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
            this.Close();
        }

        private void HighscoreButton_Click(object sender, EventArgs e)
        {
            High_Score log = new High_Score();
            log.ShowDialog();
        }

        private void Simon_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

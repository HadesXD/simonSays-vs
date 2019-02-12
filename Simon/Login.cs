using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Simon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent(); //Start
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //1
            string email = this.EmailTextBox.Text;
            string pass = this.PassTextBox.Text;
            bool userKnown = false;
            string username = "";

            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection("Data Source = database.sqlite"))
                {
                    Conn.Open();
                    //2
                    using (SQLiteCommand createCommand = new SQLiteCommand(Conn))
                    {
                        try
                        {
                            createCommand.CommandText = "SELECT * FROM uporabniki WHERE email ='" + email + "' AND pass= '" + pass + "' ";
                            SQLiteDataReader result = createCommand.ExecuteReader();

                            if (result.HasRows)
                            {
                                result.Read();
                                username = result.GetString(1);
                                userKnown = true;
                            }
                            createCommand.Dispose();
                        }

                        catch (OverflowException ex)
                        {
                            MessageBox.Show("Je preveliko ali premalo " + ex.Message);
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Napaka: " + ex.Message);
                        }
                    }

                    Conn.Close();
                }
                //2.5 success
                if (userKnown)
                {
                    this.Hide();
                    Simon game = new Simon(username);
                    game.ShowDialog();
                    this.Close();
                }
                //2.5 fail
                else
                {
                    MessageBox.Show("Email ali geslo nista pravilna!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register log = new Register();
            log.ShowDialog();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.EmailTextBox.Text = "";
            this.PassTextBox.Text = "";
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home log = new Home();
            log.ShowDialog();
            this.Close();
        }

        private void Login_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

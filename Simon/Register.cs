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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent(); //Start
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            //1
            int yo = 0;
            string uime = this.UserTextBox.Text;
            string email = this.EmailTextBox.Text;
            string pass1 = this.Pass1TextBox.Text;
            string pass2 = this.Pass2TextBox.Text;
            //2
            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection("Data Source = database.sqlite"))
                {
                    Conn.Open();
                    //3 success
                    if (this.Pass1TextBox.Text == this.Pass2TextBox.Text)
                    {
                        int count = 0;

                        using (SQLiteCommand createCommand = new SQLiteCommand(Conn))
                        {
                            createCommand.CommandText = "SELECT * FROM uporabniki WHERE email = '" + email + "'";
                            SQLiteDataReader result = createCommand.ExecuteReader();

                            while (result.Read())
                            {
                                count++;
                            }

                            createCommand.Dispose();
                        }
                        //3.5 success
                        if (count < 1)
                        {
                            using (SQLiteCommand createCommand = new SQLiteCommand(Conn))
                            {
                                try
                                {
                                    createCommand.CommandText = "INSERT INTO uporabniki (username, email, pass, score) VALUES ('" + uime + "','" + email + "','" + pass1 + "', " + yo + ")";
                                    createCommand.ExecuteNonQuery();

                                    MessageBox.Show("Uspešno ste se registrirali!");
                                    createCommand.Dispose();
                                }

                                catch (OverflowException ex)
                                {
                                    MessageBox.Show("Številka je prevelika ali premala " + ex.Message);
                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show("Napaka: " + ex.Message);
                                }

                                this.Hide();
                                Login log = new Login();
                                log.ShowDialog();
                                this.Close();
                            }
                        }
                        //3.5 fail
                        else
                        {
                            MessageBox.Show("Uporabnik z emailu '" + email + "' že obstaja!!! :@");
                        }
                    }
                    //3 fail
                    else
                    {
                        MessageBox.Show("gesla se ne ujemata");
                    }

                    Conn.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.UserTextBox.Text = "";
            this.EmailTextBox.Text = "";
            this.Pass1TextBox.Text = "";
            this.Pass2TextBox.Text = "";
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home log = new Home();
            log.ShowDialog();
            this.Close();
        }

        private void Register_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

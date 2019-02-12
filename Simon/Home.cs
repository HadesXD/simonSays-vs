using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Signup_Button_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Register log = new Register();
            log.ShowDialog();
            this.Close();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
            this.Close();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help log = new Help();
            log.ShowDialog();
            this.Close();
        }

        private void About_Click(object sender, EventArgs e)
        {
            this.Hide();
            About log = new About();
            log.ShowDialog();
            this.Close();
        }

        private void Home_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home log = new Home();
            log.ShowDialog();
            this.Close();
        }

        private void Help_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

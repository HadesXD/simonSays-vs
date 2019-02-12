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
    public partial class High_Score : Form
    {
        public High_Score()
        {
            InitializeComponent();
            SQLiteConnection Conn = new SQLiteConnection("Data Source = database.sqlite");
            SQLiteCommand createCommand = new SQLiteCommand(Conn);

            Conn.Open();
            createCommand.CommandText = "SELECT username, score FROM uporabniki ORDER BY score DESC limit 10";
            SQLiteDataReader result = createCommand.ExecuteReader();
            int i = 0;
            while (result.Read())
            {
                string name = result.GetString(0);
                int score = result.GetInt32(1);
                string kek = score.ToString();
                i++;
                richTextBox1.Text = richTextBox1.Text + "Rank: " + i + "\n" + "User: " + name + "\n" + "Score: " + score + "\n" + "\n";
            }
        }

        private void High_Score_Closed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}

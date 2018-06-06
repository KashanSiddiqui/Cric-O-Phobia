using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Cric_O_Phobia.Properties;

namespace Cric_O_Phobia
{
    public partial class Form2 : Form
    {
        Image bp = Resources.bats;
        Image bb = Resources.ball;
        Image ap = Resources.all;
        public Form2()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser2.ScriptErrorsSuppressed = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            teamBan op = new teamBan();
            this.Close();
            op.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TRODI op = new TRODI();
            this.Close();
            op.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TRT20 s = new TRT20();
            this.Close();
            s.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TRTEST o = new TRTEST();
            this.Close();
            o.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teamPak op = new teamPak();
            this.Close();
            op.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teamInd op = new teamInd();
            this.Close();
            op.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            teamSri op = new teamSri();
            this.Close();
            op.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PRODI op = new PRODI();
            this.Close();
            op.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PRT20 op = new PRT20();
            this.Close();
            op.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PRTEST op = new PRTEST();
            this.Close();
            op.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtplayer_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kashan Siddiqui\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From [Table] where UserName = '" + textBox1.Text + "' and Password ='" + textBox2.Text + "'", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //if (dt.Rows[0][0].ToString() == "1
            MessageBox.Show("Player Added To Your Data Base");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = bp;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = bb;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = ap;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Cricinfo")
            {
                webBrowser1.Navigate("http://www.espncricinfo.com/ci/engine/match/index.html?view=live");
            }
            else if (comboBox2.Text == "CricBuzz")
            {
                webBrowser1.Navigate("http://www.cricbuzz.com/cricket-match/live-scores");
            }
            else if (comboBox2.Text == "NDTV")
            {
                webBrowser1.Navigate("https://sports.ndtv.com/cricket/live-scores");
            }
            else if (comboBox2.Text == "ICC")
            {
                webBrowser1.Navigate("https://www.icc-cricket.com/live-cricket/live");
            }
            else
            {
                MessageBox.Show("Please Select Input");
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox8.Hide();
            if (comboBox3.Text == "ICC-OFFICAL-TICKET")
            {
                webBrowser2.Navigate("https://www.icc-cricket.com/tickets/champions-trophy");
            }
            else if (comboBox3.Text == "PSL TICKETS")
            {
                webBrowser2.Navigate("http://pakistansuperleague.com.pk/pakistan-super-league-psl-tickets/");
            }
            else
            {
                MessageBox.Show("Please Select Input");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}

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
namespace Cric_O_Phobia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kashan Siddiqui\Documents\login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From [Table] where UserName = '" + textBox1.Text + "' and Password ='" + textBox2.Text + "'" , con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
                playSound();

            } 
           else
            {
                MessageBox.Show("Please enter the correct username and password");
            }
        }

        private void playSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "E:\\3rd semester\\SD\\Cric-O-Phobia\\n.wav";
            player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

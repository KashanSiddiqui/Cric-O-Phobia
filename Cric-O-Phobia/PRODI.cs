using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cric_O_Phobia
{
    public partial class PRODI : Form
    {
        public PRODI()
        {
            InitializeComponent();
            fileReaderBat();
            fileReaderBowl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 op = new Form2();
            this.Close();
            op.Show();
        }

        private void fileReaderBat()
        {

            int counter = 0;
            string line;


            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("E:\\3rd semester\\SD\\Cric-O-Phobia\\Filing\\prOdiBat.txt");
            while ((line = file.ReadLine()) != null)
            {

                prOdiBat.AppendText(line + "\n");
                counter++;
            }

            file.Close();

        }
            private void fileReaderBowl()
            {

            int counter = 0;
            string line;


            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("E:\\3rd semester\\SD\\Cric-O-Phobia\\Filing\\prOdiBowl.txt");
            while ((line = file.ReadLine()) != null)
            {

                prOdiBowl.AppendText(line+"\n");
                counter++;
            }

            file.Close();
        }
    }
}

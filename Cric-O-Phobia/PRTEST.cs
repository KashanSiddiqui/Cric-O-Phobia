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
    public partial class PRTEST : Form
    {
        public PRTEST()
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
            System.IO.StreamReader file = new System.IO.StreamReader("E:\\3rd semester\\SD\\Cric-O-Phobia\\Filing\\prTestBat.txt");
            while ((line = file.ReadLine()) != null)
            {

                prTestBat.AppendText(line + "\n");
                counter++;
            }

            file.Close();

        }
        private void fileReaderBowl()
        {

            int counter = 0;
            string line;


            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("E:\\3rd semester\\SD\\Cric-O-Phobia\\Filing\\prTestBowl.txt");
            while ((line = file.ReadLine()) != null)
            {

                prTestBowl.AppendText(line + "\n");
                counter++;
            }

            file.Close();
        }
    }
}

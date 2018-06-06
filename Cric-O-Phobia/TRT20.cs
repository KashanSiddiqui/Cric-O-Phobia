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
    public partial class TRT20 : Form
    {
        public TRT20()
        {
            InitializeComponent();
            fileReader();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 op = new Form2();
            this.Close();
            op.Show();
        }

        private void fileReader()
        {
            for (int i = 1; i < 11; i++)
            {
                trT20NoTextBox.AppendText(i.ToString() + "\n");
            }
            int counter = 0;
            string line;


            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("E:\\3rd semester\\SD\\Cric-O-Phobia\\Filing\\trT20Teams.txt");
            while ((line = file.ReadLine()) != null)
            {
                trT20TextBox.AppendText(line + "\n");
                counter++;
            }

            file.Close();
        }
    }
}

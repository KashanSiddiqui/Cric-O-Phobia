﻿using System;
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
    public partial class TRTEST : Form
    {
        public TRTEST()
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
                trTestNoTextBox.AppendText(i.ToString() + "\n");
            }
            int counter = 0;
            string line;


            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("E:\\3rd semester\\SD\\Cric-O-Phobia\\Filing\\trTestTeams.txt");
            while ((line = file.ReadLine()) != null)
            {
                trTestTextBox.AppendText(line + "\n");
                counter++;
            }

            file.Close();
        }
    }
}

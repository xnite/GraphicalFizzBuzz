using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GraphicalFizzBuzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutTheAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
        }

        private void saveOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] lines = this.output.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            System.IO.StreamWriter file = new System.IO.StreamWriter(Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%") + "\\fizzbuzz.txt");
            foreach ( string line in lines )
            {
                file.WriteLine(line);
            }
            file.Close();
            MessageBox.Show("Output was saved to " + Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%") + "\\fizzbuzz.txt", "FizzBuzz", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void startFizzBuzzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.output.Text = "";
            int i = 1;
            while ( i <= 100)
            {
                if( i % 3 == 0 )
                {
                    if( i % 5 == 0 )
                    {
                        this.output.AppendText("\r\nFIZZBUZZ");
                    }
                    else
                    {
                        this.output.AppendText("\r\nFIZZ");
                    }
                } else
                {
                    if( i % 5 == 0 )
                    {
                        this.output.AppendText("\r\nBUZZ");
                    } else
                    {
                        this.output.AppendText("\r\n" + i);
                    }
                }
                i++;
            }
            this.saveOutputToolStripMenuItem.Enabled = true;
        }
    }
}

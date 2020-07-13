using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Comet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text.Trim();
            string ports = textBox2.Text.Trim();
            Process test = new Process();
            test.StartInfo.FileName = "application.exe";
            test.StartInfo.UseShellExecute = false;
            test.StartInfo.Arguments = "ports "+ip+" "+ports;
            test.StartInfo.RedirectStandardOutput = true;
            test.Start();
            textBox3.Text = test.StandardOutput.ReadToEnd();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

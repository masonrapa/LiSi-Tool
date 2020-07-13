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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string range = textBox1.Text.Trim();
            string port = textBox2.Text.Trim();
            Process test = new Process();
            test.StartInfo.FileName = "application.exe";
            test.StartInfo.UseShellExecute = false;
            test.StartInfo.Arguments = "range "+range+" "+port;
            test.StartInfo.RedirectStandardOutput = true;
            test.Start();
            textBox3.Text = test.StandardOutput.ReadToEnd();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

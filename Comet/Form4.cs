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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ip = textBox1.Text.Trim();
            Process test = new Process();
            test.StartInfo.FileName = "application.exe";
            test.StartInfo.UseShellExecute = false;
            test.StartInfo.Arguments = "kickall "+ip;
            test.StartInfo.RedirectStandardOutput = true;
            test.Start();
            textBox3.Text = test.StandardOutput.ReadToEnd();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Comet
{
    public partial class LiSi_Free : Form
    {
        public LiSi_Free()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximizate_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ButtonMaximizate.Visible = false;
            ButtonRestaurate.Visible = true;
        }

        private void buttonMinimizate_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonRestaurate_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ButtonRestaurate.Visible = false;
            ButtonMaximizate.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2_Click(null, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inicio());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Form3());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Form4());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Form5());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Form6());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Form7());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Form8());
        }
        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Form9());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Form10());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process test = new Process();
            test.StartInfo.FileName = "application.exe";
            test.StartInfo.UseShellExecute = false;
            test.StartInfo.Arguments = "lang spanish";
            test.StartInfo.RedirectStandardOutput = true;
            test.Start();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            {
                Process test = new Process();
                test.StartInfo.FileName = "application.exe";
                test.StartInfo.UseShellExecute = false;
                test.StartInfo.Arguments = "lang french";
                test.StartInfo.RedirectStandardOutput = true;
                test.Start();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            {
                Process test = new Process();
                test.StartInfo.FileName = "application.exe";
                test.StartInfo.UseShellExecute = false;
                test.StartInfo.Arguments = "lang german";
                test.StartInfo.RedirectStandardOutput = true;
                test.Start();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            {
                Process test = new Process();
                test.StartInfo.FileName = "application.exe";
                test.StartInfo.UseShellExecute = false;
                test.StartInfo.Arguments = "lang italian";
                test.StartInfo.RedirectStandardOutput = true;
                test.Start();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            {
                Process test = new Process();
                test.StartInfo.FileName = "application.exe";
                test.StartInfo.UseShellExecute = false;
                test.StartInfo.Arguments = "lang english";
                test.StartInfo.RedirectStandardOutput = true;
                test.Start();
            }
        }
    }
}

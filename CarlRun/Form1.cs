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

namespace CarlRun
{
    public partial class Form1 : Form
    {
        String[] Schlüssel = { "4B794C678CDEC", "55FA17AD12E53", "9BF82398A7B25", "3D2A6C72614E8", "F69EAC2ECA8B8", "BB9FD5AD2373D", "Admin", };
        Point lastPoint;
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure that you want to Close without Activating?", "Important Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Activate_Button_Click(object sender, EventArgs e)
        {
            if (Schlüssel.Contains(KeyBox.Text))
            {
                var Form2 = new Form2();
                Form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error the Serial Key isn't Vaild!");
            }
        }

        private void KeyBox_TextChanged(object sender, EventArgs e)
        {
            KeyBox.PasswordChar = '*';
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            Form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
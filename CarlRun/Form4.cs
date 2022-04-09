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
    public partial class Form4 : Form
    {
        Point lastPoint;
        String KeyGen = "4B794C678CDEC";
        public Form4()
        {
            InitializeComponent();
            GroupKeyCarlRun.Visible = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Minimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
            GroupKeyCarlRun.Visible = true;
        }

        private void SecondKey_Click(object sender, EventArgs e)
        {

        }

        private void CopyKey1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(FirstKey.Text);
        }

        private void CopyKey2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SecondKey.Text);
        }

        private void CopyKey3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dirthKey.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GroupKeyCarlRun.Visible = false;
        }

        private void CopyKey4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fourthKey.Text);
        }

        private void CopyKey5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fithKey.Text);
        }

        private void CopyKey6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sixthKey.Text);
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(firstKey1.Text);
        }

        private void See_Click(object sender, EventArgs e)
        {
            GroupKeyHackGames.Visible = true;
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            GroupKeyHackGames.Visible = false;
        }

        private void Copy2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(secondKey1.Text);
        }

        private void Copy3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dirthKey1.Text);
        }

        private void Copy4_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fourthKey1.Text);
        }

        private void Copy5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(fithKey1.Text);
        }

        private void Copy6_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sixthKey1.Text);
        }
    }
}
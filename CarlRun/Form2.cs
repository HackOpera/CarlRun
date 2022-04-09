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
    public partial class Form2 : Form
    {
        Point lastPoint;
        int nächsteZahl = 0;
        public Form2()
        {
            InitializeComponent();
            TextPage.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("HomePage.html");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            StartPage.Visible = true;
            TextPage.Visible = false;
        }

        private void TextEditor_Click(object sender, EventArgs e)
        {
            TextPage.Visible = true;
        }
        public TextDatei aktuelleTextDatei{
            get { return this.TextFiles.SelectedTab?.Tag as TextDatei; }
        }

        public RichTextBox aktuelleTextBox
        {
            get { return this.aktuelleTextDatei?.textBox; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewFile_Click(NewFile, EventArgs.Empty);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Close_Click(object sender, EventArgs e)
        {

        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                aktuelleTextBox.Text = File.ReadAllText(openFileDialog1.FileName);

                aktuelleTextDatei.alterText = aktuelleTextBox.Text;
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(aktuelleTextBox.Text);

                    aktuelleTextDatei.alterText = aktuelleTextBox.Text;
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktuelleTextBox.Copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktuelleTextBox.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aktuelleTextBox.Paste();
        }
        private void Paste_Click(object sender, EventArgs e)
        {
            aktuelleTextBox.Text = Clipboard.GetText();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(aktuelleTextBox.Text);
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            aktuelleTextDatei.neuerText = aktuelleTextBox.Text;

            if (aktuelleTextDatei.alterText != aktuelleTextDatei.neuerText)
            {
                TextFiles.SelectedTab.Text = "* File " + aktuelleTextDatei.nummer;
            }
            else
            {
                TextFiles.SelectedTab.Text = "File " + aktuelleTextDatei.nummer;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            nächsteZahl = nächsteZahl + 1;

            var neueSeite = new TabPage();
            neueSeite.Text = "File " + nächsteZahl;

            var neueRichTextBox = new RichTextBox();
            neueRichTextBox.Dock = DockStyle.Fill;
            neueRichTextBox.TextChanged += richTextBox_TextChanged;
            neueSeite.Controls.Add(neueRichTextBox);

            var neueTextDatei = new TextDatei();
            neueTextDatei.textBox = neueRichTextBox;
            neueTextDatei.nummer = nächsteZahl;

            neueSeite.Tag = neueTextDatei;

            this.TextFiles.TabPages.Add(neueSeite);

            TextFiles.SelectedTab = neueSeite;
        }

        private void CloseFile_Click(object sender, EventArgs e)
        {
            TextFiles.Controls.Remove(TextFiles.SelectedTab);

            if (TextFiles.TabPages.Count < 1)
            {
                NewFile_Click(NewFile, EventArgs.Empty);
            }
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            aktuelleTextBox.Undo();
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to clear?", "Clear text", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                aktuelleTextBox.Clear();
            }
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void OpenFile_Click_1(object sender, EventArgs e)
        {
                        OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.Title = "Open";
                aktuelleTextBox.Text = File.ReadAllText(openFileDialog1.FileName);

                aktuelleTextDatei.alterText = aktuelleTextBox.Text;
            }
        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TextFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextPage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var Form3 = new Form3();
            Form3.Show();
        }

        private void Paste_Click_1(object sender, EventArgs e)
        {
            aktuelleTextBox.Text = Clipboard.GetText();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Redo_Click(object sender, EventArgs e)
        {
            aktuelleTextBox.Redo();
        }
    }
}

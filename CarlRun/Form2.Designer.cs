
namespace CarlRun
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Switcher = new System.Windows.Forms.Panel();
            this.TextEditor = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.StartPage = new System.Windows.Forms.Panel();
            this.TextPage = new System.Windows.Forms.Panel();
            this.Undo = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.CloseFile = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.Button();
            this.NewFile = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.TextFiles = new System.Windows.Forms.TabControl();
            this.Paste = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.Redo = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.Switcher.SuspendLayout();
            this.StartPage.SuspendLayout();
            this.TextPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Menu.Controls.Add(this.label3);
            this.Menu.Controls.Add(this.button6);
            this.Menu.Controls.Add(this.Minimize);
            this.Menu.Controls.Add(this.Close);
            this.Menu.Location = new System.Drawing.Point(12, 12);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(852, 46);
            this.Menu.TabIndex = 0;
            this.Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            this.Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown);
            this.Menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 29);
            this.button6.TabIndex = 7;
            this.button6.Text = "Owner Control";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Minimize
            // 
            this.Minimize.Location = new System.Drawing.Point(761, 3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(41, 40);
            this.Minimize.TabIndex = 4;
            this.Minimize.Text = "_";
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(808, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(41, 40);
            this.Close.TabIndex = 3;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click_1);
            // 
            // Switcher
            // 
            this.Switcher.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Switcher.Controls.Add(this.TextEditor);
            this.Switcher.Controls.Add(this.Start);
            this.Switcher.Location = new System.Drawing.Point(12, 64);
            this.Switcher.Name = "Switcher";
            this.Switcher.Size = new System.Drawing.Size(127, 404);
            this.Switcher.TabIndex = 1;
            // 
            // TextEditor
            // 
            this.TextEditor.Location = new System.Drawing.Point(3, 70);
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.Size = new System.Drawing.Size(121, 61);
            this.TextEditor.TabIndex = 1;
            this.TextEditor.Text = "Text Editor";
            this.TextEditor.UseVisualStyleBackColor = true;
            this.TextEditor.Click += new System.EventHandler(this.TextEditor_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(3, 3);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(121, 61);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start Page";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // StartPage
            // 
            this.StartPage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.StartPage.Controls.Add(this.TextPage);
            this.StartPage.Controls.Add(this.label2);
            this.StartPage.Controls.Add(this.button1);
            this.StartPage.Controls.Add(this.label1);
            this.StartPage.Location = new System.Drawing.Point(145, 64);
            this.StartPage.Name = "StartPage";
            this.StartPage.Size = new System.Drawing.Size(719, 404);
            this.StartPage.TabIndex = 2;
            // 
            // TextPage
            // 
            this.TextPage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TextPage.Controls.Add(this.Redo);
            this.TextPage.Controls.Add(this.Undo);
            this.TextPage.Controls.Add(this.Clear);
            this.TextPage.Controls.Add(this.CloseFile);
            this.TextPage.Controls.Add(this.OpenFile);
            this.TextPage.Controls.Add(this.NewFile);
            this.TextPage.Controls.Add(this.SaveFile);
            this.TextPage.Controls.Add(this.TextFiles);
            this.TextPage.Controls.Add(this.Paste);
            this.TextPage.Controls.Add(this.Copy);
            this.TextPage.Location = new System.Drawing.Point(0, 0);
            this.TextPage.Name = "TextPage";
            this.TextPage.Size = new System.Drawing.Size(719, 404);
            this.TextPage.TabIndex = 6;
            this.TextPage.Paint += new System.Windows.Forms.PaintEventHandler(this.TextPage_Paint);
            // 
            // Undo
            // 
            this.Undo.Location = new System.Drawing.Point(465, 279);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(116, 50);
            this.Undo.TabIndex = 20;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(587, 279);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(126, 118);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click_1);
            // 
            // CloseFile
            // 
            this.CloseFile.Location = new System.Drawing.Point(234, 279);
            this.CloseFile.Name = "CloseFile";
            this.CloseFile.Size = new System.Drawing.Size(114, 50);
            this.CloseFile.TabIndex = 19;
            this.CloseFile.Text = "Close File";
            this.CloseFile.UseVisualStyleBackColor = true;
            this.CloseFile.Click += new System.EventHandler(this.CloseFile_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(3, 332);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(225, 64);
            this.OpenFile.TabIndex = 12;
            this.OpenFile.Text = "Open File";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click_1);
            // 
            // NewFile
            // 
            this.NewFile.Location = new System.Drawing.Point(3, 279);
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(225, 50);
            this.NewFile.TabIndex = 18;
            this.NewFile.Text = "New File";
            this.NewFile.UseVisualStyleBackColor = true;
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(234, 335);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(114, 61);
            this.SaveFile.TabIndex = 13;
            this.SaveFile.Text = "Save File";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // TextFiles
            // 
            this.TextFiles.Location = new System.Drawing.Point(3, 3);
            this.TextFiles.Name = "TextFiles";
            this.TextFiles.SelectedIndex = 0;
            this.TextFiles.Size = new System.Drawing.Size(710, 270);
            this.TextFiles.TabIndex = 17;
            this.TextFiles.SelectedIndexChanged += new System.EventHandler(this.TextFiles_SelectedIndexChanged);
            // 
            // Paste
            // 
            this.Paste.Location = new System.Drawing.Point(354, 335);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(105, 61);
            this.Paste.TabIndex = 15;
            this.Paste.Text = "Paste";
            this.Paste.UseVisualStyleBackColor = true;
            this.Paste.Click += new System.EventHandler(this.Paste_Click_1);
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(354, 279);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(105, 50);
            this.Copy.TabIndex = 16;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Check out my Site here:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Site";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "So all  are Knowing that I made my own Text Editor but now this Programm has all " +
    "Programms then";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "CarlRun";
            // 
            // Redo
            // 
            this.Redo.Location = new System.Drawing.Point(465, 336);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(116, 61);
            this.Redo.TabIndex = 21;
            this.Redo.Text = "Redo";
            this.Redo.UseVisualStyleBackColor = true;
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(876, 483);
            this.Controls.Add(this.StartPage);
            this.Controls.Add(this.Switcher);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.Switcher.ResumeLayout(false);
            this.StartPage.ResumeLayout(false);
            this.StartPage.PerformLayout();
            this.TextPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel Switcher;
        private System.Windows.Forms.Panel StartPage;
        private System.Windows.Forms.Button TextEditor;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel TextPage;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button CloseFile;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button NewFile;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.TabControl TextFiles;
        private System.Windows.Forms.Button Paste;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Redo;
    }
}
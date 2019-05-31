using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "*.rtf";
            openFileDialog1.Filter = "RTF Files|*.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK &&
                openFileDialog1.FileName.Length > 0)
                richTextBox1.LoadFile(openFileDialog1.FileName);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "*.rtf";
            saveFileDialog1.Filter = "RTF Files|*.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK &&
                saveFileDialog1.FileName.Length > 0)
                richTextBox1.LoadFile(saveFileDialog1.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
                richTextBox1.ClearUndo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
                richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
                richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (richTextBox1.SelectionLength > 0)
                    if (MessageBox.Show("Вставить вместо выделенного текста?", "Вставка", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        richTextBox1.SelectionStart = richTextBox1.SelectionStart + richTextBox1.SelectionLength;
                        richTextBox1.SelectionLength = 0;
                    }
            }
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength == 0)
                richTextBox1.SelectAll();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void цветШрифтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Сoздание новго файла"; 
        }

        private void newToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void openToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void openToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Открыть новый файл";
        }

        private void saveToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void saveToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Сохранить текст";
        }

        private void exitToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Выход";
        }

        private void exitToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void undoToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void undoToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Отменить";
        }

        private void cutToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void cutToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Вырезать";
        }

        private void copyToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void copyToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Копировать";
        }

        private void pasteToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void pasteToolStripMenuItem_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Вставить";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Количество символов: " + richTextBox1.Text.Length;
        }
    }
}

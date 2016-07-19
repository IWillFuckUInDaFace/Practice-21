using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            button1.Enabled = true;
            textBox1.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            button1.Enabled = false;
            textBox1.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            button1.Enabled = true;
            textBox1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            button1.Enabled = true;
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                openFileDialog1.Title = "Выберите файл";
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                textBox1.Text = openFileDialog1.FileName;
            }
            if (radioButton1.Checked == true)
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBox1.Text = fbd.SelectedPath;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Process.Start("explorer.exe", textBox1.Text);
            }
            if (radioButton2.Checked == true)
            {
                Process.Start("iexplore.exe", textBox1.Text);
            }
            if (radioButton3.Checked == true)
            {
                Process.Start("notepad.exe", textBox1.Text);
            }

        }
    }
}

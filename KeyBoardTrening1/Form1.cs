using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyBoardTrening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] time = new int[2];
        string[] array = new string[8];
        int[] err = new int[8];

        private void start()
        {
            array[0] = "Ф";
            array[1] = "Ы";
            array[2] = "В";
            array[3] = "А";
            array[4] = "О";
            array[5] = "Л";
            array[6] = "Д";
            array[7] = "Ж";
            time[0] = 0;
            time[1] = 0;
            Random rnd = new Random();
            toolStripStatusLabel1.Text = "00:00";
            label1.Text = array[rnd.Next(0, 7)];
            label3.Text = array[rnd.Next(0, 7)];
            label4.Text = array[rnd.Next(0, 7)];
            label5.Text = array[rnd.Next(0, 7)];
            textBox1.Text = "";
            listBox1.Items[0] = "Ф - ";
            listBox1.Items[1] = "Ы - ";
            listBox1.Items[2] = "В - ";
            listBox1.Items[3] = "А - ";
            listBox1.Items[4] = "О - ";
            listBox1.Items[5] = "Л - ";
            listBox1.Items[6] = "Д - ";
            listBox1.Items[7] = "Ж - ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            start();
        }

        private void сновоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time[1]++;
            if (time[1] == 61)
            {
                time[1] = 1;
                time[0]++;
            }
            toolStripStatusLabel1.Text = time[0].ToString() + ":" + time[1].ToString();
        }

        private void стартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void паузаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Random rnd = new Random();
            string key = e.KeyChar.ToString().ToUpper();
            
            if (key == label1.Text)
            {
                label2.Text = label1.Text;
                label1.Text = label3.Text;
                label3.Text = label4.Text;
                label4.Text = label5.Text;
                label5.Text = array[rnd.Next(0, 7)];
            }
            else if (label1.Text == "Ф")
            {
                err[0]++;
                listBox1.Items[0] = "Ф - " + (err[0]).ToString();
            }
            else if (label1.Text == "Ы")
            {
                err[1]++;
                listBox1.Items[1] = "Ы - " + (err[1]).ToString();
            }
            else if (label1.Text == "В")
            {
                err[2]++;
                listBox1.Items[2] = "В - " + (err[2]).ToString();
            }
            else if (label1.Text == "А")
            {
                err[3]++;
                listBox1.Items[3] = "А - " + (err[3]).ToString();
            }
            else if (label1.Text == "О")
            {
                err[4]++;
                listBox1.Items[4] = "О - " + (err[4]).ToString();
            }
            else if (label1.Text == "Л")
            {
                err[5]++;
                listBox1.Items[5] = "Л - " + (err[5]).ToString();
            }
            else if (label1.Text == "Д")
            {
                err[6]++;
                listBox1.Items[6] = "Д - " + (err[6]).ToString();
            }
            else if (label1.Text == "Ж")
            {
                err[7]++;
                listBox1.Items[7] = "Ж - " + (err[7]).ToString();
            }
        }
    }
}

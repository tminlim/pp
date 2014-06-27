using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pex_Timer
{
    public partial class Form1 : Form
    {
        int h = DateTime.Now.Hour;
        int m = DateTime.Now.Minute;
        int s = DateTime.Now.Second;

        int i = 0;
        int j = 0;
        int k = 0;

        bool isClicked = false;
        int nTime;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer2.Interval = 1000;
            timer3.Interval = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isClicked = isClicked ? false : true;
            if (isClicked)
            {
                button1.Text = "멈춤";

                if (radioButton1.Checked)
                    timer1.Enabled = true;
                else if (radioButton2.Checked)
                    timer2.Enabled = true;
                else if (radioButton3.Checked)
                {
                    timer3.Enabled = true;
                    nTime = int.Parse(textBox1.Text);
                }

            }
            else
            {
                button1.Text = "확인";

                if (radioButton1.Checked)
                    timer1.Enabled = false;
                else if (radioButton2.Checked)
                    timer2.Enabled = false;
                else if (radioButton3.Checked)
                    timer3.Enabled = false;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if ((m == 59) && (s == 59))
            {
                h++;
                m = 00;
                s = 00;
            }
            else if (s == 59)
            {
                m++;
                s = 00;
            }
            else if (h == 24)
            {
                h = 0;
                m = 00;
                s = 01;
            }
            else
            {
                s++;
            }
            label2.Text = String.Format("{0:00}:{1:00}:{2:00}", h, m, s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "00:00:00";
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if ((j == 59) && (i == 9))
            {
                k++;
                j = 00;
                i = 0;
            }
            else if (i == 9)
            {
                j++;
                i = 0;
            }
            else
            {
                i++;
            }
            label2.Text = String.Format("{0:00}:{1:00}:{2}", k, j, i); 
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            int nCnt = nTime % 10;
            int nSnd = (nTime / 10) % 60;
            int nMin = (nTime / 10 / 60) % 60;

            if ((nSnd == 00) && (nCnt == 0))
            {
                nMin--;
                nSnd = 59;
                nCnt = 9;
            }
            else if (nCnt == 0)
            {
                nSnd--;
                nCnt = 9;
            }
            else
                nCnt--;
            string t = String.Format("{0:00}:{1:00}:{2}", nMin, nSnd, nCnt);
            label2.Text = t;
            nTime--;

        }

    }
}

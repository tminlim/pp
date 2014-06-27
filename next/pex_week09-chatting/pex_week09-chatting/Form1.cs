using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pex_week09_chatting
{
    public partial class Form1 : Form
    {
        bool isFirst = true; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isChecked = radioButton1.Checked;
            string person = "";
            
            if (isChecked)
                person = radioButton1.Text;
            else
                person = radioButton2.Text;


            if (isFirst)
            {
                textBox1.Text +=person + ":" + textBox2.Text;
                textBox2.Text = "";
                isFirst = false;
            }
            else
            {
                textBox1.Text += "\r\n" + person + ":" + textBox2.Text;
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
            isFirst = true;
        }

    }
}

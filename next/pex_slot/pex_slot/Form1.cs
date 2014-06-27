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


namespace pex_slot
{
    public partial class Form1 : Form
    {
        string[] doing = {"점심 먹", "코딩하", "세수하", "커피 마시", "물 마시", "콜라 마시", "교수님께 찾아가", "한컴 가", "라면 먹", "버스 타", "화분에 물주", "음악 듣"};
        bool isClick = false;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 30;
            timer2.Interval = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isClick = isClick ? false : true;
            Random r = new Random();
            int i = r.Next(0,11);

            if (isClick){
                timer1.Enabled = true;
                timer2.Enabled = true;
                button1.Text = "STOP";
                label1.Text = " □□ 하기!";


            }else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                button1.Text = "Just";
                label1.Text = doing[i] + "기";
            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            string dir = Directory.GetCurrentDirectory();
            //Console.WriteLine(dir);

                int nFstPic = r.Next(1, 12);

                switch (nFstPic)
                {
                   case 1:
                        pictureBox1.Image = Image.FromFile(dir + "\\" + "P1.png");
                     break;
                   case 2:
                     pictureBox1.Image = Image.FromFile(dir + "\\" +"P2.png");
                     break;
                   case 3:
                     pictureBox1.Image = Image.FromFile(dir + "\\" + "P3.png");
                     break;
                   case 4:
                     pictureBox1.Image = Image.FromFile(dir + "\\" + "P4.png");
                     break;
                   case 5:
                     pictureBox1.Image = Image.FromFile(dir + "\\" + "P5.png");
                     break;
                   case 6:
                     pictureBox1.Image = Image.FromFile(dir + "\\" + "P6.png");
                     break;
                   case 7:
                     pictureBox1.Image = Image.FromFile(dir + "\\" + "P7.png");
                     break;
                   case 8:
                     pictureBox1.Image = Image.FromFile(dir + "\\" + "P8.png");
                     break;
                   case 9:
                     pictureBox1.Image = Image.FromFile(dir + "\\" + "P9.png");
                     break;
                   case 10:
                     pictureBox1.Image = Image.FromFile(dir + "\\" + "P10.png");
                     break;
                   case 11:
                     pictureBox1.Image = Image.FromFile(dir + "\\" + "P11.png");
                     break;
                   case 12:
                     pictureBox1.Image = Image.FromFile(dir + "\\" + "P12.png");
                     break;
                }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            string dir = Directory.GetCurrentDirectory();
            //Console.WriteLine(dir);
                int nSndPic = r.Next(1, 12);

                switch (nSndPic)
                {
                    case 1:
                        pictureBox2.Image = Image.FromFile(dir + "\\" + "S1.png");
                        break;
                    case 2:
                        pictureBox2.Image = Image.FromFile(dir + "\\" + "S2.png");
                        break;
                    case 3:
                        pictureBox2.Image = Image.FromFile(dir + "\\" + "S3.png");
                        break;
                    case 4:
                        pictureBox2.Image = Image.FromFile(dir + "\\" + "S4.png");
                        break;
                    case 5:
                        pictureBox2.Image = Image.FromFile(dir + "\\" + "S5.png");
                        break;
                    case 6:
                        pictureBox2.Image = Image.FromFile(dir + "\\" + "S6.png");
                        break;
                    case 7:
                        pictureBox2.Image = Image.FromFile(dir + "\\" + "S7.png");
                        break;
                    case 8:
                        pictureBox2.Image = Image.FromFile(dir + "\\" + "S8.png");
                        break;
                    case 9:
                        pictureBox2.Image = Image.FromFile(dir + "\\" + "S9.png");
                        break;
                    case 10:
                        pictureBox2.Image = Image.FromFile(dir + "\\" + "S10.png");
                        break;
                    case 11:
                        pictureBox2.Image = Image.FromFile(dir + "\\" + "S11.png");
                        break;
                    case 12:
                        pictureBox2.Image = Image.FromFile(dir + "\\" + "S12.png");
                        break;
                }
        }
    }
}

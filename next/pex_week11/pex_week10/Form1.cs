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
using System.Xml.Serialization;

namespace pex_week10
{
    public partial class Form1 : Form
    {
        phoneBook pb;
        phoneData pData;
        public Form1()
        {
            InitializeComponent();
            pb = new phoneBook();
            //pData = new phoneData();
            //pb.Add("tmin", "none", "next");
            //pb.Add("eun", "010 - 0000 - 0000", "mv");
            saveFileDialog1.Filter = "저장파일(*.xml)|*.xml|모든파일(*.*)|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK))
                return;
            XmlSerializer xs = new XmlSerializer(typeof(phoneBook));
            StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding("euc-kr"));
            pb = (phoneBook)xs.Deserialize(sr);
            sr.Close();
            
            textBox1.Text = pb.getAllData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string fullText = textBox1.Text;
            string[] separator = {"\r\n"};
            string[] separateT = fullText.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            string[] separators = { " ", "|", " | " };
            
            for (int i = 0; i < separateT.Length; i++)
            {
                string[] separatedText = separateT[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                pb.Add(separatedText[0], separatedText[1], separatedText[2]);

            }
            
            if (!(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK))
                return;
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false, Encoding.GetEncoding("euc-kr"));
           
            XmlSerializer xs = new XmlSerializer(typeof(phoneBook));
            xs.Serialize(sw, pb);
            sw.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "편집중";
        }



    }
}

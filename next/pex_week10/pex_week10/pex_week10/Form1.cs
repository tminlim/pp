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

namespace pex_week10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string shown = "";

            toolStripStatusLabel1.Text = openToolStripMenuItem.Text;

            openFileDialog1.Filter = "text file(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                while (!(sr.EndOfStream))
                {
                    string lineBy = sr.ReadLine();
                    shown += lineBy + "\r\n";
                }
                sr.Close();
            }
            textBox1.Text = shown;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = saveAsToolStripMenuItem.Text;
            saveFileDialog1.Filter = "text file(*.txt)|*.txt|All files(*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName, false);
                sw.WriteLine(textBox1.Text);
                sw.Close();
            }
        }

    }
}

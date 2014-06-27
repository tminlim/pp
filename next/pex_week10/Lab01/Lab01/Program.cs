using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab01
{
    class FileRead
    {
        public void ReadAndPrint(string fileName)
        {
            string dir = Directory.GetCurrentDirectory();
            string fName = dir + "\\" + fileName;

            StreamReader sr = new StreamReader(fName, Encoding.GetEncoding("euc-kr"));
            int n = 0;
            while (!(sr.EndOfStream))
            {
                n++;
                string line = sr.ReadLine();
                Console.WriteLine("{0:00}:{1}", n, line);
            }
        }
        static void Main(string[] args)
        {
            FileRead fr = new FileRead();
            fr.ReadAndPrint("sevenbit.txt");
        }
    }
}

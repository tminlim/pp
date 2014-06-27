using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab02
{
    class FileRead
    {
        public void WriteSomething(string fileName, string endStr, bool append)
        {
            string dir = Directory.GetCurrentDirectory();
            string fName = dir + "\\" + fileName;
            StreamWriter sw = new StreamWriter(fName, append, Encoding.GetEncoding("euc-kr"));
            string inputStr = "";

            while (true)
            {
                Console.Write("input line : ");
                inputStr = Console.ReadLine();
                if (inputStr == endStr)
                    break;
                sw.WriteLine(inputStr);
            }
            sw.Close();
        }

        static void Main(string[] args)
        {
            FileRead fr = new FileRead();
            fr.WriteSomething("draw.txt","color", true);
        }
    }
}

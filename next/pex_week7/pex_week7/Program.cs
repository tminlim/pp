using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7
{
    class lotto
    {
        public static void Shuffle(List<int> list)
        {
            Random r = new Random();
            for (int nChanged = list.Count; nChanged > 0; nChanged--)
            {
                int nChange = r.Next(1, nChanged);
                Swap(nChange, list, nChanged);
            }
        }
        public static void Swap(int nChange, List<int> list, int nChanged)
        {
            int fstNum = list.ElementAt(nChange -1);
            int tmp = fstNum;

            int sndNum = list.ElementAt(nChanged -1);
            list.RemoveAt(nChange - 1);
            list.Insert(nChange - 1, sndNum);

            list.RemoveAt(nChanged - 1);
            list.Insert(nChanged - 1, tmp);
        }
        static void Main(string[] args)
        {
            List<int> allNums = new List<int>();
            for (int i = 1; i <= 45; i++)
            {
                allNums.Add(i);
            }

            //lotto l = new lotto();
            Shuffle(allNums);

            Console.WriteLine("wanna win the lotto? insert into numbers! ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < num; i++){
                Console.Write("{0} ", allNums[i]);
            }

        }
    }
}

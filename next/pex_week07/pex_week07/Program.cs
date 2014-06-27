using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week07
{
    class lotto
    {
        public void Shuffle(List<int> list)
        {
            Random r = new Random();
            for (int nChanged = list.Count; nChanged < -1; nChanged--)
            {
                int nChange = r.Next(0, nChanged);
                Swap(nChange, list, nChanged);
            }
        }
        public void Swap(int nChange, List<int> list, int nChanged)
        {
            int fstNum = list.ElementAt(nChange);
            int tmp = fstNum;

            int sndNum = list.ElementAt(nChanged);

            list.Insert(nChange - 1, sndNum);
            list.Insert(nChanged - 1, tmp);
        }
        static void M()
        {
            List<int> allNums = new List<int>();
            for (int i = 1; i <= 45; i++)
            {
                allNums.Add(i);
            }

            lotto l = new lotto();
            l.Shuffle(allNums);

            Console.WriteLine("wanna win the lotto? insert into numbers! ");
            int num = Convert.ToInt32(Console.ReadLine());

            //for(int i = 0; i < num; i++){
            //Console.Write(num);
            //}

        }
    }
}

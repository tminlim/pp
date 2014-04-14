using System;

namespace weeks04_ex
{
	public class lab02
	{
		public static int readInt(string msg){
			Console.WriteLine (msg +"?");
			int number = int.Parse(Console.ReadLine());
			return number;
		}

		public static void Main(string[] args){
			int fstNum = readInt("raw");
			int sndNum = readInt("column");

			for(int i = 0; i < fstNum; i++){
				for (int ci = 0; ci < sndNum; ci++) {
					Console.Write (" {0}{1} ", i, ci);
				}
				Console.WriteLine();
			}

		}
	}
}


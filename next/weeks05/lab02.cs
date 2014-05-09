using System;

namespace weeks05
{
	public class lab02
	{
//		public static int readInt(string msg){
//			Console.WriteLine (msg +"?");
//			int number = int.Parse(Console.ReadLine());
//			return number;
//		}
//
//		public static void Main(string[] args){
//			int fstNum = readInt("raw");
//			int sndNum = readInt("column");
//
//			for(int i = 0; i < fstNum; i++){
//				for (int ci = 0; ci < sndNum; ci++) {
//					Console.Write (" {0}{1} ", i, ci);
//				}
//				Console.WriteLine();
//			}
//
//		}
		public static void saveInt(string msg, out int row, out int column){
			Console.WriteLine (msg + "?");
			string [] strNumbers = Console.ReadLine().Split();
			row = int.Parse(strNumbers[0]);
			column = int.Parse(strNumbers[1]);
		}

		public static void Main(string[] args){
			int row, column;
			saveInt ("input 2 numbers ", out row, out column);
			int[,] arr = new int[row , column];


			for (int i = 0; i < arr.GetLength(0); i++) {
				for (int ci = 0; ci < arr.GetLength(1); ci++) {
					Console.Write ("{0}{1} ", i , ci);
				}
				Console.WriteLine ();
			}
		}
	}
}


using System;
namespace weeks05{
	class ExtinctArr{
		static string s = " * ";

		public static int ReadInt(string msg){
			Console.WriteLine (msg);
			int number = Convert.ToInt32 (Console.ReadLine());
			return number;
		}

		public static string[,] PrintInt(int size){
			string[,] arr = new string[size, size];
			for (int i = 0; i < size; i++) {
				for (int j = 0; j < size; j++) {
					arr [i, j] = s;
					Console.Write (arr [i, j]);
				}
				Console.WriteLine ();
			}
			return arr;
		}

		public static void ShowArr(string[,] arr, int size){
			for (int i = 0; i < size; i++) {
				for (int j = 0; j < size; j++) {
					Console.Write(arr[i,j]);
				}
				Console.WriteLine ();
			}
		}
			
		public static void DeletedEle(int size, int row, int column, string[,] arr){
			string blank = "   ";

			if(row > size - 1 || column > size - 1) {
					Console.WriteLine ("select number not exceeding size");
				} else if (arr[row, column] == "   ") {
					Console.WriteLine ("already done!!!");
				} else {
					arr [row, column] = blank;
					arr [column, row] = blank;
				}
			}
		}

	class Test{
		public static void Main(string[] args){
			int size = ExtinctArr.ReadInt ("input odd number");
			string[,] arr = ExtinctArr.PrintInt (size);

			bool repeat = true;
			while (repeat) {
				Console.WriteLine("input deleted position");
				string[] strNumber = Console.ReadLine().Split();
				int row = int.Parse(strNumber[0]);
				int column = int.Parse(strNumber[1]);

				if (row < 0 || column < 0) {
					Console.WriteLine ("negative integer! End");
					repeat = false;
				} else {
					ExtinctArr.DeletedEle (size, row, column, arr);
					ExtinctArr.ShowArr (arr, size);
				}
			}
		}
	}
}
using System;

namespace weeks04_ex
{
	public class ex_lab01
	{
		public static string[] ReadStr(string msg){
			Console.WriteLine(msg);
			string[] number = Console.ReadLine().Split();
			return number;
		}

		public static void Arrange(string[] numbers){
			int row = int.Parse(numbers[0]);
			int column = int.Parse(numbers[1]);

			for (var i = 1; i <= row; i++){
				for (var j = 1; j <= column; j++) {
					Console.Write(" " + i * j + " ");
				}
				Console.WriteLine();
			}		
		}
		public static void Main(string[] args){
			string[] numbers = ReadStr ("input row n column numbers");
			Arrange (numbers);
		}
	}
}


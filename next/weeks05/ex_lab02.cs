using System;
namespace weeks05{
	class PrintArr{
		public static int ReadInt(string msg){
			Console.WriteLine (msg);
			int number = int.Parse(Console.ReadLine());
			return number;
		}
		public static void SharpStar(int number){
			string s = "*";
			string sh = "#";
			int row = number + 1;

			for(int i = 0; i < row; i++){
				int j;
				for (j = 0; j < i; j++)
					Console.Write (sh);
				for (int k = number - j ; k > 0; k--) 
					Console.Write (s);
			Console.WriteLine ();
			}
		}	
	}
	class Test{
		static void Main(string[] args){
			int number = PrintArr.ReadInt ("input number ");
			PrintArr.SharpStar(number);
			int number02 = PrintArr.ReadInt ("input number ");
			PrintArr.SharpStar(number02);
		}
	}
}

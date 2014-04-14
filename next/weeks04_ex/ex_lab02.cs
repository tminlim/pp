using System;
namespace weeks04_ex{
	class PrintArr{
		public static int ReadInt(string msg){
			Console.WriteLine (msg);
			int number = int.Parse(Console.ReadLine());
			return number;
		}
		publc static void SharpStar(int number){
			int i = 1;
			int row = number + 1;
			for(i = 1; i <= row; i ++){
			}
		}
	
	}
	class Test{
		static void Main(string[] args){
			int number = PrintArr.ReadInt ("input some number ");
		}
	}
}

using System;

namespace weeks05
{

	class lab03
	{
		public static int readInt(){
			Console.WriteLine("input number ");
			int number = Convert.ToInt32 (Console.ReadLine ());
			return number;
		}

		public static void Main(string[] args){
			int size = readInt();
			string blank = "   ";
			string s = " * ";

			for(var i = 1; i <= size; i++ ){
				for(int bi = 0; bi <  size - i; bi++){
					Console.Write (blank);
				}
				for(int si = 1; si <= i * 2 -1; si++){
					Console.Write (s);
				}
				Console.WriteLine ();
			}
		}
	}
}

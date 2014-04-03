using System;

namespace weeks04
{
	public class ex05
	{
		static void Main(String[] args){
			String s = "*";
			Console.WriteLine ("input number");
			String num = Console.ReadLine ();
			int input_num = Convert.ToInt32 (num);

			if (input_num <= 0) {
				Console.WriteLine ("smaller than 0");
			} else {
				for (int i = 1; i <= input_num; i++) {
					for (int j = 1; j <= i; j++) {
						Console.Write ("{0}", s);
					}
					Console.WriteLine ();
				}
			}


//			const int NUM = 5;
//			Console.WriteLine ();
		}
	}
}


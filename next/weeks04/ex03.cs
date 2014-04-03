using System;

namespace weeks04
{
	public class ex03
	{
		static void Main(String[] args){
			String s = "*";
			const int NUM = 5;

//			for (int i = NUM; i >= 1; i--) {
//				for (int j = 1; j <= i; j++) {
//					Console.Write ("{0}", s);
//				}
//				Console.WriteLine ();
//			}
			int i = 1;

			do {
				int j = 1;
				while (j <= i) {
					Console.Write ("{0}", s);
					j++;
				}
				Console.WriteLine ();
				i++;
			} while (i <= NUM); 

		}
	}
}


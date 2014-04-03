using System;

namespace weeks04
{
	public class ex04
	{
		static void Main(String[] args){
			String s = "*";
			const int NUM = 5;

			int i = 5;

			do {
				int j = 1;
				while (j <= i) {
					Console.Write ("{0}", s);
					j++;
				}
				Console.WriteLine ();
				i--;
			} while (i >=1 );
	}
}
}


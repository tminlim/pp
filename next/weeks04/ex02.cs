using System;

namespace weeks04
{
	public class ex02
	{
		static void Main(String[] args){
			String s = "*";
			const int NUM = 5;

			for (int i = NUM; i >= 1; i--) {
				for (int j = 1; j <= i; j++) {
					Console.Write ("{0}", s);
				}
				Console.WriteLine ();
			}
		}
	}
}


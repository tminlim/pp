using System;

namespace weeks04
{
	class ex01
	{
		static void Main (String[] args)
		{
			String s = "*";
			const int NUM = 5;

			for (int i = 1; i <= NUM; i++) {
				for (int j = 1; j <= i; j++) {
					Console.Write ("{0}", s);
				}
				Console.WriteLine ();
			}
		}

	}
}

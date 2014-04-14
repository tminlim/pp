using System;

namespace weeks04
{
	public class ex06
	{
		static void Main(String[] args){
			String blank = " ";
			String s = "*";

			Console.WriteLine ("type num: ");
			int NUM = Convert.ToInt32(Console.ReadLine ());

			for(int i = 1; i <= NUM/2+1 ; i++ ) {

				for (int b = (NUM/2)+1-i ; b > 0; b--) {
					Console.Write (blank);
				}

				for (int b = 1; b <= i * 2 -1; b++){
					Console.Write(s);
				}
				Console.WriteLine();
				}

		
		}
	}
}


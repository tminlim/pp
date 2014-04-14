using System;

namespace weeks04
{
	public class ex08
	{
		public void Line(){
			int x = Convert.ToInt32 (Console.ReadLine());
			for(int i = 0; i <= x; i++)
				Console.WriteLine ("_______________________");
	}
		static void Main(string[] args){
			Console.WriteLine ("num line? ");
			Line ();
			Console.WriteLine ("second num line? ");
			Line ();
			Console.WriteLine ("end");
	}
}


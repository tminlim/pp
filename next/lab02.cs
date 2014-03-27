using System;

namespace next
{
	public class lab02
	{
		static void Main(String[] args)
		{
			Console.WriteLine("name?");
			String name = Console.ReadLine ();

			Console.WriteLine("width?");
			String w = Console.ReadLine();
			double width = Convert.ToInt32 (w);

			Console.WriteLine("height?");
			String h = Console.ReadLine ();
			double height = Convert.ToInt32 (h);

			double extent = (width * height) / 2;

			Console.WriteLine ("extent of {0} is {1} " , name , extent);
		}
	}
}


using System;

namespace next
{
	public class Circle{
		public int x, y, r;
	}

	class CircleTest{
		static void Main(String[] args){
			Circle o1 = new Circle();
			String tempstr;

			Console.WriteLine("");
			Console.Write ("circle1 x? ");
			tempstr = Console.ReadLine ();
			o1.x = Convert.ToInt32 (tempstr);
			Console.WriteLine ("circle1 y? ");
			o1.y = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("circle r? ");
			o1.r = Convert.ToInt32 (Console.ReadLine ());

			Circle o2 = new Circle();

			Console.WriteLine("");
			Console.Write ("circle2 x? ");
			o2.x = Convert.ToInt32 (Console.ReadLine());
			Console.WriteLine ("circle2 y? ");
			o2.y = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("circle2 r? ");
			o2.r = Convert.ToInt32 (Console.ReadLine ());

			int totalR = (o1.r + o2.r) * 2;

			if (Math.Pow(o1.x - o2.x, 2) + Math.Pow(o1.y - o2.y, 2) > totalR) {
				Console.WriteLine ("peaceful circles!");
			} else {
				Console.WriteLine ("smash circles!");
			}

		}
	}


}


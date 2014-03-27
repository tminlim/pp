using System;

namespace next
{
	public class Student{
		public String name;
		public int kr;
		public int math;
		public double avg;
	}
	class Test {
		static void Main(String[] args) {
			Student s1 = new Student ();
			Student s2 = new Student ();
			s1.name = "min";
			s1.kr = 80;
			s1.math = 90;
			s1.avg = Convert.ToDouble(s1.kr + s1.math) / 2;

			s2.name = "heon";
			s2.kr = 100;
			s2.math = 45;
			s2.avg = Convert.ToDouble(s2.kr + s2.math) / 2;

			double tavg = (s1.avg + s2.avg) / 2;

			Console.WriteLine ("avg of {0} is {1}", s1.name, s1.avg);
			Console.WriteLine ("avg of {0} is {1}", s2.name, s2.avg);
			Console.WriteLine ("total avg of {0} n {1} is {2}", s1.name, s2.name, tavg);
		}
	}
}


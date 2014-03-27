using System;

namespace next
{
	public class lab01
	{
		static void Main(String[] args){

		double kr01, kr02, math01, math02;
		String name01, name02;
		double avg01, avg02, totalavg;

		name01 = "tmin";
		kr01 = 80;
		math01 = 90;
		avg01 = (kr01 + math01)/2;

		name02 = "eun";
		kr02 = 88;
		math02 = 60;
		avg02 = (kr02 + math02)/2;

		totalavg = (avg01 + avg02)/2;

		Console.WriteLine ("avg of {0} : {1}", name01, avg01);
		Console.WriteLine ("avg of {0} : {1}", name02, avg02);
		Console.WriteLine ("the avg of {0} & {1} is {2}", avg01, avg02, totalavg);
		}
	}
}


using System;

namespace weeks04
{
	public class ex07
	{
		static void Main (String[] args)
		{
			const int SIZE = 1;

			Console.WriteLine ("input array size");
			int arrSize = Convert.ToInt32(Console.ReadLine());
			
				int[,] arr01 = new int[arrSize, arrSize];

				for( int i = 0; i < arrSize; i++) { 
					for(int j = 0; j < arrSize; j++) {
						arr01[i, j] = SIZE;
					Console.Write(arr01[i,j]);
					}
				Console.WriteLine ();
				}

		}
	}
}


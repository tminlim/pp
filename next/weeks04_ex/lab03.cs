using System;

namespace weeks04_ex
{
	public class lab03
	{	

		public static int readInt(string msg){
			Console.Write(msg);
			int number = int.Parse (Console.ReadLine());
			return number;
		}
		public static void readArr(string msg, int number){

				Console.WriteLine (msg + "( {0} * {1} )", number, number);
		}
		public static int[,] arrange(int size){
			int[,] array;
			array = new int[size, size];
			for(int i = 0; i < size; i ++){
				for (int j = 0; j < size; j++) {
					Console.Write ("{0}{1} ?",i , j);
					array[i,j] = int.Parse (Console.ReadLine());
				}
			}
			Console.WriteLine ();
			return array;
		}	
		public static void print(int[,] array, int number){
			for (int i = 0; i < number; i++) {
				Console.Write (" | ");
				for (int j = 0; j < number; j++) {
					Console.Write (" {0} ", array [i, j]);
				}
				Console.Write (" | ");
				Console.WriteLine ();
			}
			Console.WriteLine ();
		}

		public static void sum(int[,] array01, int[,] array02, int number){
			for (int i = 0; i < number; i++) {
				Console.Write (" | ");
				for (int j = 0; j < number; j++) {
					Console.Write (" {0} ", array01[i,j] + array02[i,j]);
				}
				Console.Write(" | ");
				Console.WriteLine();
			}
			Console.WriteLine ();
		} 

		public static void Main(string[] args){
			int number = readInt ("input array01 size? ");
			readArr ("input array01 ", number);
			int[,]array01	=arrange (number);
			print(array01, number);

			int number02 = readInt ("input array02 size? ");
			readArr ("input array02 ", number02);
			int[,]array02 = arrange (number02);
			print (array02, number02);
			sum (array01, array02, number);

		}


	}
}


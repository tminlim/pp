using System;

namespace weeks04_ex
{
	public class lab04
	{
		public static int[] ReadInts(string msg){
			Console.WriteLine (msg);
			string strArr = Console.ReadLine();
			string[] arrEle = strArr.Split(' ');

			int size = arrEle.Length;
			int[] arr = new int[size];
			for (int i = 0; i < size; i++) {
				arr[i] = Convert.ToInt32(arrEle[i]);
			}
			return arr;
		}
	}

	class Test {
		static void Main(string[] args){
			int[] arr = lab04.ReadInts("input test numbers ");
			foreach (int i in arr)
				Console.Write (i + " ");
		}
	}
}



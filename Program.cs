using System;

namespace MyBubbleSorting
{
	class Mixed
	{

		static void Main()
		{
			int[] unsortedArray = new int[7]; 
			Console.WriteLine ("Shemoiyvanet ricxvebi, daachiret -1 sheyvanis dasamtavreblad");
			for(int lll = 0; lll < unsortedArray.Length; lll++)
			{
				unsortedArray[lll] = Convert.ToInt32(Console.ReadLine());
				if(unsortedArray[lll] == -1)
				{
					break;
				}
			}
			Console.WriteLine ("UNSORTED");
			for(int iii = 0; iii < unsortedArray.Length; iii++ )
			{
				Console.WriteLine (unsortedArray[iii]);
			}
			Console.WriteLine ("_______SORTED______");

			int[] bubbleSortedArray = BubbleSort (unsortedArray);
			for(int kkk = 0; kkk < bubbleSortedArray.Length; kkk++)
			{
				Console.WriteLine(bubbleSortedArray[kkk]);
			}
		}

		private static int[] BubbleSort(int[] unsortedArray)
		{
			int length = unsortedArray.Length;
			//Console.WriteLine (length);
			for(int iii = 0; iii < length-1; iii++) // u[0] = 12
			{
				for(int jjj = 0; jjj < length -1 - iii; jjj++) // ro chamoiwiios
				{
					//Console.WriteLine ("{0}  -  {1}",unsortedArray[iii],unsortedArray[jjj]);
					if( unsortedArray[jjj] > unsortedArray[jjj + 1] ) // if 12 > 4
					{
						// Swap Places
						int num = unsortedArray[jjj]; // num =  12
						unsortedArray [jjj] = unsortedArray [jjj + 1]; // un[1] = 4
						unsortedArray[jjj + 1] = num; /// un[2] = 12
					}
				}
			}
			return unsortedArray;
		}

	}
}

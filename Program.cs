// See https://aka.ms/new-console-template for more information
class Program {
	static void Main(string[] args) {
		int[] arr_unsorted = new int[] { 7, 1, 0, 8, 9, 2, 5, 10, 9, 2 };
		int[] arr_sorted_compare = new int[arr_unsorted.Length];
		int[] arr_sorted = new int[arr_unsorted.Length];

		Array.Copy(arr_unsorted, arr_sorted_compare, arr_unsorted.Length);
		Array.Copy(arr_unsorted, arr_sorted, arr_unsorted.Length);

		Array.Sort(arr_sorted_compare);

		Console.WriteLine("Ожидается:");
		PrintArray(arr_sorted_compare);

		Sort(arr_sorted);
		Console.WriteLine("Получено:");
		PrintArray(arr_sorted);
	}

	static void Sort(int[] arr) 
	{
		quicksort(arr, 0, arr.Length - 1);
	}
	
	 static int partition (int[] array, int start, int end) 
   {
       int temp;
       int marker = start;
       for ( int i = start; i < end; i++ ) 
       {
           if ( array[i] < array[end] )
           {
               temp = array[marker];
               array[marker] = array[i];
               array[i] = temp;
               marker += 1;
           }
       }
   
       temp = array[marker];
       array[marker] = array[end];
       array[end] = temp; 
       return marker;
   }

   static void quicksort (int[] array, int start, int end)
   {
       if ( start >= end ) 
       {
           return;
       }
       int pivot = partition (array, start, end);
       quicksort (array, start, pivot-1);
       quicksort (array, pivot+1, end);
   }

	static void PrintArray(int[] arr) {
		foreach(int el in arr) {
			Console.Write(el + " ");
		}
		Console.Write('\n');
	}
}

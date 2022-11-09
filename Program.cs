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

	static void Sort(int[] arr) {

	}

	static void PrintArray(int[] arr) {
		foreach(int el in arr) {
			Console.Write(el + " ");
		}
		Console.Write('\n');
	}
}

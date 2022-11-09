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
        sort(arr, 0, arr.Length - 1);
	}

    static void merge(int[] arr, int l, int m, int r)
    {
        int n1 = m - l + 1;
        int n2 = r - m;

        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        for (i = 0; i < n1; ++i)
            L[i] = arr[l + i];
        for (j = 0; j < n2; ++j)
            R[j] = arr[m + 1 + j];


        i = 0;
        j = 0;

        int k = l;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }

    static void sort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;

            sort(arr, l, m);
            sort(arr, m + 1, r);

            merge(arr, l, m, r);
        }
    }

    static void PrintArray(int[] arr) {
		foreach(int el in arr) {
			Console.Write(el + " ");
		}
		Console.Write('\n');
	}
}

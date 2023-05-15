namespace Interface_Sort
{
    public class Bubble_Sort : Isorts
    {
        public void sort()

        {
            Bubble_Sort BS = new Bubble_Sort();

            int[] arr = new int[50];

            int n;

            Console.WriteLine("Enter number of element");

            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("inter element in an array");

            for (int i = 1; i <= n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            BS.bubblesort(arr, n);
            Console.ReadKey();
        }
        public void bubblesort(int[] arr, int n)
        {
            int temp;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }
            Console.WriteLine("Array after sorting");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }

    }
}


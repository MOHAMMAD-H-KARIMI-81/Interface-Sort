namespace Interface_Sort
{

    public class Iterative_Sort : Isorts
    {
        public void sort()
        {
            int[] arr = new int[] { 1, 65, 43, 87, 980, 43, 98, 34 };
            int temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                    foreach (int value in arr)
                    {
                        Console.WriteLine(value + " ");
                    }
                }
            }
        }
    }
}

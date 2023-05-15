namespace Interface_Sort
{
    public class InsertionSort : Isorts
    {
        public void sort()
        {
            Console.WriteLine("Enter number of element");

            int max = Convert.ToInt32(Console.ReadLine());
            int[] numarray = new int[max];
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("Enter [" + (i + 1).ToString() + "] element:  ");
                numarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Input int array :");
            for (int k = 0; k < max; k++)
                Console.WriteLine(numarray[k] + " ");

            for (int i = 1; i < max; i++)
            {
                int j = i;
                while (j > 0)
                {
                    if (numarray[j - 1] > numarray[j])
                    {
                        int temp = numarray[j - 1];
                        numarray[j - 1] = numarray[j];
                        numarray[j] = temp;
                        j--;
                    }
                    else
                        break;
                }
                Console.WriteLine("Iteration" + i.ToString() + ":");
                for (int k = 0; k < max; k++)
                    Console.WriteLine(numarray[k] + " ");

            }
            Console.WriteLine("The numbers in ascending orders are given below:");
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("Sorted [" + (i + 1).ToString() + "] element : ");
                Console.WriteLine(numarray[i]);

            }



        }
    }
}

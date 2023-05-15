


using Interface_Sort;

Bubble_Sort sort = new Bubble_Sort();
Iterative_Sort sort1 = new Iterative_Sort();
InsertionSort sort2 = new InsertionSort();

Isorts Sorts ; 


Console.WriteLine("ENTER 0 - 2 FOR SORT (0 =  Iterative_Sort __ 1 = Bubble_Sort __ 2 = InsertionSort");


while (true)
{
    int x = Convert.ToInt32(Console.ReadLine());

    switch (x)
    {
        case 0:
            sort1.sort();
            break;
        case 1:
            sort.sort();
            break;
        case 2:
            sort2.sort();
             break;

    }
    
}

//Sorts = new Bubble_Sort();
//Sorts = new Iterative_Sort();
//Sorts = new InsertionSort();
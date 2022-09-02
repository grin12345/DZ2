// сортировка массива от мин к макс

int []arr ={1,5,4,3,2,1,4,8};

void PrintArray(int[]array)
{
    int count = array.Length;
    for (int i=0; i<count; i++)
    {
        Console.Write ($"{array[i]} ");
    }
    Console.WriteLine ();
}

void SelectionSort (int[] array)
{
       for (int i=0; i <array.Length - 1; i++)
    {
         int min=i;
         for (int j = i+1; j< array.Length; j++)
         {
             if (array[j] < array[min]) min=j;
         } 
        int temp = array[i];
        array[i] = array [min];
        array[min] = temp;        
    }
}
PrintArray (arr);
SelectionSort (arr); 
PrintArray (arr);

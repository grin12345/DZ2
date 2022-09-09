
int[] GetArray (int size, int minValue,  int maxValue)
{
int [] result = new int [size];


    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

return result;
}
int[] arr = GetArray (10,0,10);
Console.WriteLine (string.Join (", ", arr));

  for (int i = 0; i < arr.Length/2; i++)
  {
    int temp =arr[i];
    arr[i] = arr[arr.Length-i-1]; 
    arr[arr.Length-i-1] =temp;
  }
  Console.WriteLine (string.Join (", ", arr));
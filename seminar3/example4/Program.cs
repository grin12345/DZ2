// выводит массивиз 8 элементов, заполненный нуляеми и единицами в случайном порядке
int []arr = new int [8];
int length = arr.Length;
for (int i=0; i<length; i++)
{
    arr[i]=new Random().Next (0,2);
    Console.Write (arr[i] +"; ");
}

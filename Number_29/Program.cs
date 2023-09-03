void ArrayOutput(int[] array) // вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


void SortArray (int[] array) // пузерковая сортировка массива
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] < array[j])
            {
                num = array[j];
                array[j] = array[i];
                array[i] = num;
            }
        }
    }
}

Console.WriteLine("Введите длину массива");
int ArrayLength = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [ArrayLength];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-100, 101);
}
Console.WriteLine("Не осортированный массив");
ArrayOutput(arr);
Console.WriteLine();
Console.WriteLine("Отсортированный массив");
SortArray(arr);
ArrayOutput(arr);

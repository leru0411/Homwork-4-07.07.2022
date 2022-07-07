// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]


int RandomNum(int min, int max)
{
    int a = new Random().Next(min, max + 1);
    return a;
}

int[] NewArray(int length, int min, int max)
{
    int[] arr = new int[length];
    int i = 0;
    while (i < length)
    {
        arr[i] = RandomNum(min, max);
        i++;
    }
    return arr;
}

void PrintMassive(int[] array)
{
    System.Console.Write("[");
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
    System.Console.WriteLine("]");
}

int[] list = NewArray(8, -8, 8);
PrintMassive(list);
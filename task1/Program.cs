// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int A = Prompt("Введите первое число: ");
int B = Prompt("Введите второе число: ");

// System.Console.WriteLine(Math.Pow(A, B));  вариант без цикла 
int Pow(int num1, int num2) 
{
    int count = 0;
    int result = 1;
    while (count < num2)
    {
        result = result * num1;
        count++;
    }
    return result;
}
int otvet = Pow(A, B);
System.Console.WriteLine(otvet);
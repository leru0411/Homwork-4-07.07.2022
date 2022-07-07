// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int num = Prompt("Введите число > 0: ");
int sum = 0;
if (num > 0)
{
    while (num > 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    System.Console.WriteLine(sum);
}
else System.Console.WriteLine("Введенное число не подходит"); 
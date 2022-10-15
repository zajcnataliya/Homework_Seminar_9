void Zadacha63()
{
//Задача 63: Задайте значения N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N (рекурсией).

Console.WriteLine("Введите число N:");
int number = Convert.ToInt32(Console.ReadLine());
int counter = 0;
Console.WriteLine();
FindNatural(number, counter);

void FindNatural(int number, int counter)
{
    counter++;
    Console.WriteLine(counter);
    if (counter >= number)
    {
        return;
    }
    FindNatural(number, counter);
}
}


void Zadacha65()
{
//Задача 65: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N (рекурсией).

Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
//int counter = 0;
Console.WriteLine();
FindNatural(n, m);

void FindNatural(int m, int counter = 1)
{
    Console.WriteLine(counter);
    counter++;
    if (counter >= m)
    {
        return;
    }
    FindNatural(m, counter);
}
}

void Zadacha67()
{
//Задача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать его сумму чисел (рекурсией).

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumber(number));

    int SumNumber(int number, int sum = 0)
    {
        if (number == 0)
        {
            return sum;
        }
        sum = sum + number % 10;
        number = number / 10;
        return SumNumber(number, sum);
    }
}

void Zadacha69()
{
//Задача 69: Напишите программу, которая на вход принимает два числа А и Б, и 
// и возводит число А  в целую степень Б с помощью рекурсии.

// Console.WriteLine("Введите число A:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B:");
// int b = Convert.ToInt32(Console.ReadLine());

int a = 5; //Решение этой задачи через цикл
int b = 4;
int result = 1;
for (int i = 0; i < b; i++)  // при каком условии работаем
{
    result = result * a;
}
Console.WriteLine($"{a}^{b} = {result}");
Pow(a, b);

void Pow(int a, int b, int i = 0, int result = 1) // решение этой задачи рекурсией
{
    if (i >= b)  // здесь условие обратное, при каком условии завершаем работу
    {
        Console.WriteLine($"{a}^{b} = {result}");
        return;
    }
    result = result * a;
    i++;
    Pow(a, b, i,  result);
}

}





//Zadacha63();
//Zadacha65();
//Zadacha67();
Zadacha69();

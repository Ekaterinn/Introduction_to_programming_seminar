// Задача 1. Найти сумму чисел от 1 до А
// Console.Write("Введите число: ");
// int A = int.Parse(Console.ReadLine());
// int sum = 0;
// for (int count = 1; count <= A; count++)
// {
//     sum = count + sum;
//     // sum += count;
// }
// Console.Write(sum);
// Задача 2. Возведите число А в натуральную степень B используя цикл
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.Write("Введите степень: ");
// int A = int.Parse(Console.ReadLine()!);
// int B = 1;
// // вариант 1 + доп. с отрицательными числами
// if (A >= 0)
// {
//     for (int i = 0; i < A; i++)
//     {
//         B *= num;
//     }
//     Console.Write(B);
// }
// else
// {
//     for (int i = 0; i > A; i--)
//     {
//         B *= num;
//     }
//     Console.Write($"1/{B}");
// }
// вариант 2
// int NumberToThePower(int number, int power)
// {
//     int B = 1;
//     for (int i = 1; i <= power; i++)
//     {
//         B *= number;
//     }
//     return B;
// }
// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.Write("Введите степень: ");
// int A = int.Parse(Console.ReadLine()!);
// int NumB = NumberToThePower(num, A);
// Console.WriteLine(NumB);

// Задача 3. Определить количество цифр в числе
// // вариант 1
// Console.Write("Введите число: ");
// int S = int.Parse(Console.ReadLine()!);
// int quantity = 0;
// while (S != 0)
// {
//     S = S / 10;
//     quantity++;
// }
// Console.Write(quantity);
// вариант 2
Console.Write("Введите число: ");
int S = Convert.ToInt32(Console.ReadLine()!);
int quantity = 1;
while (S >= 10 || S <= -10)
{
    S = S / 10;
    quantity++;
}
Console.Write(quantity);
// Задача А.
// Напишите программу, которая на вход принимает число и выдает его квадрат(число, умноженное само на себя)

// Console.Write("Hello, my friend! Enter the number: ");
// int number = int.Parse(Console.ReadLine()!);
// int sqr = number*number;
// // математиеская библиотека
// int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
// // $ - интерполяция строк. шаблон, в котором какие-то элементы можно вставить, при помощи {}
// Console.WriteLine($"Квадрат числа {number} равен {sqr}");
// Console.WriteLine($"Квадрат числа {number} равен {sqr1}");

// Задача 1.
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квардатом второго.

// Console.Write("Hello, my friend! Enter the number A: ");
// int numberA = int.Parse(Console.ReadLine()!);
// Console.Write("Hello, my friend! Enter the number B: ");
// int numberB = int.Parse(Console.ReadLine()!);
// if (numberA == numberB * numberB)
// {
//     Console.WriteLine(($"Является {numberB} квардатом {numberA}")!);
// }
// else
// {
//     Console.WriteLine(($"Не является {numberB} квардатом {numberA}")!);
// }

// Задача 3. Напишите программу, которая будет выдавать название для недели по заданному номеру.
// Console.Write("Hello, my friend! Enter a number from 1 to 7: ");
// Console.WriteLine("For exit 10");
// int number = int.Parse(Console.ReadLine()!);
// ниже указан пример через if
// if (number == 1)
// {
//     Console.WriteLine("Понедельник");
// }
// else if (number == 2)
// {
//     Console.WriteLine("Вторник");
// }
//  else if (number == 3)
// {
//     Console.WriteLine("Среда");
// }
//  else if (number == 4)
// {
//     Console.WriteLine("Четверг");
// }
//  else if (number == 5)
// {
//     Console.WriteLine("Пятница");
// }
//  else if (number == 6)
// {
//     Console.WriteLine("Суббота");
// }
//  else if (number == 7)
// {
//     Console.WriteLine("Воскресенье");
// }
// 

// Задача 5. Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

// Console.WriteLine("Введите число: ");
// // просим пользователя ввести целое число
// // для того, чтобы ввести отрицательное число. Нужно 
// // int N = Math.Abs(int.Parse(Console.ReadLine()!));
// int N = int.Parse(Console.ReadLine()!);
// int F = -N;
// while (F <= N)
// {
//     Console.Write($"{F} ");
//     F++;
// }

// Задача 7. Напишите программу, которая принимает
// на вход трёхзначное число и на выходе показывает
// последнюю цифру этого числа.
Console.WriteLine("Введите число: ");
int V = int.Parse(Console.ReadLine()!);
int M =V%10;
Console.WriteLine(M);
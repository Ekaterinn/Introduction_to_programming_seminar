// Задача семинара. Напишите программу, которая выводит случайное число от отрезка [10, 99] и показывает наибольшую цифру.
// комбинация для создания рандомного числа
// int number = new Random().Next(10,100);
// Console.WriteLine(number);
// // пример: 12 / 10 = 1; 12 % 10 = 2.
// int numberA = number/10;
// int numberB = number%10;
// int max = numberA;
// if (max < numberB)
// {
//     Console.WriteLine(numberB);
//     max = numberB;
// }
// // else
// // {
// //     Console.WriteLine(numberA);
// //     max = numberA;
// // }
// Console.WriteLine(max);

// Задача 11. Напишите программу, которая выводит 
// случайное трехзначное число и удаляет вторую цифру этого числа.

// int number = new Random().Next(100,1000);
// Console.WriteLine(number);

// Console.WriteLine($"Рандомное число: {number}");
// Console.WriteLine($"Получилось число: {number / 100 * 10 + number % 10}");

// Задача 12. 
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.

// Console.WriteLine("Введите первое число: ");
// int numberA = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int numberB = int.Parse(Console.ReadLine()!);
// int ostatok = numberA%numberB;
// if (ostatok==0)
// {
//     Console.WriteLine($"Число {numberA} кратно {numberB}");
// }
// else 
// {
//     Console.WriteLine($"Остаток деления {ostatok}");
// }

// пример. 7%3=1. Почему?
// потому что 7 это 3+3+1. Из 7 два раза по 3 (итого 6) и ОСТАТОК 1. 3+3+1.

// Задача 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// // введеное число делится на 7 с остатком целого (0) и одновременно делится на 23 с остатком целого (0)
// if (number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine($"{number} одновременно кратно 7 и 23");
// }
// else Console.WriteLine($"{number} одновременно не кратно 7 и 23");

// Задача 16.
// Напишите программу, которая принимает на вход два
// числа и проверяет, является ли одно число квадратом
// другого.

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
int num1 = numberA;
int num2 = numberB;
if (num1>numberB)
{
    num1=numberB;
    num2=numberA;
}
int number1_2 = num1*num1;
if (number1_2 == num2) 
{
    Console.WriteLine($"Число {num2} является квардатом числа {num1}");
}
else
{
    Console.WriteLine($"Число {num2} не является квардатом числа {num1}");
}
Console.Clear();
// вариант с ответом ДА или НЕТ
// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine()!);

// if (num1 == num2 * num2 || num2 == num1 * num1) Console.WriteLine("Да");
// else Console.WriteLine("Нет");

// // вариант2
// Console.Clear();
// int first = Convert.ToInt32(Console.Readline());
// int second = Convert.ToInt32(Console.Readline());
// if (Math.Pow(first) == second) Console.WriteLine($"Первое число {first} является квадратом второго {second}");
// else if (Math.Pow(second) == first) Console.WriteLine($"Второе число {second} является квадратом превого {first}");
// else Console.WriteLine(" Числа не являются квадратами другого");
// // вариант 3
// if (num1 == num2 * num2) Console.WriteLine($"Число {num1} является квадратом числа {num2}");
// else if (num2 == num1 * num1) Console.WriteLine($"Число {num2} является квадратом числа {num1}");
// else Console.WriteLine("Не является");
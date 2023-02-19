// Задача 17. Напишите программу, которая
// принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
// плоскости, в которой находится эта точка.

// Console.Write("Введите координату Х: ");
// int X = int.Parse(Console.ReadLine()!);
// Console.Write("Введите координату У: ");
// int Y = int.Parse(Console.ReadLine()!);
// вариант 1
// if (X > 0)
// {
//     if (Y > 0)
//     {
//         Console.WriteLine($"Точка координат {X} и {Y} находится в 1 четверти");
//     }
//     else
//     {
//         Console.WriteLine($"Точка координат {X} и {Y} находится в 4 четверти");
//     }
// }
// if (X < 0)
// {
//     if (Y > 0)
//     {
//         Console.WriteLine($"Точка координат {X} и {Y} находится в 2 четверти");
//     }
//     else
//     {
//         Console.WriteLine($"Точка координат {X} и {Y} находится в 3 четверти");
//     }
// // }
// // вариант 2
// if (X > 0 && Y > 0)
// {
//     Console.WriteLine($"Точка координат {X} и {Y} находится в 1 четверти");
// }
// else if (X < 0 && Y > 0)
// {
//     Console.WriteLine($"Точка координат {X} и {Y} находится в 2 четверти");
// }
// else if (X < 0 && Y < 0)
// {
//     Console.WriteLine($"Точка координат {X} и {Y} находится в 3 четверти");
// }
// else if (X > 0 && Y < 0)
// {
//     Console.WriteLine($"Точка координат {X} и {Y} находится в 4 четверти");
// }
// else
// {
//     Console.WriteLine("Ошибка введения данных");
// }
// // вариант 3. семинар
// Семён Кривцов: //Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
// //и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Clear();
// Console.Write("Введите X: ");
// int X = int.Parse(Console.ReadLine()!);

// Console.Write("Введите Y: ");
// int Y = int.Parse(Console.ReadLine()!);

// if (Y > 0)
// {
// if (X > 0)
// {
// Console.WriteLine("Первая четверть");
// }
// else
// {
// Console.WriteLine("Вторая четверть");
// }
// }
// else
// {
// if (X > 0)
// {
// Console.WriteLine("Четвертая четверть");
// }
// else
// {
// Console.WriteLine("Третья четверть");
// }
// }
// Задача 18. Работа в группах
// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

// Console.Write("Введите четверть от 1 до 4: ");
// int X = int.Parse(Console.ReadLine()!);

// if (X == 1)
// {
//   Console.WriteLine($"Координаты (х;у) находятся в {X} четверти"); 
// }
// else if (X == 2)
// {
//   Console.WriteLine($"Координаты (-х;у) находятся в {X} четверти"); 
// }
// else if (X == 3)
// {
//   Console.WriteLine($"Координаты (-х;-у) находятся в {X_} четверти"); 
// }
// else if (X == 4)
// {
//   Console.WriteLine($"Координаты (х;-у) находятся в {X} четверти"); 
// }
// else{
//     Console.WriteLine("Ошибка введения данных"); 
// }
// вариант через switch
// int quadrant = int.Parse(Console.ReadLine()!);
// string range = '';

// switch(quadrant) {
//     case 1:
//         range = 'x:y';
//     break;
//     case 2:
//         range = '-x:y';
//     break;
//     case 3:
//         range = '-x:-y';
//     break;
//     case 4:
//         range = 'x:-y';
//     break;
//     default:
//         range = 'неизвестно';
//     break;
// }

// Console.WriteLine($"В четверти {quadrant} диапазон координат ({range})");

// Задача 21. 
// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21
// вариант 1

// Console.WriteLine("Введите точку Х1: ");
// int X1 = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine("Введите точку У1: ");
// int Y1 = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine("Введите точку Х2: ");
// int X2 = Convert.ToInt32(Console.ReadLine()!);
// Console.WriteLine("Введите точку У2: ");
// int Y2 = Convert.ToInt32(Console.ReadLine()!);

// double matchX = Math.Pow(X1-X2,2);
// double matchY = Math.Pow(Y1-Y2,2);
// double match = Math.Sqrt(matchX+matchY);
// // Round - обязательно нужно оказать после запятой количество, до какого числа нужно прописывать
// match = Math.Round(match, 2);
// или можно так, тоже два будет f2
// Console.WriteLine($"{match: f2}");

// вариант 2
// Console.Write("Введите X1: ");
// int X1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите Y1: ");

// int Y1 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите X2: ");

// int X2 = int.Parse(Console.ReadLine()!);

// Console.Write("Введите Y2: ");

// int Y2 = int.Parse(Console.ReadLine()!);

// double X = Math.Abs(X1 - X2);

// double Y = Math.Abs(Y1 - Y2);

// double XX = Math.Pow(X, 2);

// double YY = Math.Pow(Y, 2);

// double result = Math.Sqrt(XX + YY);

// Console.Write(result);

// Задача 22. Работа в группах
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.
// ● 5 -> 1, 4, 9, 16, 25.
// ● 2 -> 1,4
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()!);
int count = 1;
while (count <= N)
{
    Console.Write(count * count);
    if (count != N)
    {
        Console.Write(", ");
    }
    count++;
}

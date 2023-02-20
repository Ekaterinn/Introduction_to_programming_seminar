// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
// // вариант 1. просто перевернуть текущий массив
// void ReversArray1(int[] inArray)
// {
//     // чтобы дойти до середины массива при замене зеркальных частей массива
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//            //  операция свап - замена элементов.
// //         // есть две кружки, с водой и молоком
// //         // нужно перелить жидкости не смешивая
// //         // нужная пустая кружка, третья
// //         // создаем элемент темп, в нее кладем
// //         // элемент массива, 1 с левого конца
//         int temp = inArray[i];
//         // то, что перелили, переходит в правое значение
// //         // чтобы обратиться справа налево массива, нужно -1 - i
//         inArray[i] = inArray[inArray.Length - 1 - i];
//         // перелили жидкость с конца и в значение темп, которое
// //         // было сохранено
//         inArray[inArray.Length - 1 - i] = temp;
//     }
// }
// // вариант 2.
// int[] ReversArray2(int[] inArray)
// {
//     int[] result = new int[inArray.Length];

//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];
//     }
//     return result;
// }

// int[] array = GetArray(6, 0, 10);
// Console.WriteLine(String.Join(", ", array));
// ReversArray1(array);
// Console.WriteLine(String.Join(", ", array));
// int[] reversed = ReversArray2(array);
// Console.WriteLine(String.Join(", ", reversed));

// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
// bool CheckTreeEngl(int a, int b, int c)
// {
// return a + b > c && a + c > b && c + b > a;
// }

// Console.WriteLine("ведите первое число");
// int x = int.Parse(Console.ReadLine()!);
// Console.WriteLine("ведите второе число");
// int y = int.Parse(Console.ReadLine()!);
// Console.WriteLine("ведите третие число");
// int z = int.Parse(Console.ReadLine()!);

// if (CheckTreeEngl(x, y, z))
// {
// Console.WriteLine("существует");
// }
// else
// {
// Console.WriteLine("не существует");
// }

// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// string DecToBin(int dec)
// {
// string result = "";
// while (dec > 0)
// {
// result = (dec % 2).ToString() + result;
// dec /= 2;
// }
// return result;
// }

// Console.WriteLine("введите число");
// int ten = int.Parse(Console.ReadLine()!);
// Console.WriteLine(DecToBin(ten));

// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.Clear();
// int[] Fib(int N)
// {
// int[] arr = new int[N];
// arr[0] = 0;
// arr[1] = 1;
// for(int i=2; i<N; i++)
// {
// arr[i] = arr[i-1] + arr[i-2];
// }
// return arr;
// }
// int N = int.Parse(Console.ReadLine()!);
// int[] array = Fib(N);
// Console.WriteLine(string.Join(", ", array));

// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования. 
int[] GetArray(int size, int minValue, int maxValue)
{
int[] result = new int[size];

for (int i = 0; i < size; i++)
{
result[i] = new Random().Next(minValue, maxValue + 1);
}
return result;
}

int[] CopyArr(int[] inArray)
{
int[] arr = new int[inArray.Length];
for (int i = 0; i < inArray.Length; i++)
{
arr[i] = inArray[i];
}
return arr;
}

void ReversArray1(int[] inArray)
{
for (int i = 0; i < inArray.Length / 2; i++)
{
int temp = inArray[i];
inArray[i] = inArray[inArray.Length - 1 - i];
inArray[inArray.Length - 1 - i] = temp;
}
}

int[] arr = GetArray(5, -10, 10);
int[] copyArr = CopyArr(arr);
Console.WriteLine(String.Join(",", arr));
Console.WriteLine(String.Join(",", copyArr));
ReversArray1(arr);
Console.WriteLine("========");
Console.WriteLine(String.Join(",", arr));
Console.WriteLine(String.Join(",", copyArr));
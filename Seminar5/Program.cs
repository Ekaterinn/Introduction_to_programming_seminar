// Задача 1. 
// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.
// // создать массив инт 
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }
// int[] array = GetArray(12, -9, 9);
// // как распечатать массив в одной строке. 
// // стринг - строка - джойн - соединить - передать разделитель
// //  массива, к примеру запятая
// Console.WriteLine(String.Join(", ", array));
// // положительные и отрицательные
// int positivSum = 0;
// int negativSum = 0;
// // перебрать не значения как в фор, а напрчмую обратиться к элементу
// // напрямую взять элемент
// foreach (int element in array)
// {
//     // // вариант 1
//     //     if (element > 0)
//     //     {
//     //         positivSum += element;
//     //     }
//     // вариант 2. тернальный оператор
//     // что я хочу проверить (какое условие)- делаю проверку - 
//     // что будет прибавлять, если проверка прошла - если проверка
//     // окажется ложной (0)
//     positivSum += element > 0 ? element : 0;
//     negativSum += element < 0 ? element : 0;
// }
// Console.WriteLine($"Сумма положительных числе равна: {positivSum}, а отрицательных {negativSum}");

// // вариант 3
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         positivSum += array[i];
//     }
//     else
//     {
//         negativSum += array[i];
//     }
// }

// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }

// void ChagneSign(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         inArray[i] *= -1;
//     }
// }
// int[] array = GetArray(10, -10, 10);
// Console.WriteLine(String.Join(", ", array));
// ChagneSign(array);
// Console.WriteLine(String.Join(", ", array));


// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
// Console.WriteLine("Выведен массив. Далее введите число");
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }
// // проверяем правда есть заданное число или нет функицей боол
// bool numberFind(int[] inArray, int number)
// {
//     foreach (int element in inArray)
//     {
//         if (element == number)
//             return true;
//     }
//     return false;
// }
// int[] massiv = GetArray(5, -10, 10);
// Console.WriteLine(String.Join(", ", massiv));
// int num = int.Parse(Console.ReadLine());
// if (numberFind(massiv, num))
// {
//     Console.WriteLine("Ваше число присутствует в массиве.");
// }
// else
// {
//     Console.WriteLine("Ваше число не присутствует в массиве.");
// }

// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// }
// int countNumbers(int[] array)
// {
//     int count = 0;
//     foreach (int element in array)
//     {
//        if (element >= 10 && element <= 99) 
//        {
//         count++;
//        }
//     }
//     return count;
// }
// int[] array = GetArray(123, 0, 150);
// Console.WriteLine(String.Join(", ", array));
// int count = countNumbers(array);
// Console.WriteLine(count);

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int[] MultiArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1)
    {
        size++;
    }
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1)
    {
        result[size - 1] = array[array.Length / 2];
    }
    return result;
}

int[] massiv = GetArray(5, 0, 10);
Console.WriteLine(String.Join(",", massiv));
int[] newMassiv = MultiArray(massiv);
Console.WriteLine(String.Join(",", newMassiv));
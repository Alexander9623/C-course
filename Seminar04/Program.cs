// Console.Clear();
// int MaxFunc(int a, int b)
// {
//     if (a > b)
//     {
//         return a;
//     }
//     return b;
// }

// int maxxy = MaxFunc(1, 10);

// Console.WriteLine(maxxy);

// void f(ref int x)
// {
//     Console.WriteLine(x);
//     x = x + 1;
//     Console.WriteLine(x);
// }

// int x = 10;
// Console.WriteLine(x);

// f(ref x);
// Console.WriteLine(x);


//...................................................................

// Задайте одномерный массив, заполненный случайными числами.
// Определите колличество простых чисел в этом массиве.
// Простые числа, это числа, которые делятся на еденицу и сами на себя.
// Пример 
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

// Функция по заполнению массива(Процедура InputArray)
// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 20);
// }
// // ...............................................

// bool CheckPros(int x)   // нахождение простых чисел
// {
//     for (int i = 2; i < x; i++)
//         if (x % i == 0)
//             return false;
//     return true;
// }
// // ...............................................

// void ReleaseArray(int[] array)  // считаем количество простых чисел в массиве
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)

//         if (CheckPros(array[i]) == true)
//             count++;

//     Console.WriteLine(count);



// }

// // Основной код
// Console.Clear();
// Console.Write("Введите число элементов: ");
// int k = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[k];
// InputArray(array);
// Console.WriteLine(string.Join(", ", array));
// ReleaseArray(array);



// .......................................................................................

// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(1, 100);
// }

// void FindArray(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 10 == 1 && array[i] % 7 == 0)
//         count++;
//     }
//     Console.WriteLine(count);
// }

// Console.Clear();
// Console.Write("Введите число элементов: ");
// int k = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[k];
// InputArray(array);
// Console.WriteLine(string.Join(", ", array));
// FindArray(array);

//..................................................................

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

// void InputArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 10);
// }

// int ReleaseArray(int[] array)
// {
//     int x = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         x = x * 10 + array[i];
//     }
//     return x;
// }

// Console.Clear();
// Console.Write("Введите число элементов: ");
// int k = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[k];
// InputArray(array);
// Console.WriteLine(string.Join(", ", array));
// int res = ReleaseArray(array);
// Console.WriteLine(res);
// Console.WriteLine(res.GetType());


// int res2 = Convert.ToInt32(string.Join("", array));
// Console.WriteLine(res2);
// Console.WriteLine(res2.GetType());


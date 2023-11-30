//  Создание массива с циклом  for

// Console.Clear();
// Console.Write("Введите длину массива: ");
// int x = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[x];

// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(1, 11);
// }
// Console.Write(string.Join(", ", array));

//  Создание массива с циклом  while

// Console.Clear();
// Console.Write("Введите длину массива: ");
// int x = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[x];
// int i = 0;

// while (i < x)
// {
//     array[i] = new Random().Next(1, 11);
//     Console.Write(array[i]  + " ");
//     i++;
// }

//................................................

//  Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве

// Console.Clear();
// Console.Write("Введите длину массива: ");
// int x = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[x];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(1, 11);
// }
// Console.WriteLine(string.Join(", ", array));

// int k = new Random().Next(1, 11);
// Console.WriteLine(k);
// bool flag = false;


// for (int i = 0; i < array.Length; i++)
// {
//     if (k == array[i])
//     {
//         flag = true;
//         Console.Write("Yes");
//         break;
//     }
// }
// if (flag == false) 
// Console.Write("No");

//...................................................................


// Задайте массив из 10 элементов, заполненный числами из 
// промежутка [-10, 10]. Замените отрицательные элементы на положительные,
//  а положительные на отрицательные.
// Пример
// [1, -5, 6] => [-1, 5, -6]


// Console.Clear();
// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10, 11);
// }
// Console.WriteLine(string.Join(", ", array));

// for (int i = 0; i < array.Length; i++)
// array[i]*= -1;
// Console.WriteLine(string.Join(", ", array));

//......................................................................

// Найдите произведение пар чисел в однородном массиве. Парой считаетчся 
// первый и последний элемент, второй и предпоследний и т.д. Результат
// запишите в новый массив.
// Пример:
// [1, 3, 2, 4, 2, 3] => [3, 6, 8]
// [2, 3, 1, 7, 5, 6, 3] => [6, 18, 5] (элемент 7 не имеет пары)

// Console.Clear();
// Console.Write("Введите длину массива: ");
// int x = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[x];

// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(1, 11);
// }
// Console.WriteLine(string.Join(", ", array));


// int[] new_array = new int[array.Length / 2];
// for (int i = 0; i < array.Length / 2; i++)
// {
//     new_array[i] = array[i] * array[array.Length -1 - i];
// }
// Console.WriteLine(string.Join(", ", new_array));


// i 0  1  2  3  4  5
//  [1, 3, 2, 4, 2, 3]
// array[0] * array[array.Lenght -1 -0]
// array[1] * array[array.Lenght -1 -1]
// array[2] * array[array.Lenght -1 -2]

//..........................................................



// Дано натуральное трёхзначное число. Создайте массив, который 
//  состоит из цифр этого числа. Младший разряд числа должен 
// распологаться на нулевом индексе, старший на втором.

// мой варик
// Console.Clear();
// Console.Write("Введите натуральное трёхзначное число: ");
// int numb = Convert.ToInt32(Console.ReadLine());

// int n1 = numb / 100;
// int n2 = numb / 10 % 10;
// int n3 = numb % 10;

// int[] array = new int[3];

// array[0] = n3;
// array[1] = n2;
// array[2] = n1;

// Console.WriteLine(string.Join(", ", array));

// Варик по лучше :-D

Console.Clear();
int[] array = new int[3];
int k = new Random().Next(100, 1000);
Console.WriteLine(k);

for (int i = 0; i < array.Length; i++)
{
    array[i] = k % 10;
    k/=10;
}
 Console.WriteLine(string.Join(", ", array));





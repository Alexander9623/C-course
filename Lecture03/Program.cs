// 1) Первая группа методов: ничего не принимают и не возвращают.
// Пример
// void Method1()
// {
//     Console.WriteLine("Автор Копытов Александр");
// }

//Вариант как вызываются подобные методы, нужно указать
// идентификатор данного метода.

// Method1();

//...................................................................

// 2) Вторая группа методов: что то принимают и ничего не возвращают.
// Пример
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// //Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// Method21("Текст", 4); //4 количество повторений

//..................................................................



// 3) Третья группа методов: ничего не принимают и что то возвращают.
// Пример


// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int yaer = Method3();
// Console.WriteLine(yaer);

//.................................................................

// 3) Четвёртая группа методов: что то принимают и что то возвращают. Самая важная группа.
// Пример

// string Method4(int count, string text)
// {
//     int i =0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;

// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

// Пример2, более удобный

// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//      return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

// ............................................................................


// Пример с циклом for  и таблицей умножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

//...................................................................................


// ========== Работа с текстом
//  Дан текст. В тексте нужно все пробелы заменить чёрточками,
//  маленькие буквы "к" заменить большими "К", а большие "С" 
// заменить маленькими "с".

// Ясна ли задача?

// string text = "_ Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";


// string s = "qwerty"
//             0123
//  s[3]  // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) 
//         result = result + $"{newValue}";
//         else 
//         result = result + $"{text[i]}";
//     }

//     return result;
// }


// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(text, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(text, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();

//..............................................................................,

// Метод который сортирует числа массива от маленького к большому

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 8, 5 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// // PrintArray(arr);

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition])
//                 minPosition = j;

//         }


//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }

// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);
// .................................................................

// Метод который сортирует числа массива от большего к меньшему

// int[] arr = { 1, 5, 41, 3, 2, 6, 7, 8, 5 };

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int maxPosition = i;

//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] > array[maxPosition])
//                 maxPosition = j;

//         }


//         int temporary = array[i];
//         array[i] = array[maxPosition];
//         array[maxPosition] = temporary;
//     }

// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);
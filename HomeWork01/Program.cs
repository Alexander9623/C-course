//Дз №1

// Код который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

// Console.Clear();
// Console.Write("Введите число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
 
// if(firstNumber > secondNumber)
// {
// Console.Write($"Первое число `{firstNumber}`");
// Console.Write($" больше чем второе число `{secondNumber}`");
// }
// if(firstNumber < secondNumber)
// {
// Console.Write($"Первое число `{firstNumber}`");
// Console.Write($" меньше чем второе число `{secondNumber}`");  
// }
// if(firstNumber == secondNumber)
// {
// Console.Write($"Введенные числа равны `{firstNumber}`");
// }


// Дз №2

// Код который принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int c = Convert.ToInt32(Console.ReadLine());
 
// int max = a;
// if(a > max) max = a;
// if(b > max) max = b;
// if(c > max) max = c;
// Console.Write(max);
// return max; Вместо консоли для автотестов


// Дз №3

// Код который на вход принимает число и выводит, является ли число чётным или нечётным.

// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 <= 0)
// {
//     Console.Write($"Число `{number}` чётное");
// }
// if (number % 2 > 0) 
// {
//     Console.Write($"Число `{number}` нечётное");
// }


// Дз №4

// Код  который на вход принимает число, а на выходе выводит все чётные числа от 1 
// до этого введенного числа (включительно), разделеные знаком табуляции.

//  От большего чётного к меньшему чётному

// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int i = 1;
// while (i <= number)  
// {
//     if(number % 2 <= 0)
//     {
//         Console.Write(number + "\t");
//         number = number - 2;
        
//     }
//     else 
//     {
//         number = number - 1;
//     }
// }

//  От меньшего чётного к большему чётному

// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int i = 1;
// while (i <= number)  
// {
//     if(i % 2 <= 0)
//     {
//         Console.Write(i + "\t");
//         i = i +2;
//     }
//     else 
//     {
//         i ++;;
//     }
// }




// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int InputData(string text)
// {
//     System.Console.WriteLine(text);
//     int n = Convert.ToInt32(Console.ReadLine());
//     return n;
// }

// void NumbOrder(int n)
// {
//     if (n == 0)
//     {
//         return;
//     }
//     System.Console.Write($"{n}\t");
//     NumbOrder(n - 1);
// }

// int n = InputData("Vvedite chislo");
// NumbOrder(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// (int, int) InputDoubleData(string text)
// {
//     System.Console.WriteLine(text);
//     int nMin = Convert.ToInt32(Console.ReadLine());
//     int nMax = Convert.ToInt32(Console.ReadLine());
//     return (nMin, nMax);
// }

// int NumbersSum(int minN, int maxN)
// {
//     if (minN == maxN)
//     {
//         return minN;
//     }
//     return minN += NumbersSum(minN + 1, maxN);
// }

// (int min, int max) = InputDoubleData("Vvedite diapazon dlia podsheta summi");
// System.Console.Write($"Summa vsex chisel v intervale  {min} <=> {max} ==> {NumbersSum(min, max)}\t");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// (int, int) InputDoubleData(string text)
// {
//     System.Console.WriteLine(text);
//     int m = Convert.ToInt32(Console.ReadLine());
//     int n = Convert.ToInt32(Console.ReadLine());

//     return (m, n);
// }

// int AkkermanFunction(int mValue, int nValue)
// {
//     if (mValue == 0) return nValue + 1;
//     else if (mValue > 0 && nValue == 0) return AkkermanFunction(mValue - 1, 1);
//     return AkkermanFunction(mValue - 1, AkkermanFunction(mValue, nValue - 1));
// }

// (int m, int n) = InputDoubleData("Vvedite M i N");

// System.Console.WriteLine($"Pri m = {m} i n = {n} => {AkkermanFunction(m, n)}");





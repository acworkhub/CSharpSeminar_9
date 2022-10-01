// Задача 1: Задайте значение N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// int Promt(string message)
// {
//     System.Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }


// void ShowNumbers(int number)
// {   


//     if (number <= 0)
//     {
//         return;
//     }
//     ShowNumbers(number - 1);
//     System.Console.WriteLine(number);
// }

// int number = Promt("Введите номер");

// ShowNumbers(number);
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// (int, int) DoublePromt(string text)
// {
//     System.Console.WriteLine(text);
//     System.Console.WriteLine("Nignaya granitsa intervala");
//     int min = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Verhniaya granitsa intervala");
//     int max = Convert.ToInt32(Console.ReadLine());
//     return (min, max);
// }

// void ShowIntervalNumb(int min, int max)
// {

//     if (min > max)
//     {
//         return;
//     }
//     System.Console.WriteLine(min);
//         ShowIntervalNumb(min + 1, max);
// }

// (int minnumb, int maxnumb) = DoublePromt("Vvedite parametri verha i niza");

// ShowIntervalNumb(minnumb, maxnumb);
///////////////////////////////////////////////////////////////////////////////////////////////////

// int numb = Promt("Vvedite chislo dlia rasheta summi");

// void SumNumber(int number, int sum)
// {
//     sum += number % 10;
//     number = number / 10;
//     if (number < 1)
//     {
//         System.Console.WriteLine(sum);
//         return;
//     }
//     SumNumber(number, sum);
// }
// int SumNumber(int number)
// {
//     if (number == 0)
//     {  
//         return 0;
//     }
//     return number % 10 + SumNumber(number/10);
// }

// // SumNumber(numb, 0);
// SumNumber(numb);
// System.Console.WriteLine(SumNumber( numb));


// (int, int) DoublePromt(string text)
// {
//     System.Console.WriteLine(text);
//     System.Console.WriteLine("Vvedite Chislo");
//     int n = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Vvedite stepen vozvedeniya");
//     int degree = Convert.ToInt32(Console.ReadLine());
//     return (n, degree);
// }

// (int n, int degree) = DoublePromt("Vvedite parametri");

// int NumberDegree(int number , int deg)
// {

//     if(deg == 1)
//     {
//         return number;
//     }

//     return number * NumberDegree(number, deg - 1);
// }

// NumberDegree(n, degree);
// System.Console.WriteLine(NumberDegree(n,degree));

// bool IsDegreeTwo(int number)
// {
//     if (number == 1)  {return true;}
    
//     return (number % 2 == 0) && IsDegreeTwo(number / 2);  
// }

// int numb = 12;

// if (IsDegreeTwo(numb)) { System.Console.WriteLine("Yavliaetsia"); }

// else { System.Console.WriteLine("Ne yavliaetsia"); }

// bool IsSimpleNumb(int number, int count)
// {
//     if (count == number)  {return true;}
    
//     return (number % count != 0) && IsSimpleNumb(number, count + 1);  
// }

// if (IsSimpleNumb(151, 2)) { System.Console.WriteLine("Yavliaetsia"); }

// else { System.Console.WriteLine("Ne yavliaetsia"); }
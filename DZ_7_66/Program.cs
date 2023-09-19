// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbersInterval(int M, int N)
{   int result = 0;
    if (M <= N)   return SumNumbersInterval(M, N - 1) + N;
    return result;
   
}

System.Console.WriteLine($"Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbersInterval(M,N));

// string PrintNumbers(int m, int n) 
// { 
//     if (n < m) 
//         return ""; 
//     return PrintNumbers (m, n - 1) + $"{n} "; 
// } 

// System.Console.WriteLine("Введите нижнюю границу M"); 
// int min = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine("Введите верхнюю границу N"); 
// int max = Convert.ToInt32(Console.ReadLine()); 
// System.Console.WriteLine(PrintNumbers(min, max));

//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

/*

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintData(m, n, temp=0);

void PrintData(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {sum} ");
    return;
  }
  PrintData(m, n - 1, sum);
}

int ReadData(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

*/

//Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
/*

Console.WriteLine("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

string ReadData(int m, int n)
{
    if (m == n) return n.ToString();
    else return m.ToString() + ", " + ReadData(m += 1, n);
}

Console.WriteLine(ReadData(numM, numN));

*/

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

/*
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunc(int m, int n)
{
    if(m == 0)
        {
            return n + 1;  
        }
    if(m > 0 && n == 0)
        {
            return AkkermanFunc(m - 1, 1);
        }
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

Console.WriteLine($"A(m,n) = {AkkermanFunc(n, m)}");

*/



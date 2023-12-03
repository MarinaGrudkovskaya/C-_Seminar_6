// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int n = GetNamber("Введите число ");
GetFibanachiNumber(n);
int GetNamber(string messege)
   {
    Console.WriteLine(messege);
    int number = int.Parse(Console.ReadLine()!);
    return number;
   }

void GetFibanachiNumber(int number)
{
  int a = 0;
  int b = 1;
  int c = 0;
  Console.Write($"{n} -> ");
  for (int i = 0; i < n; i++)
  {
    c = a;
    a = b;
    b = c+b;
    Console.Write($"{c} ");
  }
}
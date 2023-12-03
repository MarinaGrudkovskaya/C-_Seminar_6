// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
int num1 = GetNumber("Введите первую сторону - ");
int num2 = GetNumber("Введите вторую сторону - ");
int num3 = GetNumber("Введите третью сторону - ");
Proverka(num1, num2, num3);

int GetNumber(string messege)
  {
    Console.Write(messege);
    int number = int.Parse(Console.ReadLine()!);
    return number;
  }
 
void Proverka(int a, int b, int c) 
   {
    if (a+b>c && a+c>b && c+b>a)
    Console.Write($"Треугольник со сторонами {a}, {b}, {c} есть");
    else Console.Write($"Нет треугольник со сторонами {a}, {b}, {c}");
   }



// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// int a = 2;
// int[] res = new int[GetLengthArray(a)];
// int b = 0;
// int i = 0;
//      while(a > 0)
//       {
//         b = a%2;
//         a = a/2;
//         res[res.Length-1-i] = b;
//         i++;
//       }
//   Console.Write(String.Join("|", res));

// int GetLengthArray(int num) //внимательно следи какая переменная обрабатывается внутри функции
// {
// int count = 0;
// while (num > 0)
// {
//    int num2 = num%2; 
//    num = num/2;
//    count++;
// }
// return count;
// }

//Решение через строку

int number = 10;
string result = " "; // создала пустую строку
while (number != 0)
{
   result = number%2 + result; //новое число записывается перед ранее полученными(но это строка)
   number = number/2;
}
Console.Write(result);


// Метод - записываем массив из строки, преобразуя строковый массив в числовой

int[] Input(string abc)
  {
   Console.WriteLine($"{abc} ");
   string[] input = Console.ReadLine()!.Split(" ");
   int[] numbers = new int[input.Length];
   for(int i = 0; i < input.Length; i++)
   numbers[i] = int.Parse((input[i]));
   return numbers;
  }

  void PrintArray(int[] array)
   {
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(String.Join("|", array[i]));
    }
   }

int[] array = Input("Введите число через пробел");
PrintArray(array);


  
     

   

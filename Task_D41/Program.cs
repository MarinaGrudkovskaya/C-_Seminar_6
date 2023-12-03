// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
int m = Promt("Введите количество чисел: ");
int[] arr = GetNambers(m);
PrintArray(arr);
CountNumber(arr);

int Promt(string messege)
   {
    Console.Write(messege);
    string vale = Console.ReadLine();
    int number = Convert.ToInt32(vale);
    return number;
   }

int[] GetNambers(int num)
  {
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Promt($"Введите число {i+1} ");
    }
    return array;
  }

void PrintArray(int[] array)
   {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
   }

void CountNumber(int[] array)
   {
     int count = 0;
     for (int i = 0; i < array.Length; i++)
     {
        if(array[i] > 0)
        count++;
     }
    Console.Write($" -> {count}"); 

   }
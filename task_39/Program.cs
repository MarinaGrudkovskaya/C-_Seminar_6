// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// int size = Promt("Введите длину масива: ");
// int min  = Promt("Введите min масива: ");
// int max  = Promt("Введите max масива: ");
// int[] arr  = GetArray(size, min, max);
// Console.Write("[");
// PrintArray(arr);
// int[] arr1 = ReversArray(arr);
// Console.Write("] ->  [");
// PrintArray(arr1);
// Console.Write("]");

// int Promt(string messege)
//    {
//     Console.WriteLine(messege);
//     int number = int.Parse(Console.ReadLine()!);
//     return number;
//    }

// int[] GetArray(int size, int min, int max)
//    {
//     int[] arr = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(min, max+1);
//         // Console.Write($"{arr[i]} ");
//     }
//     return arr;
//    }

// void PrintArray(int[] array)
//    {
//     for (int i = 0; i < array.Length; i++)
//     {
//     Console.Write($"{array[i]} ");
//     }
//    }

// int[] ReversArray(int[] array)
//    {
//     int k = array.Length;
//     int[] array1 = new int[k];
//     for (int i = 0; i < k; i++)
//     {
//         array1[i] = array[k-1-i];  
//     }
//     return array1;
//    }

// Решение Эльвиры

int[] array = GetArray(7, 0, 15); //иызвали метод и внесли в ручную параменты
Console.Write(String.Join(" ", array)); //распечатываем массив, испольуем метод "String.Join"
ReverseArray1(array);
Console.WriteLine();
Console.Write(String.Join(" ", array));
ReverseArray2(array);
Console.WriteLine();
Console.Write(String.Join(" ", array));

int[] GetArray(int size, int min, int max) //как у меня
   {
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max+1);
    }
    return arr;
   }   

void ReverseArray1(int[] array) //метод работает с половиной длинны массива
   {
      for (int i = 0; i < array.Length/2; i++)
      {
         int temp = array[i]; //Сохранили перый элемент  {36:00:00}
         array[i] = array[array.Length-1-i];  //индекс последнего элемента  "array.Length-1"
         array[array.Length-1-i] = temp;// первый элемент перезаписали в последний
      }
   }   

int[] ReverseArray2(int[] arr)
   {
      int[] revers = new int[arr.Length];
      for (int i = 0; i < arr.Length; i++)
      {
         revers[i] = arr[arr.Length-1-i];
      }
      return revers;
   }




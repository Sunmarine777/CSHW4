//Задача 3: Напишите программу, которая перевернёт одномерный массив 
//(первый элемент cтанет последним, второй – предпоследним и т.д.)

using System;

class Program
{
      static void Main(string[] args)
      {
            int size = Convert.ToInt32(10);
            Random rand = new Random();
            int[] array = new int[size];
            int temp = 0;
                  
            for (int i = 0; i < size; i++)
            {
                  array[i] = rand.Next(1,50);
                  Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            
            for (int i = 0; i < size; i++)
            {
            
                  temp = array[i];
                  array[i] = array[size - i - 1];
                  array[i] = temp;
                  
                  Console.Write(array[size - i - 1] + " ");
            }
            
      }
}
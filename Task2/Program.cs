//Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//Console.Write("Enter array size: ");
//int size = Convert.ToInt32(Console.ReadLine());

int size = Convert.ToInt32(900);
int[] array = new int [size];
Random rand = new Random();
int countEven = 0;
            
for (int i = 0; i < size; i++)
      {
            int number = rand.Next(100,999);
            if (number % 2 == 0)
            countEven++;

      }

Console.WriteLine($"Even numbers in array: " + countEven);
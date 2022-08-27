// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void InputNumbers ()
{
   Console.WriteLine("Сколько чисел хотите ввести:  ");
   int m = Convert.ToInt32(Console.ReadLine());
   int[] array = new int [m];
   int count = 0;

    Console.WriteLine("введите числа: ");

   for (int i = 0; i < m; i++)
   {
       array[i]= Convert.ToInt32(Console.ReadLine()); 
       if (array[i] > 0) count ++;
    
   }
        Console.WriteLine();
        Console.WriteLine($"Пользователь ввел {count} положительных чисел");
}

InputNumbers();
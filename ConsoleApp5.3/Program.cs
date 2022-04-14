using System;
using System.Collections.Generic;

namespace ConsoleApp5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;

            int number;

            List<int> numbers = new List<int>();

            while (isWorking)
            {
                var userInput = Console.ReadLine();
                
                if (userInput == "exit")
                {
                    isWorking = false;
                    break;
                }
                else if (userInput == "sum")
                {
                    int sum = 0;

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine("Сумма всех чисел в массиве : " + sum);
                }
                else if(Int32.TryParse(userInput, out number))
                {                    
                    numbers.Add(number);
                    
                    Console.WriteLine($"Число {number} добавлено\n");
                }
                else
                {
                    Console.WriteLine($"Невозможно преобразовать {userInput} в число");                   
                }
            }
        }
    }
}

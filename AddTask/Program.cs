using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    internal class Program
    {
        /*
        Використовуючи Visual Studio, створіть проєкт за шаблоном ConsoleApplication.
        Створіть масив розмірністю в 10 елементів, виведіть на екран всі елементи масиву в зворотному порядку.
         */
        static void CreateArray(ref int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 9);
            }
        }
        static void ShowArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Значення елементу массиву {i} = {array[i]}");
            }
        }
        static void ShowArrayRevers(params int[] array)
        {
            for (int i = array.Length-1; i >= 0; i--)
            {
                Console.WriteLine($"Значення елементу массиву {array.Length - 1-i} = {array[i]}");
            }
        }
        static void Main(string[] args)
        {
            int N = 10; //розмір масиву
            int[] myArray = new int[N];
            CreateArray(ref myArray);
            ShowArray(myArray);
            Console.WriteLine("Вивiд елементiв масиву в зворотньому порядку:");
            ShowArrayRevers(myArray);
            //Dellay
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        /*
        Використовуючи Visual Studio, створіть проєкт по шаблоном ConsoleApplication.
        Потрібно:
        Створити масив розміру N елементів, заповнити його довільними цілими значеннями (розмір масиву задає користувач).
        Вивести на екран: найбільше значення масиву, найменше значення масиву, загальну суму всіх елементів, 
        середнє арифметичне всіх елементів, вивести всі непарні значення.
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
        static void OddArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2) != 0)
                    Console.WriteLine($"Непарне значення елементу массиву {i} = {array[i]}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть розмiр масиву: ");
            int N = Int32.Parse(Console.ReadLine());
            int[] myArray = new int[N];
            CreateArray(ref myArray);
            ShowArray(myArray);
            Console.WriteLine("max = " + myArray.Max());
            Console.WriteLine("min = " + myArray.Min());
            Console.WriteLine("sum = " + myArray.Sum());
            Console.WriteLine("avarage = " + myArray.Average());
            OddArray(myArray);
            //Dellay
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        /*
        Використовуючи Visual Studio, створіть проєкт за шаблоном ConsoleApplication.
        Створити метод, який буде виконувати збільшення довжини масиву, переданого як аргумент, на 1 елемент. 
        Елементи масиву повинні зберегти своє значення і порядок індексів.
        Створіть метод, який приймає два аргументи, перший аргумент - типу int[] array, другий аргумент - типу int value. 
        У тілі методу реалізуйте можливість додавання другого аргументу методу в масив за індексом 0, 
        при цьому довжина нового масиву повинна збільшитися на 1 елемент, 
        а елементи одержуваного масиву у якості першого аргументу повинні скопіюватися в новий масив починаючи з індексу 1.
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
        static int [] Extensions(int[] array, int value)
        {
            int[] arrayOut = new int[array.Length+1];
            arrayOut[0] = value;
            array.CopyTo(arrayOut, 1);
            return arrayOut;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть розмiр масиву: ");
            int N = Int32.Parse(Console.ReadLine());
            int[] myArray = new int[N];
            CreateArray(ref myArray);
            ShowArray(myArray);
            Console.WriteLine("Введiть елемент, який добавити на початку: ");
            int e = Int32.Parse(Console.ReadLine());
            int[] myArray2 = new int[N+1];
            myArray2 = Extensions(myArray, e);
            ShowArray(myArray2);

            //Delay
            Console.ReadKey();
        }
    }
}

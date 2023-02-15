using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        /*
        Використовуючи Visual Studio, створіть проєкт за шаблоном ConsoleApplication.
        Потрібно:
        1) Створити метод MyReverse(int[] array), який приймає в якості аргументу масив цілочисельних елементів 
        і повертає інвертований масив (елементи масиву в зворотному порядку).
        2) Створіть метод int[] SubArray(int[] array,int index,int count). Метод повертає частину 
        отриманого в якості аргументу масиву, починаючи з позиції, зазначеної в аргументі index, 
        розмірністю, яка відповідає значенню аргументу count.
        Якщо аргумент count містить значення більше, ніж кількість елементів , 
        які входять в обрану частину вихідного масиву ( від зазначеного індексу index до індексу останнього елемента ), 
        то при формуванні нового масиву розмірністю в count, 
        заповніть одиницями ті елементи, які були скопійовані з вихідного масиву.
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
        static void MyReverse(ref int[] array)
        {
            Array.Reverse(array);
        }
        static int[] SubArray(int[] array, int index, int count)
        {
            int[] arrayOut = new int[count];
            if (array.Length > (index+count))
                for (int i = 0; i < count; i++)
                    arrayOut[i] = array[i + index];
            else
                for (int i = 0; i < array.Length-index; i++)
                    arrayOut[i] = 1;
            return arrayOut;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть розмiр масиву: ");
            int N = Int32.Parse(Console.ReadLine());
            int[] myArray = new int[N];
            
            CreateArray(ref myArray);
            Console.WriteLine("Cтворений масив: ");
            ShowArray(myArray);
            MyReverse(ref myArray);
            Console.WriteLine("Iнвертований масив: ");
            ShowArray(myArray);
            
            Console.WriteLine("Введіть з якої позиції починати новий масив: ");
            int position = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введіть к-сть елементів в новому масиві: ");
            int count = Int32.Parse(Console.ReadLine());
            int[] myArray2 = new int[count];
            myArray2 = SubArray(myArray, position, count);
            Console.WriteLine("Новий масив: ");
            ShowArray(myArray2);

            //Dellay
            Console.ReadKey();
        }
    }
}

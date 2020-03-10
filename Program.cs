using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiggestNumberConsoleApplication;

namespace BiggestNumberConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Console.WriteLine( "enter the values: " + "\n" );

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int Largest = array[9];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > Largest)
                {
                    Largest = array[i];
                }
            }

            Console.WriteLine( "The Largest Number from the elements is :" + Largest );
            Console.ReadLine();
        }
    }
}

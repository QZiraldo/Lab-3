using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void SquaresandCubes()
        {
            int UserInput = Convert.ToInt32(Console.ReadLine());
            int Square;
            int Cube;

            for (int i = 0; i <= UserInput; i++)
            {
                Square = (i * i);
                Cube = (i * i * i);

                Console.WriteLine(i + "          " + Square + "          " + Cube);

            }
        
          
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!\n");

            string run;
            do
            {
                Console.WriteLine("\nEnter an intiger:");
               
                SquaresandCubes();

                Console.WriteLine("Do you want to Continue?");
                run = Console.ReadLine();
            }
            while (run == "y");    
            }
        }
}

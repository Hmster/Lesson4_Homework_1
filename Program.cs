using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1 of homework
            Console.WriteLine("-------Part1-------\n");

            Random random = new Random();

            string[] name = new string[4] { "Александр", "Иван", "Николай", "Игорь" };
            string[] surname = new string[4] { "Александров", "Иванов", "Николаев", "Игорев" };
            string[] patron = new string[4] { "Владимирович", "Иванович", "Николаевич", "Игоревич" };

            string[] fullname = new string[4];

            for (int i = 0; i < 4; i++)
            {
                fullname[i] = Lesson4.GetFullName(name[random.Next(0, 3)], surname[random.Next(0, 3)], patron[random.Next(0, 3)]);
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ф.И.О: " + fullname[i]);
            }

            //Part 2 of homework
            Console.WriteLine("\n-------Part2-------\n");

            Console.WriteLine("Enter numbers separated with space");
            string getInfo = Console.ReadLine();
            Console.WriteLine();

            int[] data = Lesson4.GetData(getInfo);
            int sum = 0;
            Console.Write("New int array: ");
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i] + " ");
                sum += data[i];
            }
            
            Console.WriteLine("\nSum of numbers:\t" + sum);

            //Part 3 of homework
            Console.WriteLine("\n-------Part3-------\n");
            //get enum from data and check it for correct input
            Lesson4.Seasons month = Lesson4.GetSeason(Lesson4.GetMonthData());
            //print format data
            Console.WriteLine(Lesson4.OutSeasons(month));

            Console.ReadKey();

        }
    }
}

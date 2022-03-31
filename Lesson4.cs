using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Homework_1
{
    internal static class Lesson4
    {
        //homework part 1

        /// <summary>
        /// Create string include 3 args
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="patron"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        internal static string GetFullName(string name, string surname, string patron)
        {
            string fullname = surname + " " + name + " " + patron;
            return fullname;
        }

        //homework part 2

        /// <summary>
        /// Make int array from string
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        internal static int[] GetData(string info)
        {
            int[] _data = new int[info.Length];
            string buffer = "";
            int j = 0;
            //make int array with string length
            for (int i = 0; i < info.Length; i++)
            {
                buffer += info[i];
                if (info[i] == ' ' || i == info.Length-1 )
                {
                    _data[i] = int.Parse(buffer);
                    buffer = "";
                    j++;
                }
            }
            //make int array without 0
            int[] data = new int[j];
            j = 0;
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i] != 0)
                {
                    data[j] = _data[i];
                    j++;
                }
            }
            return data;
        }

        // homework part 3
        internal enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn,
            NotValid
        }

        internal static Seasons GetSeason(int month)
        {
            if (month == 12 || month == 1 || month == 2)
                return Seasons.Winter;
            if (month == 3 || month == 4 || month == 5)
                return Seasons.Spring;
            if (month == 6 || month == 7 || month == 8)
                return Seasons.Summer;
            if (month == 9 || month == 10 || month == 11)
                return Seasons.Autumn;

            return Seasons.NotValid;
        }

        internal static string OutSeasons(Seasons season)
        {
            string output = "";
            switch (season)
            {
                case Seasons.Winter:
                    output = "Зима";
                    break;
                case Seasons.Spring:
                    output = "Весна";
                    break ;
                case Seasons.Summer:
                    output = "Лето";
                    break;
                case Seasons.Autumn:
                    output = "Осень";
                    break;
            }
            return output;
        }

        /// <summary>
        /// Get month number and check for correct input
        /// </summary>
        /// <returns></returns>
        internal static int GetMonthData()
        {
            bool areRight = false;
            int monthNumber = 0;
            while (!areRight || monthNumber < 1 || monthNumber > 12)
            {
                if (!areRight)
                {
                    Console.WriteLine("Enter month number");
                    areRight = int.TryParse(Console.ReadLine(), out monthNumber);
                }
                else if (monthNumber < 1 || monthNumber > 12)
                {
                    Console.WriteLine("Enter number from 1 to 12");
                    areRight = int.TryParse(Console.ReadLine(), out monthNumber);
                }
            }
            return monthNumber;
        }
    }
}

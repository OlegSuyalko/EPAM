using System;

namespace Job2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "23456789ABCDEFGHIJK";
            string output = "";
            Console.WriteLine("Введите число");
            int des = Convert.ToInt32(Console.ReadLine());
            if (des > 18)
            {
                for (int i = 0; i < des / 18; i++)
                {
                    output = output + "K";
                }
                if (des % 18 != 0) output = output + str[des % 18 - 1];
            }
            else output = Convert.ToString(str[des]);
            Console.WriteLine(output);
        }
    }
}

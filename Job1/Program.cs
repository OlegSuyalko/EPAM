using System;

namespace Job1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine() + " ";
            char[] chstr = str.ToCharArray();
            string maxpos = Convert.ToString(chstr[0]);
            int maxznach = 0;
            for (int i = 1; i < str.Length; i++)
            {
                if (maxpos.IndexOf(chstr[i]) == -1 && Convert.ToString(chstr[i]) != " ") maxpos = maxpos + Convert.ToString(chstr[i]);
                else
                {
                    if (maxznach < maxpos.Length)
                    {
                        maxznach = maxpos.Length;
                    }
                    if (Convert.ToString(chstr[i]) == " ")
                    {
                        if (i++ != str.Length - 1)
                        {
                            maxpos = Convert.ToString(chstr[i]);
                        }
                    }
                    else maxpos = Convert.ToString(chstr[i]);
                }
            }
            Console.WriteLine(maxznach);
        }
    }
}

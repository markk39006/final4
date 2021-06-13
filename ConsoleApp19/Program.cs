using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] town = new string[n];
            int covid = 0;
            bool check = true;
            for (int i = 0; i < n; i++)
            {
                town[i] = Console.ReadLine();
                int ntid = int.Parse(Console.ReadLine());
                int[] numtown = new int[ntid];
                for (int j = 0; j < ntid; j++)
                {
                    numtown[j] = int.Parse(Console.ReadLine());
                }
            }
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine("{0} {1} {2}", k, town[k], covid);
            }
            while (check == true)
            {
                string wavecovid = Console.ReadLine();
                if (wavecovid == "Outbreak" || wavecovid == "Vaccinate" || wavecovid == "Lock down")
                {
                    int townwavecovid = int.Parse(Console.ReadLine());
                }
                else if (wavecovid == "Spread")
                {
                    covid = covid + 1;
                }
                else if (wavecovid == "Exit")
                {
                    check = false;
                }
            }
        }
    }
}

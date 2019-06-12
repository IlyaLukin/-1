using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp50
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Билетики");
            int n, k, ans, all;
            string s;
            bool flag;
            string[] split;
            Console.WriteLine("\nВведите два числа N (1<=N<=500000) и К (1<=К<=1000) (K<=N) через пробел: ");
            s = Console.ReadLine();
            split = s.Split(new char[] { ' ' });
            int.TryParse(split[0], out n);
            int.TryParse(split[1], out k);
            Console.WriteLine("Введите число состоящее из 0 и 1 через пробел: ");
            s = Console.ReadLine();
            split = s.Split(new char[] { ' ' });
            int[] x = new int[n];
            for (int i = 0; i < n; i++)
            {
                int.TryParse(split[i], out x[i]);
            }
            ans = 0;
            flag = false;
            int z = 0;
            for (int i = 0; i < n - k; i++)
            {
                if (x[i] != x[i + k]) z += 1;
            }
            ans = -1;
            if (z == 0) ans = 0;
            else
            {
                for (int i = 0; i < n; i++)
                {
                    all = 0;
                    if ((i - k) >= 0)
                    {
                        if (x[i] == x[i - k]) all++;
                        else all--;
                    }
                    if ((i + k) < n)
                    {
                        if (x[i] == x[i + k]) all++;
                        else all--;
                    }
                    if ((all + z) == 0)
                    {
                        ans = i + 1;
                        break;
                    }
                }
            }
            if (ans == -1)
            {
                Console.WriteLine("FAIL");
            }
            else
            {
                Console.WriteLine("OK");
                Console.WriteLine($"{ans}");
            }
            Console.ReadKey();
        }
    }

}
    


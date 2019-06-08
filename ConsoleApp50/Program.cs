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
            int n=0, step=0;
            int[] a = new int[0];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }

            const int UNDEF = -1;
            int changePos = UNDEF;
            for (int start = 0; start < step; start++)
            {
                int n0 = 0;
                int n1 = 0;
                int pos0 = UNDEF;
                int pos1 = UNDEF;
                for(int i = start; i < n; i += step)
                {
                    if(a[i]==0)
                    {
                        n0++;
                        if (n0 == 1)
                        {
                            pos0 = i;
                        }
                    } else if (a[i] == 1)
                    {
                        n1++;
                        if (n1 == 1)
                        {
                            pos1 = i;
                        }
                    }
                    
                }

                if(n0==0||n1==0)
                { continue; }
                if (n0 > 1 && n1 > 1||changePos!=UNDEF) { Console.WriteLine("FAIL"); /*return 0;*/ }
                if (n0 == 1 && n1 == 1) { changePos=(pos0,pos1)}
            }
            //return 0;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class PrimeNumberList
    {
        public void PrimeCheck()
        {
            int min = 0;
            int max = 1000;
            while(min<max)
            {
                int i = 2, isprime = 1 ,limit=(min+1/2);

                if(min<2)
                {
                    isprime = 0;
                }
                while(i<limit)
                {
                    int check = min % i;
                    if(check==0)
                    {
                        isprime = 0;
                        break;
                    }
                    i++;    //increment till 1000
                }
                if(isprime==1)
                {
                    Console.Write("  "+min);
                }
                min++;
            }
        }
    }   
}

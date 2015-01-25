using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PWS_Practical_Assingment
{
    class CryptoMath
    {
        public static BigInteger BigPow (BigInteger x, BigInteger y)
        {
            BigInteger initialNumber = x;

            for (int i = 1; i < y; i++)
            {
                x = x * initialNumber;
            }

            return x;
        }

        public static bool isPrime(int n)
        {
            if (n <= 3)
            {
                return n > 1;
            }
            else if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 5; i * i <= n; i += 6)
                {
                    if (n % i == 0 || n % (i + 2) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public static int GCD(int a, int b)
        {
            int remainder;

            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }

            return a;
        }
    }
}

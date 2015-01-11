using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWS_Practical_Assingment
{
    public class Key
    {
        public int n;
        public int e;
        public int d;

        static int GCD(int a, int b)
        {
            int Remainder;

            while (b != 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }

            return a;
        }

        public void GenerateKey ()
        {
            int p = Main.acces.GetP();
            int q = Main.acces.GetQ();

            if (p == -1 || q == -1)
            {
                return;
            }

            n = p * q;

            int phiN = (p - 1) * (q - 1);

            for (int i = 2; i <= phiN; i++)
            {
                if (GCD(i, phiN) == 1)
                {
                    e = i;
                    break;
                }
            }

            for (int i = 1; i <= phiN; i++)
            {
                if ((i * e) % phiN == 1)
                {
                    d = i;
                    break;
                }
            }
        }
    }
}

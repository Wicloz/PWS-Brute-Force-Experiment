using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Numerics;

namespace PWS_Practical_Assingment
{
    public class BruteForce
    {
        public int n;
        public int e;
        public int d = 0;

        public int cipherIn;

        public int p = 0;
        public int q = 0;

        public string plaintext = "";

        public int refTime = 0;
        public int timeTaken = 0;

        public bool saved = false;
        public bool doneA = false;
        public bool doneB = false;
        public Thread findNumber;

        public BruteForce(int n, int e, int cipherText)
        {
            this.n = n;
            this.e = e;
            this.cipherIn = cipherText;
        }

        public void StartAttack()
        {
            findNumber = new Thread(FindNumber);
            findNumber.Start();
        }

        private void FindNumber()
        {
            int maxNumber = (n /2 ) + 1;

            for (int i = 1; i <= maxNumber; i++)
            {
                p = i;

                if (CryptoMath.isPrime(i))
                {
                    for (int j = 1; j <= maxNumber; j++)
                    {
                        q = j;

                        if (CryptoMath.isPrime(j))
                        {
                            if (i * j == n)
                            {
                                NumbersFound(i, j);
                                return;
                            }
                        }
                    }

                }
            }
        }

        private void NumbersFound (int p, int q)
        {
            this.p = p;
            this.q = q;

            int phiN = (p - 1) * (q - 1);

            for (int i = 1; i <= phiN; i++)
            {
                if ((i * e) % phiN == 1)
                {
                    d = i;
                    break;
                }
            }

            plaintext = "Decrypting...";
            doneA = true;

            BigInteger cipher = new BigInteger(cipherIn);
            BigInteger bigN = new BigInteger(Convert.ToInt64(this.n));

            plaintext = (CryptoMath.BigPow(cipher, this.d) % bigN).ToString();
            doneB = true;
        }
    }
}

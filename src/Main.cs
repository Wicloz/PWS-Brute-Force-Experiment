﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Numerics;

namespace PWS_Practical_Assingment
{
    public partial class Main : Form
    {
        public static Main acces;
        private Key key;
        private BruteForce bf;

        private int cipherTextIn = -1;

        private System.Windows.Forms.Timer timer;
        private List<Results> rl = new List<Results>();

        public Main()
        {
            InitializeComponent();
            acces = this;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            int p = 47;
            int q = 31;
            int plain = 42;

            try
            {
                p = Convert.ToInt32(textBoxP.Text);
            }
            catch
            { }

            try
            {
                q = Convert.ToInt32(textBoxQ.Text);
            }
            catch
            { }

            try
            {
                plain = Convert.ToInt32(textBoxPlainIn.Text);
            }
            catch
            { }

            SaveLoad.SaveFileXml(new Fields(p, q, plain), Directory.GetCurrentDirectory() + "\\settings.cfg");
            SaveResults();

            if (bf != null)
            {
                bf.findNumber.Abort();
            }
        }

        private void SaveResults ()
        {
            SaveLoad.SaveFileXml(rl, Directory.GetCurrentDirectory() + "\\results.txt");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                rl = SaveLoad.LoadFileXml<List<Results>>(Directory.GetCurrentDirectory() + "\\results.txt");

                if (rl == null)
                {
                    rl = new List<Results>();
                }
            }
            catch
            { }

            try
            {
                Fields f = SaveLoad.LoadFileXml<Fields>(Directory.GetCurrentDirectory() + "\\settings.cfg");
                textBoxP.Text = f.p.ToString();
                textBoxQ.Text = f.q.ToString();
                textBoxPlainIn.Text = f.plain.ToString();
            }
            catch
            {
                textBoxP.Text = "47";
                textBoxQ.Text = "31";
                textBoxPlainIn.Text = "42";
            }
        }

        public int GetP ()
        {
            try
            {
                int n = Convert.ToInt32(textBoxP.Text);

                if (CryptoMath.isPrime(n))
                {
                    return n;
                }
                else
                {
                    MessageBox.Show("Enter a prime number for P!", "Input Error");
                    return -1;
                }
            }
            catch
            {
                MessageBox.Show("Enter a valid number for P!", "Input Error");
                return -1;
            }
        }

        public int GetQ()
        {
            try
            {
                int n = Convert.ToInt32(textBoxQ.Text);

                if (CryptoMath.isPrime(n))
                {
                    return n;
                }
                else
                {
                    MessageBox.Show("Enter a prime number for Q!", "Input Error");
                    return -1;
                }
            }
            catch
            {
                MessageBox.Show("Enter a valid number for Q!", "Input Error");
                return -1;
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            key = new Key();
            if (key.GenerateKey())
            {
                labelN.Text = "n: " + key.n;
                labelE.Text = "e: " + key.e;
                labelD.Text = "d: " + key.d;
            }
            else
            {
                key = null;

                labelN.Text = "n: ERROR";
                labelE.Text = "e: ERROR";
                labelD.Text = "d: ERROR";
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            double plain;

            try
            {
                plain = Convert.ToDouble(textBoxPlainIn.Text);
            }
            catch
            {
                MessageBox.Show("Enter a valid number as plaintext!", "Input Error");
                return;
            }

            if (key == null)
            {
                MessageBox.Show("Generate a proper key first!", "Input Error");
                return;
            }

            BigInteger a = new BigInteger(Math.Pow(plain, key.e));
            BigInteger b = new BigInteger(key.n);

            cipherTextIn = (int) (a % b);
            textBoxCipherIn.Text = cipherTextIn.ToString();
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (key == null)
            {
                MessageBox.Show("Generate a proper key first!", "Input Error");
                return;
            }

            BigInteger cipher = new BigInteger(cipherTextIn);
            BigInteger bigN = new BigInteger(Convert.ToInt64(key.n));

            textBoxDecrypted.Text = (CryptoMath.BigPow(cipher, key.d) % bigN).ToString();
        }

        private int GetRefTime ()
        {
            return (DateTime.Now.Day * 86400000) + (DateTime.Now.Hour * 3600000) + (DateTime.Now.Minute * 60000) + (DateTime.Now.Second * 1000) + DateTime.Now.Millisecond;
        }

        private void buttonBruteForce_Click(object sender, EventArgs e)
        {
            buttonGenerate_Click(null, null);
            buttonEncrypt_Click(null, null);

            if (key == null)
            {
                MessageBox.Show("Generate a proper key first!", "Input Error");
                return;
            }

            if (cipherTextIn == -1)
            {
                MessageBox.Show("Generate a ciphertext first!", "Input Error");
                return;
            }

            try
            {
                timer.Stop();
            }
            catch
            { }

            if (bf != null)
            {
                bf.findNumber.Abort();
            }

            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 100;
            timer.Start();

            bf = new BruteForce(key.n, key.e, cipherTextIn);
            bf.StartAttack();
            progressBar1.MarqueeAnimationSpeed = 10;

            bf.refTime = GetRefTime();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!bf.doneA)
            {
                bf.timeTaken += GetRefTime() - bf.refTime;
                bf.refTime = GetRefTime();
                numericUpDown1.Value = (int) (bf.timeTaken / 1000);
            }

            labelOutP.Text = "p: " + bf.p;
            labelOutQ.Text = "q: " + bf.q;
            labelOutD.Text = "d: " + bf.d;
            labelOutPlain.Text = "Plaintext: " + bf.plaintext;

            if (bf.doneA)
            {
                progressBar1.MarqueeAnimationSpeed = 0;
                if (!bf.saved)
                {
                    AppendResults(bf);
                    bf.saved = true;
                }
            }

            if (bf.doneB)
            {
                timer.Stop();
            }
        }

        private void AppendResults(BruteForce instance)
        {
            rl.Add(new Results(instance.p, instance.q, instance.timeTaken));
            SaveResults();
        }
    }

    [Serializable]
    public class Fields
    {
        public int p;
        public int q;
        public int plain;

        public Fields(int p, int q, int plain)
        {
            this.p = p;
            this.q = q;
            this.plain = plain;
        }

        public Fields()
        { }
    }

    [Serializable]
    public class Results
    {
        public int p;
        public int q;
        public int time;

        public Results(int p, int q, int t)
        {
            this.p = p;
            this.q = q;
            this.time = t;
        }

        public Results()
        { }
    }
}

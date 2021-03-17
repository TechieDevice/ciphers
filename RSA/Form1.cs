using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static bool isSimple(BigInteger A)
        {

            for (int i = 2; i < A/2; i++)
            {
                if (A % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static bool EvklidAlgoritm(BigInteger A, BigInteger B)
        {
            while ((A != 0) && (B != 0))
            {
                if (A > B) A = A % B;
                else B = B % A;
            }
            return ((A + B) == 1);
        }

        private static BigInteger[] GenerateKeys()
        {
            Random rnd = new Random();
            BigInteger p, q;
            BigInteger[] n = new BigInteger[3];
            Byte[] bt = new Byte[4];

            rnd.NextBytes(bt);
            p = BitConverter.ToUInt32(bt, 0);
            while (isSimple(p) == false)
            {
                rnd.NextBytes(bt);
                p = BitConverter.ToUInt32(bt, 0);
            }

            rnd.NextBytes(bt);
            q = BitConverter.ToUInt32(bt, 0);
            while (isSimple(q) == false)
            {
                rnd.NextBytes(bt);
                q = BitConverter.ToUInt32(bt, 0);
            }

            n[0] = p * q;
            n[1] = (p - 1) * (q - 1);

            n[2] = 3;
            while (EvklidAlgoritm(n[2], n[1]) == false)
            {
                n[2] = n[2] + 2;
            }
            

            return n;
        }

        private static BigInteger getD(BigInteger E, BigInteger fn)
        {
            BigInteger D = 1;
            BigInteger b = fn, a = E, c;
            List<BigInteger> A = new List<BigInteger>();
            List<BigInteger> B = new List<BigInteger>();
            List<BigInteger> C = new List<BigInteger>();
            A.Add(a);
            B.Add(b);
            C.Add(1);

            while (a != 1)
            {
                while (a < b)
                {
                    b = b - a;
                }

                c = b;
                b = a;
                a = c;
                A.Add(a);
                B.Add(b);
                if (C[C.Count - 1] == 1) { C.Add(-1); }
                else { C.Add(1); }
            }

            while (A.Count != 0)
            {
                D = (B[B.Count - 1] * D + C[C.Count - 1]) / A[A.Count - 1];
                A.RemoveAt(A.Count - 1);
                B.RemoveAt(B.Count - 1);
                C.RemoveAt(C.Count - 1);
            }

            return D % fn;
        }

        private void GetKeysButton_Click(object sender, EventArgs e)
        {
            BigInteger[] n = new BigInteger[3]; 
            n = GenerateKeys();
            

            BigInteger E = n[2];
            BigInteger D = getD(E, n[1]);

            nOpenBox.Text = Convert.ToString(n[0]);
            nCloseBox.Text = Convert.ToString(n[0]);
            eBox.Text = Convert.ToString(E);
            dBox.Text = Convert.ToString(D);
        }

        private void DecryptionButton_Click(object sender, EventArgs e)
        {
            string str = encryptBox.Text;
            string encStr = "kostil";
            BigInteger origInt;
            BigInteger encInt;

            for (int i = 0; i < str.Length; i++)
            {

                origInt = Convert.ToUInt64(str[i]);
                encInt = BigInteger.ModPow(origInt, Convert.ToUInt64(eBox.Text), Convert.ToUInt64(nOpenBox.Text));
                if (encStr == "kostil")
                {
                    encStr = Convert.ToString(encInt) + ' ';
                }
                else
                {
                    encStr = encStr + Convert.ToString(encInt) + ' ';
                }
            }


            decryptBox.Text = encStr;
        }

        private void EncriptionButton_Click(object sender, EventArgs e)
        {
            string str = encryptBox.Text;
            string[] strMas;
            string[] emp = new string[] { " " };
            string encStr = "kostil";
            BigInteger origInt;
            BigInteger encInt;

            strMas = str.Split(emp, System.StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < str.Length; i++)
            {

                origInt = Convert.ToUInt64(strMas[i]);
                encInt = BigInteger.ModPow(origInt, Convert.ToUInt64(dBox.Text), Convert.ToUInt64(nCloseBox.Text));

                if (encStr == "kostil")
                {
                    encStr = Convert.ToString(encInt);
                }
                else
                {
                    encStr = encStr + Convert.ToString(encInt);
                }
            }


            decryptBox.Text = encStr;
        }
    }
}

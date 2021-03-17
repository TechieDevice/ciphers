using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shifrHilla
{
    public partial class mainForm : Form
    {
        private long[,] keyA;
        private long[,] keyB;

        public mainForm()
        {
            InitializeComponent();
        }

        private static long getDet(long[,] A)
        {
            long det = (A[0, 0] * A[1, 1] * A[2, 2] + A[1, 0] * A[0, 2] * A[2, 1] + A[0, 1] * A[1, 2] * A[2, 0] - (A[0, 2] * A[1, 1] * A[2, 0] + A[0, 0] * A[1, 2] * A[2, 1] + A[0, 1] * A[1, 0] * A[2, 2])) % 65521;
            if (det < 0) det = det + 65521;
            return det;
        }

        private static long getDet0(long det)
        {
            long det0 = 1;
            long b = 65521, a = det, c;
            List<long> A = new List<long>();
            List<long> B = new List<long>();
            List<long> C = new List<long>();
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
                det0 = (B[B.Count - 1] * det0 + C[C.Count - 1]) / A[A.Count - 1];
                A.RemoveAt(A.Count - 1);
                B.RemoveAt(B.Count - 1);
                C.RemoveAt(C.Count - 1);
            }

            return det0 % 65521;
        }

        private static long[,] getKey0(long[,] key)
        {
            long[,] key0 = new long[3, 3];
            long[,] min = new long[3, 3];
            long keyDet, keyDet0;

            min[0, 0] = (key[1, 1] * key[2, 2] - key[1, 2] * key[2, 1]) % 65521;
            if (min[0, 0] < 0) min[0, 0] = min[0, 0] + 65521;
            min[0, 1] = (-1*(key[1, 0] * key[2, 2] - key[1, 2] * key[2, 0])) % 65521;
            if (min[0, 1] < 0) min[0, 1] = min[0, 1] + 65521;
            min[0, 2] = (- key[1, 1] * key[2, 0] + key[1, 0] * key[2, 1]) % 65521;
            if (min[0, 2] < 0) min[0, 2] = min[0, 2] + 65521;
            min[1, 0] = (-1*(key[0, 1] * key[2, 2] - key[0, 2] * key[2, 1])) % 65521;
            if (min[1, 0] < 0) min[1, 0] = min[1, 0] + 65521;
            min[1, 1] = (key[0, 0] * key[2, 2] - key[0, 2] * key[2, 0]) % 65521;
            if (min[1, 1] < 0) min[1, 1] = min[1, 1] + 65521;
            min[1, 2] = (-1*(- key[0, 1] * key[2, 0] + key[0, 0] * key[2, 1])) % 65521;
            if (min[1, 2] < 0) min[1, 2] = min[1, 2] + 65521;
            min[2, 0] = (- key[1, 1] * key[0, 2] + key[1, 2] * key[0, 1]) % 65521;
            if (min[2, 0] < 0) min[2, 0] = min[2, 0] + 65521;
            min[2, 1] = (-1*(- key[1, 0] * key[0, 2] + key[1, 2] * key[0, 0])) % 65521;
            if (min[2, 1] < 0) min[2, 1] = min[2, 1] + 65521;
            min[2, 2] = (key[1, 1] * key[0, 0] - key[1, 0] * key[0, 1]) % 65521;
            if (min[2, 2] < 0) min[2, 2] = min[2, 2] + 65521;

            for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < 3; n++)
                {
                    key0[m, n] = min[n, m];
                }
            }

            keyDet = getDet(key);
            keyDet0 = getDet0(keyDet);

            for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < 3; n++)
                {
                    key0[m, n] = (key0[m, n] * keyDet0) % 65521;
                }
            }

            return key0;
        }

        private static long[,] mulKeys(long[,] key1, long[,] key2)
        {
            long[,] key = new long[3,3];

            for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < 3; n++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        key[m, n] = (key[m, n] + key2[m, i] * key1[i, n]) % 65521;
                    }
                }
            }
            return key;
        }

        private static long[,] mulKeys0(long[,] key1, long[,] key2)
        {
            long[,] key = new long[3, 3];

            for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < 3; n++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        key[m, n] = (key[m, n] + key1[m, i] * key2[i, n]) % 65521;
                    }
                }
            }
            return key;
        }

        private void DecryptionButton_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                rekurentniy_decryption();
            }
            else
            {
                ne_rekurentniy_decryption();
            }
        }

        private void EncryptionButton_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                rekurentniy_encryption();
            }
            else
            {
                ne_rekurentniy_encryption();
            }
        }

        private void ne_rekurentniy_encryption()
        {
            long[,] key = keyA;
            long[] text = new long[3];

            string str = enterConsole.Text;
            string encStr = "kostil";
            long encInt;
            char encChar;

            for (int i = 0; i < str.Length; i = i + 3)
            {
                text[0] = Convert.ToInt32(str[i]);
                if (i + 1 < str.Length)
                {
                    text[1] = Convert.ToInt32(str[i + 1]);
                }
                else
                {
                    text[1] = 0;
                }
                if (i + 2 < str.Length)
                {
                    text[2] = Convert.ToInt32(str[i + 2]);
                }
                else
                {
                    text[2] = 0;
                }

                for (int m = 0; m < 3; m++)
                {
                    encInt = 0;

                    for (int n = 0; n < 3; n++)
                    {
                        encInt = encInt + key[m, n] * text[n];
                    }

                    encChar = Convert.ToChar(encInt % 65521);
                    if (encStr == "kostil")
                    {
                        encStr = Convert.ToString(encChar);
                    }
                    else
                    {
                        encStr = encStr + Convert.ToString(encChar);
                    }
                }
            }

            encryptionConsole.Text = encStr;
        }

        private void ne_rekurentniy_decryption()
        {
            long[,] key0 = getKey0(keyA);
            long[] text = new long[3];

            string str = enterConsole.Text;
            string encStr = "kostil";
            long encInt;
            char encChar;

            for (int i = 0; i < str.Length; i = i + 3)
            {
                text[0] = Convert.ToInt32(str[i]);
                if (i + 1 < str.Length)
                {
                    text[1] = Convert.ToInt32(str[i + 1]);
                }
                else
                {
                    text[1] = 0;
                }
                if (i + 2 < str.Length)
                {
                    text[2] = Convert.ToInt32(str[i + 2]);
                }
                else
                {
                    text[2] = 0;
                }


                for (int m = 0; m < 3; m++)
                {
                    encInt = 0;

                    for (int n = 0; n < 3; n++)
                    {
                        encInt = encInt + key0[m, n] * text[n];
                    }

                    encChar = Convert.ToChar(encInt % 65521);
                    if (encStr == "kostil")
                    {
                        encStr = Convert.ToString(encChar);
                    }
                    else
                    {
                        encStr = encStr + Convert.ToString(encChar);
                    }
                }
            }

            encryptionConsole.Text = encStr;
        }

        private void rekurentniy_encryption()
        {
            long[,] key1 = keyA;
            long[,] key2 = keyB;
            long[] text = new long[3];
            long[,] key;

            string str = enterConsole.Text;
            string encStr = "kostil";
            long encInt;
            char encChar;

            for (int i = 0; i < str.Length; i = i + 3)
            {
                text[0] = Convert.ToInt32(str[i]);
                if (i + 1 < str.Length)
                {
                    text[1] = Convert.ToInt32(str[i + 1]);
                }
                else
                {
                    text[1] = 0;
                }
                if (i + 2 < str.Length)
                {
                    text[2] = Convert.ToInt32(str[i + 2]);
                }
                else
                {
                    text[2] = 0;
                }

                if (i == 0)
                {
                    key = key1;

                }
                else if (i == 3)
                {
                    key = key2;
                }
                else
                {
                    key = mulKeys(key1, key2);
                    key1 = key2;
                    key2 = key;
                }

                for (int m = 0; m < 3; m++)
                {
                    encInt = 0;

                    for (int n = 0; n < 3; n++)
                    {
                        encInt = encInt + key[m, n] * text[n];
                    }

                    encChar = Convert.ToChar(encInt % 65521);
                    if (encStr == "kostil")
                    {
                        encStr = Convert.ToString(encChar);
                    }
                    else
                    {
                        encStr = encStr + Convert.ToString(encChar);
                    }
                }
            }

            encryptionConsole.Text = encStr;
        }

        private void rekurentniy_decryption()
        {
            long[,] key1 = getKey0(keyA);
            long[,] key2 = getKey0(keyB);
            long[] text = new long[3];
            long[,] key0;

            string str = enterConsole.Text;
            string encStr = "kostil";
            long encInt;
            char encChar;

            for (int i = 0; i < str.Length; i = i + 3)
            {
                text[0] = Convert.ToInt32(str[i]);
                if (i + 1 < str.Length)
                {
                    text[1] = Convert.ToInt32(str[i + 1]);
                }
                else
                {
                    text[1] = 0;
                }
                if (i + 2 < str.Length)
                {
                    text[2] = Convert.ToInt32(str[i + 2]);
                }
                else
                {
                    text[2] = 0;
                }

                if (i == 0)
                {
                    key0 = key1;

                }
                else if (i == 3)
                {
                    key0 = key2;
                }
                else
                {
                    key0 = mulKeys0(key1, key2);
                    key1 = key2;
                    key2 = key0;
                }

                for (int m = 0; m < 3; m++)
                {
                    encInt = 0;

                    for (int n = 0; n < 3; n++)
                    {
                        encInt = encInt + key0[m, n] * text[n];
                    }

                    encChar = Convert.ToChar(encInt % 65521);
                    if (encStr == "kostil")
                    {
                        encStr = Convert.ToString(encChar);
                    }
                    else
                    {
                        encStr = encStr + Convert.ToString(encChar);
                    }
                }
            }

            encryptionConsole.Text = encStr;
        }

        private void GenKeyButton_Click(object sender, EventArgs e)
        {
            Random Ran = new Random();
            string str = "kostil";
            long[,] key = new long[3, 3] { { Ran.Next(65521), Ran.Next(65521), Ran.Next(65521) }, { Ran.Next(65521), Ran.Next(65521), Ran.Next(65521) }, { Ran.Next(65521), Ran.Next(65521), Ran.Next(65521) } };
            while (getDet(key) == 0)
            {
                key = new long[3, 3] { { Ran.Next(65521), Ran.Next(65521), Ran.Next(65521) }, { Ran.Next(65521), Ran.Next(65521), Ran.Next(65521) }, { Ran.Next(65521), Ran.Next(65521), Ran.Next(65521) } };
            }
            for (int m = 0; m < 3; m++)
            {
                for (int n = 0; n < 3; n++)
                {
                    if (str == "kostil")
                    {
                        str = key[m, n] + "   ";
                    }
                    else
                    {
                        str = str + key[m, n] + "   ";
                    }                   
                }
                str = str + "\r\n";
            }

            keyBox1.Text = str;
            keyA = key;

            str = "kostil";

            if (checkBox.Checked == true)
            {
                key = new long[3, 3] { { Ran.Next(65521), Ran.Next(65521), Ran.Next(65521) }, { Ran.Next(65521), Ran.Next(65521), Ran.Next(65521) }, { Ran.Next(65521), Ran.Next(65521), Ran.Next(65521) } };
                while (getDet(key) == 0)
                {
                    key = new long[3, 3] { { Ran.Next(65521), Ran.Next(65521), Ran.Next(65521) }, { Ran.Next(65521), Ran.Next(65521), Ran.Next(65521) }, { Ran.Next(65521), Ran.Next(65521), Ran.Next(65521) } };
                }
                for (int m = 0; m < 3; m++)
                {
                    for (int n = 0; n < 3; n++)
                    {
                        if (str == "kostil")
                        {
                            str = key[m, n] + "   ";
                        }
                        else
                        {
                            str = str + key[m, n] + "   ";
                        }
                    }
                    str = str + "\r\n";
                }

                keyBox2.Text = str;
                keyB = key;
            }
        }

        private void CheckKey_Click(object sender, EventArgs e)
        {
            string strKey = keyBox1.Text;
            string strKeyNumber = "" + strKey[0];
            long[,] key = new long[3, 3];
            long m = 0, n = 0;

            for (int i = 0; i < strKey.Length;)
            {
                while (strKeyNumber[strKeyNumber.Length - 1] != ' ')
                {
                    i++;
                    strKeyNumber = strKeyNumber + strKey[i];
                }

                key[m, n] = Convert.ToInt32(strKeyNumber);
                n = n + 1;
                if (n == 3)
                {
                    m = m + 1;
                    n = 0;
                }
                i = i + 3;
                strKeyNumber = "" + strKey[i];
                if (strKey[i + 1] == '\r')
                {
                    i = i + 2;
                }
                if (m == 3) break;
            }

            if (getDet(key) == 0)
            {
                keyBox1.Text = "wrong key";
            }
            else
            {
                keyA = key;
            }


            if (checkBox.Checked == true)
            {
                strKey = keyBox2.Text;
                strKeyNumber = "" + strKey[0];
                key = new long[3, 3];
                m = 0; n = 0;
                for (int i = 0; i < strKey.Length;)
                {
                    while (strKeyNumber[strKeyNumber.Length - 1] != ' ')
                    {
                        i++;
                        strKeyNumber = strKeyNumber + strKey[i];
                    }

                    key[m, n] = Convert.ToInt32(strKeyNumber);
                    n = n + 1;
                    if (n == 3)
                    {
                        m = m + 1;
                        n = 0;
                    }
                    i = i + 3;
                    strKeyNumber = "" + strKey[i];
                    if (strKey[i + 1] == '\r')
                    {
                        i = i + 2;
                    }
                    if (m == 3) break;
                }

                if (getDet(key) == 0)
                {
                    keyBox2.Text = "wrong key";
                }
                else
                {
                    keyB = key;
                }
            }
        }
    }
}

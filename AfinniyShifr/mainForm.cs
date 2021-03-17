using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfinniyShifr
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private static long getAlf0(long b)
        {
            long x2 = 1;
            long x1 = 0;
            long y1 = 1;
            long y2 = 0;
            long y, x, q, r;
            long a = 65521;
            while (b > 0)
            {
                q = a / b;
                r = a - q * b;
                x = x2 - q * x1;
                y = y2 - q * y1;
                a = b;
                b = r;
                x2 = x1;
                x1 = x;
                y2 = y1;
                y1 = y;
            }
            y = y2;
            while(y < 0)
            {
                y = y + 65521;
            }
            return y;
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                rekurentniy_decryptinon();
            }
            else
            {
                ne_rekurentniy_decryptinon();
            }
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                rekurentniy_encryptinon();
            }
            else
            {
                ne_rekurentniy_encryptinon();
            }
        }

        private void rekurentniy_encryptinon()
        {
            string str = encryptBox.Text;
            string encStr = "kostil";
            long origInt;
            long encInt;
            char encChar;
            long alf;
            long alf1 = Convert.ToInt32(alf1Box.Text);
            long alf2 = Convert.ToInt32(alf2Box.Text);
            int betta;
            int betta1 = Convert.ToInt32(betta1Box.Text);
            int betta2 = Convert.ToInt32(betta2Box.Text);

            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0)
                {
                    alf = alf1;
                    betta = betta1;
                }
                else if (i == 1)
                {
                    alf = alf2;
                    betta = betta2;
                }
                else
                {
                    alf = (alf1 * alf2) % 65521;
                    betta = (betta1 + betta2) % 65521;
                    alf1 = alf2;
                    betta1 = betta2;
                    alf2 = alf;
                    betta2 = betta;
                }
                origInt = Convert.ToInt32(str[i]);
                encInt = (origInt * alf + betta) % 65521;
                encChar = Convert.ToChar(encInt);
                if (encStr == "kostil")
                {
                    encStr = Convert.ToString(encChar);
                }
                else
                {
                    encStr = encStr + Convert.ToString(encChar);
                }
            }


            decryptBox.Text = encStr;
        }

        private void rekurentniy_decryptinon()
        {
            string str = encryptBox.Text;
            string encStr = "kostil";
            long origInt;
            long encInt;
            char encChar;
            long alf;
            long alf0;
            long alf1 = Convert.ToInt32(alf1Box.Text);
            long alf2 = Convert.ToInt32(alf2Box.Text);
            int betta;
            int betta1 = Convert.ToInt32(betta1Box.Text);
            int betta2 = Convert.ToInt32(betta2Box.Text);

            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0)
                {
                    alf = alf1;
                    betta = betta1;
                    alf0 = getAlf0(alf);
                }
                else if (i == 1)
                {
                    alf = alf2;
                    betta = betta2;
                    alf0 = getAlf0(alf);
                }
                else
                {
                    alf = (alf1 * alf2) % 65521;
                    betta = (betta1 + betta2) % 65521;
                    alf1 = alf2;
                    betta1 = betta2;
                    alf2 = alf;
                    betta2 = betta;
                    alf0 = getAlf0(alf);
                }
                origInt = Convert.ToInt32(str[i]);
                if ((origInt - betta) < 0)
                {
                    origInt = origInt + 65521;
                }
                encInt = alf0 * (origInt - betta) % 65521;
                encChar = Convert.ToChar(encInt);
                if (encStr == "kostil")
                {
                    encStr = Convert.ToString(encChar);
                }
                else
                {
                    encStr = encStr + Convert.ToString(encChar);
                }
            }


            decryptBox.Text = encStr;
        }

        private void ne_rekurentniy_encryptinon()
        {
            string str = encryptBox.Text;
            string encStr = "kostil";
            long origInt;
            long encInt;
            char encChar;
            long alf;
            long alf1 = Convert.ToInt32(alf1Box.Text);
            int betta;
            int betta1 = Convert.ToInt32(betta1Box.Text);

            for (int i = 0; i < str.Length; i++)
            {
                alf = alf1;
                betta = betta1;
                
                origInt = Convert.ToInt32(str[i]);
                encInt = (origInt * alf + betta) % 65521;
                encChar = Convert.ToChar(encInt);
                if (encStr == "kostil")
                {
                    encStr = Convert.ToString(encChar);
                }
                else
                {
                    encStr = encStr + Convert.ToString(encChar);
                }
            }


            decryptBox.Text = encStr;
        }

        private void ne_rekurentniy_decryptinon()
        {
            string str = encryptBox.Text;
            string encStr = "kostil";
            //char[] origCharArr;
            long origInt;
            long encInt;
            char encChar;
            long alf;
            long alf0;
            long alf1 = Convert.ToInt32(alf1Box.Text);
            int betta;
            int betta1 = Convert.ToInt32(betta1Box.Text);

            for (int i = 0; i < str.Length; i++)
            {
                alf = alf1;
                betta = betta1;
                alf0 = getAlf0(alf);

                origInt = Convert.ToInt32(str[i]);
                if ((origInt - betta) < 0)
                {
                    origInt = origInt + 65521;
                }
                encInt = alf0 * (origInt - betta) % 65521;
                encChar = Convert.ToChar(encInt);
                if (encStr == "kostil")
                {
                    encStr = Convert.ToString(encChar);
                }
                else
                {
                    encStr = encStr + Convert.ToString(encChar);
                }
            }


            decryptBox.Text = encStr;
        }
        //65521
    }
}

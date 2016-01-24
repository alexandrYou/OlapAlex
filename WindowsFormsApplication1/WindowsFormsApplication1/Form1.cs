using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding(1251));
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void кодироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            byte[] bstr;

            var encoding = Encoding.GetEncoding(1251);
            bstr = Encoding.Default.GetBytes(textBox1.Text);
            for (int i = 0; i < bstr.Length; i++)
            {
                textBox2.Text = textBox2.Text + " " + System.Convert.ToString(bstr[i], 2);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox2.Text, Encoding.GetEncoding(1251));
            }
        }

        private void декодироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] bstr;
            char[] ch;
            string[] text;
            int k = 0;
            ch = textBox2.Text.ToCharArray();
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                if (ch[i] == ' ')
                    k++;
            }
            k++;
            text = new string[k];
            bstr = new byte[k];
            k = 0;
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                if (ch[i] != ' ')
                {
                    text[k] = text[k] + ch[i].ToString();
                    continue;
                }
                k++;
            }

            for (int i = 0; i < k + 1; i++)
            {
                bstr[i] = Convert.ToByte(text[i], 2);
            }
            char[] ch1;
            Encoding myencoding;
            myencoding = Encoding.GetEncoding(1251);
            ch1 = myencoding.GetChars(bstr);
            for (int i = 0; i < k + 1; i++)
            {
                textBox3.Text = textBox3.Text + ch1[i].ToString();
            }
        }

        private void переводСтрокиMACToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] bstr;
            char[] ch1;

            var encoding = Encoding.GetEncoding(1251);
            bstr = Encoding.Default.GetBytes(textBox1.Text);
            int l = 0;
            for (int i = 0; i < bstr.Length; i++)
                if (bstr[i] == 10) { l = l + 1; }
            for (int i = 0; i < bstr.Length - l; i++)
            {
                if (bstr[i] == 10)
                {

                    for (int k = i; k < bstr.Length - 1; k++)
                    {
                        bstr[k] = bstr[k + 1];
                    }

                }

                textBox4.Text = textBox4.Text + " " + bstr[i];


            }


            Encoding myencoding;
            myencoding = Encoding.GetEncoding(1251);
            ch1 = myencoding.GetChars(bstr);
            for (int i = 0; i < bstr.Length; i++)
            {
                textBox9.Text = textBox9.Text + ch1[i].ToString();
            }

            for (int i = 0; i < bstr.Length - l; i++)
            {
                textBox5.Text = textBox5.Text + " " + System.Convert.ToString(bstr[i], 2);
            }
        }

        private void сохранениеMACToolStripMenuItem_Click(object sender, EventArgs e)
        {


            saveFileDialog1.AddExtension = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                byte[] bstr;
                char[] ch1;
                string str;

                FileInfo file1 = new FileInfo(saveFileDialog1.FileName);
                // StreamWriter file2 = file1.CreateText();



                var encoding = Encoding.GetEncoding(1251);
                bstr = Encoding.Default.GetBytes(textBox1.Text);
                int l = 0;

                for (int i = 0; i < bstr.Length - 1; i++)
                {
                    if (bstr[i] == 10)
                    {

                        for (int k = i; k < bstr.Length - 1; k++)
                        {
                            bstr[k] = bstr[k + 1];
                        }
                        l = l + 1;

                    }


                }



                byte[] bstr1 = new byte[bstr.Length - l];

                for (int p = 0; p < bstr.Length - l; p++)
                    bstr1[p] = bstr[p];

                Encoding myencoding;
                myencoding = Encoding.GetEncoding(1251);
                ch1 = myencoding.GetChars(bstr1);
                File.WriteAllBytes((saveFileDialog1.FileName), bstr1);





            }
        }

        private void кодироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            char[] ch;
            byte[] bstr;
            byte bstr1;
            string[] text;
            int k, o, l, p, z, t, m, g;
            var encoding = Encoding.GetEncoding(1251);
            bstr = Encoding.Default.GetBytes(textBox9.Text);


            BitArray BA = new BitArray(bstr);
            k = BA.Count;
            k = k / 7;
            o = k + BA.Count;
            BitArray BA1 = new BitArray(o);
            p = 0; z = 0; t = 1; m = 0; g = 0;
            for (int i = 0; i <= BA.Count - 1; i++)
            {
                //BA1[0] = true;
                if (i != 0) { m++; t++; }
                l = 0;
                l = i;
                l = t % 7;

                if (l != 0)
                {
                    BA1[m] = BA[i];
                    if (BA[i] == true)
                    { p++; }
                }
                else if (BA[i] == true) { p++; }

                if (l == 0)
                {
                    if (p % 2 == 0)
                    {
                        g = m - i;
                        BA1[i + g] = BA[i];
                        BA1[i + g + 1] = false; m++; p = 0;
                    }
                    else { g = m - i; BA1[i + g] = BA[i]; BA1[i + g + 1] = true; m++; p = 0; }
                }

            }

            byte[] bs11 = new byte[BA1.Count / 8 + 1];

            for (int i = 0; i < BA1.Count - 1; i++)
            {
                if (BA1[i] == true) { textBox8.Text = textBox8.Text + ("1"); } else { textBox8.Text = textBox8.Text + ("0"); }
            }

            BA1.CopyTo(bs11, 0);
            File.WriteAllBytes("code.txt", bs11);

        }



        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void проверкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            {
                byte[] bstr;
                byte bstr1;
                string[] text;
                int k, o, l, p, z, t, m, g, x;
                char[] ch1;
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(openFileDialog2.FileName, Encoding.GetEncoding(1251));
                    textBox6.Text = sr.ReadToEnd();
                    sr.Close();
                }

                var encoding = Encoding.GetEncoding(1251);
                bstr = Encoding.Default.GetBytes(textBox6.Text);
                BitArray BA = new BitArray(bstr);
                k = BA.Count;
                k = k / 8;
                o = BA.Count - k;

                BitArray BA1 = new BitArray(o + 1);
                p = 0; z = 0; t = 1; m = 0; g = 0; x = 0;
                for (int i = 0; i <= o - 1; i++)
                {
                    if (x == 7) { z++; x = 0; }
                    if (i != 0) { t++; g++; }
                    l = 0;
                    l = i;
                    l = t % 8;

                    if (l != 0)
                    {
                        if (BA[i] == true)
                        { p++; BA1[g] = BA[i + z]; }
                        else if (BA[i] == false) { BA1[g] = BA[i + z]; }
                    }
                    // else if (BA[i] == true) { p++; BA1[g] = BA[i]; }
                    x++;

                    if (l == 0)
                    {
                        m++;

                        if (p % 2 == 0)
                        {
                            if (BA[i] == false)
                            {
                                //z++;
                                BA1[g] = BA[i + z]; p = 0;
                            }
                            else
                            {
                                textBox7.Text = ("Ошибка в файле в " + z + " букве"); p = 0;
                            }
                        }
                        else
                        {
                            if (p % 2 != 0)
                            {
                                if (BA[i] == true)
                                {
                                    //z++;
                                    BA1[g] = BA[i + z]; p = 0;
                                }
                                else
                                {
                                    textBox7.Text = ("Ошибка в файле в " + z + " букве"); p = 0;
                                }
                            }

                        }
                    }

                }
                byte[] bs11 = new byte[BA1.Count / 8 + 1];
                //BA1.Not();
                BA1.CopyTo(bs11, 0);
                File.WriteAllBytes("decod.txt", bs11);
                Encoding myencoding;
                myencoding = Encoding.GetEncoding(1251);
                ch1 = myencoding.GetChars(bs11);
                for (int i = 0; i < BA1.Count / 8 + 1; i++)
                {
                    textBox7.Text = textBox7.Text + ch1[i].ToString();
                }




            }



        }

        private void передатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            byte[] bstr;
            var encoding = Encoding.GetEncoding(1251);
            bstr = Encoding.Default.GetBytes(textBox8.Text);
            for (int i = 0; i <= textBox8.Text.Length-1; i++)
            {
                if (bstr[i] == '0')
                { textBox10.Text = textBox10.Text + ("_"); }
                else { textBox10.Text = textBox10.Text + ("-"); }

            }



        }

        private void декодироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           byte[] bstr;
                byte bstr1;
                string[] text;
                int k, o, l, p, z, t, m, g, x;
                char[] ch1;
            var encoding = Encoding.GetEncoding(1251);
            bstr = Encoding.Default.GetBytes(textBox10.Text);
            BitArray BA = new BitArray(bstr.Length);
            for (int i = 0; i <= textBox10.Text.Length - 1; i++)
            
            {
                if (bstr[i] == '_')
                { textBox11.Text = textBox11.Text + ("0");BA[i]=false; }
                else { textBox11.Text = textBox11.Text + ("1");BA[i]=true; }

            }
        


            //BitArray BA = new BitArray(bstr);
                k = BA.Count;
                k = k / 8;
                o = BA.Count - k;

                BitArray BA1 = new BitArray(o + 1);
                p = 0; z = 0; t = 1; m = 0; g = 0; x = 0;
                for (int i = 0; i <= o - 1; i++)
                {
                    if (x == 7) { z++; x = 0; }
                    if (i != 0) { t++; g++; }
                    l = 0;
                    l = i;
                    l = t % 8;

                    if (l != 0)
                    {
                        if (BA[i] == true)
                        { p++; BA1[g] = BA[i + z]; }
                        else if (BA[i] == false) { BA1[g] = BA[i + z]; }
                    }
                    // else if (BA[i] == true) { p++; BA1[g] = BA[i]; }
                    x++;

                    if (l == 0)
                    {
                        m++;

                        if (p % 2 == 0)
                        {
                            if (BA[i] == false)
                            {
                                //z++;
                                BA1[g] = BA[i + z]; p = 0;
                            }
                            else
                            {
                                textBox12.Text = textBox12.Text + ("Ошибка в файле в " + z + " букве"); p = 0;
                            }
                        }
                        else
                        {
                            if (p % 2 != 0)
                            {
                                if (BA[i] == true)
                                {
                                    //z++;
                                    BA1[g] = BA[i + z]; p = 0;
                                }
                                else
                                {
                                    textBox12.Text = textBox12.Text + ("Ошибка в файле в " + z + " букве"); p = 0;
                                }
                            }

                        }
                    }

                }
                byte[] bs11 = new byte[BA1.Count / 8 + 1];
                //BA1.Not();
                BA1.CopyTo(bs11, 0);
                File.WriteAllBytes("decod_per_dan.txt", bs11);
                Encoding myencoding;
                myencoding = Encoding.GetEncoding(1251);
                ch1 = myencoding.GetChars(bs11);
                for (int i = 0; i < BA1.Count / 8 + 1; i++)
                {
                    textBox12.Text = textBox12.Text + ch1[i].ToString();
                }




           



        }

        private void сохранитьToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox10.Text, Encoding.GetEncoding(1251));
            }
        }
    }
}
  



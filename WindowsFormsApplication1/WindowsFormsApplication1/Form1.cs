using System;
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
        StreamReader sr = new StreamReader(openFileDialog1.FileName,Encoding.GetEncoding(1251));
          textBox1.Text = sr.ReadToEnd();
        sr.Close();
      } 
    }

    private void кодироватьToolStripMenuItem_Click(object sender, EventArgs e)
    {

      byte[] bstr;
      
        var encoding = Encoding.GetEncoding(1251);
        bstr=Encoding.Default.GetBytes(textBox1.Text);
      for (int i = 0; i < bstr.Length; i++)
      {
          textBox2.Text = textBox2.Text + " " + System.Convert.ToString(bstr[i],2) ;
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

        var encoding = Encoding.GetEncoding(1251);
        bstr = Encoding.Default.GetBytes(textBox1.Text);
        for (int i = 0; i < bstr.Length; i++)
        {
            textBox5.Text = textBox5.Text + " " + bstr[i];
        }
            for (int i = 0; i < bstr.Length; i++)
        {
            if (bstr[i] == 10)
            {
                bstr[i] = bstr[i + 1];
                i = i + 1;
            }
            textBox4.Text = textBox4.Text + " " + bstr[i];          
        }

        
        /*for (int i = 0; i < bstr.Length; i++)
        {
            textBox4.Text = textBox4.Text + " " + bstr[i];
        }*/
    }

    }
  }


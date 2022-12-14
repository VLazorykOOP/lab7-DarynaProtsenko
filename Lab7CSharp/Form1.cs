using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //get text from textBox1, print by random letters in richbox
            string editText = textBox1.Text;
            HashSet<char> letters = new HashSet<char>();
            foreach(char letter in editText)
            {
                letters.Add(letter);
            }
            List<char> lettersList = letters.ToList();
            int n = lettersList.Count;
            Random rng = new Random();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                char value = lettersList[k];
                lettersList[k] = lettersList[n];
                lettersList[n] = value;
            }
            string result = "";
            foreach(char letter in lettersList)
            {
                result += letter;
            }
            richTextBox1.Clear();
            richTextBox1.AppendText(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //get text form textBox1, match symbols and print all symbols without entered symbols
            HashSet<char> alphabet = new HashSet<char>();
            alphabet.Add('a');
            alphabet.Add('b');
            alphabet.Add('c');
            alphabet.Add('d');
            alphabet.Add('e');
            alphabet.Add('f');
            alphabet.Add('g');
            alphabet.Add('h');
            alphabet.Add('i');
            alphabet.Add('j');
            alphabet.Add('k');
            alphabet.Add('l');
            alphabet.Add('m');
            alphabet.Add('n');
            alphabet.Add('o');
            alphabet.Add('p');
            alphabet.Add('q');
            alphabet.Add('r');
            alphabet.Add('s');
            alphabet.Add('t');
            alphabet.Add('u');
            alphabet.Add('v');
            alphabet.Add('w');
            alphabet.Add('x');
            alphabet.Add('y');
            alphabet.Add('z');
            string editText = textBox1.Text;
            foreach (char letter in editText)
            {
                alphabet.Remove(letter);
            }
            List<char> resList = alphabet.ToList();
            string result = "";
            foreach (char letter in resList)
            {
                result += letter;
            }
            richTextBox1.Clear();
            richTextBox1.AppendText(result);

        }
    }
}

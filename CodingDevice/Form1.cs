using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingDevice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Icon = CodingDevice.Properties.Resources.cipher_case_256;
            NumberOfRotationsBox.Maximum = Alphabet.Count();
            NumberOfRotationsBox2.Maximum = Alphabet.Count();
        }
        public string[] Alphabet = { "A","Ą", "B", "C","Ć", "D", "E","Ę", "F", "G", "H", "I", "J", "K", "L","Ł", "M", "N","Ń","O","Ó","P", "Q", "R", "S", "Ś","T", "U", "V", "W", "X", "Y", "Z", "Ż", "Ź", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "/", "?", "<", ">", ",", ".", ":", ";", "|", "{", "}", "[", "]" , "a", "ą", "b", "c", "ć", "d", "e", "ę", "f", "g", "h", "i", "j", "k", "l", "ł", "m", "n", "ń", "o", "ó", "p", "r", "s", "ś", "t","u","v","w","x","y","z","ż","ź", "`", "~", "€", " ", "\"", "\'", "\\", "¡", "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "ª", "«", "»", "¬", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "¼", "½", "À", "Á", "Â"
,"Ã","Ä","Æ","Ç","È","É","Ê","Ë","Ì","Í","Ð","Ñ","Ò","Ô","Õ","Ö","×","Ø","Ù","Ú","Û","Ü"};
        public string[] CodeAlphabet = { "A", "Ą", "B", "C", "Ć", "D", "E", "Ę", "F", "G", "H", "I", "J", "K", "L", "Ł", "M", "N", "Ń", "O", "Ó", "P", "Q", "R", "S", "Ś", "T", "U", "V", "W", "X", "Y", "Z", "Ż", "Ź", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "/", "?", "<", ">", ",", ".", ":", ";", "|", "{", "}", "[", "]", "a", "ą", "b", "c", "ć", "d", "e", "ę", "f", "g", "h", "i", "j", "k", "l", "ł", "m", "n", "ń", "o", "ó", "p", "r", "s", "ś", "t", "u", "v", "w", "x", "y", "z", "ż", "ź", "`", "~", "€", " ", "\"", "\'", "\\", "¡", "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "ª", "«", "»", "¬", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "¼", "½", "À", "Á", "Â"
,"Ã" ,"Ä","Æ","Ç","È","É","Ê","Ë","Ì","Í","Ð","Ñ","Ò","Ô","Õ","Ö","×","Ø","Ù","Ú","Û","Ü"};
        public string[] CodeAlphabet2 = { "A","Ą", "B", "C","Ć", "D", "E","Ę", "F", "G", "H", "I", "J", "K", "L","Ł", "M", "N","Ń","O","Ó","P", "Q", "R", "S", "Ś","T", "U", "V", "W", "X", "Y", "Z", "Ż", "Ź", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "/", "?", "<", ">", ",", ".", ":", ";", "|", "{", "}", "[", "]" , "a", "ą", "b", "c", "ć", "d", "e", "ę", "f", "g", "h", "i", "j", "k", "l", "ł", "m", "n", "ń", "o", "ó", "p", "r", "s", "ś", "t","u","v","w","x","y","z","ż","ź", "`", "~", "€", " ", "\"", "\'", "\\", "¡", "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "ª", "«", "»", "¬", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "¼", "½", "À", "Á", "Â"
,"Ã" ,"Ä","Æ","Ç","È","É","Ê","Ë","Ì","Í","Ð","Ñ","Ò","Ô","Õ","Ö","×","Ø","Ù","Ú","Û","Ü"};
        public string[] CodeAlphabet3 = { "A","Ą", "B", "C","Ć", "D", "E","Ę", "F", "G", "H", "I", "J", "K", "L","Ł", "M", "N","Ń","O","Ó","P", "Q", "R", "S", "Ś","T", "U", "V", "W", "X", "Y", "Z", "Ż", "Ź", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "/", "?", "<", ">", ",", ".", ":", ";", "|", "{", "}", "[", "]" , "a", "ą", "b", "c", "ć", "d", "e", "ę", "f", "g", "h", "i", "j", "k", "l", "ł", "m", "n", "ń", "o", "ó", "p", "r", "s", "ś", "t","u","v","w","x","y","z","ż","ź", "`", "~", "€", " ", "\"", "\'", "\\", "¡", "¢", "£", "¤", "¥", "¦", "§", "¨", "©", "ª", "«", "»", "¬", "°", "±", "²", "³", "´", "µ", "¶", "·", "¸", "¹", "º", "¼", "½", "À", "Á", "Â"
,"Ã" ,"Ä","Æ","Ç","È","É","Ê","Ë","Ì","Í","Ð","Ñ","Ò","Ô","Õ","Ö","×","Ø","Ù","Ú","Û","Ü"};

        public void MoveLetters(int RotationNumber = 1)
        {
            for (int N = RotationNumber; N != 0; N--)
            {
                Queue CodeAlphabetQ = new Queue(CodeAlphabet);
                CodeAlphabetQ.Enqueue(CodeAlphabetQ.Dequeue());
                CodeAlphabetQ.CopyTo(CodeAlphabet, 0);
            }
        }
        public void MoveLetters2(int RotationNumber = 1)
        {
            for (int N = RotationNumber; N != 0; N--)
            {
                Queue CodeAlphabetQ = new Queue(CodeAlphabet2);
                CodeAlphabetQ.Enqueue(CodeAlphabetQ.Dequeue());
                CodeAlphabetQ.CopyTo(CodeAlphabet2, 0);
            }
        }
        public void MoveLetters3(int RotationNumber = 1)
        {
            for (int N = RotationNumber; N != 0; N--)
            {
                Queue CodeAlphabetQ = new Queue(CodeAlphabet3);
                CodeAlphabetQ.Enqueue(CodeAlphabetQ.Dequeue());
                CodeAlphabetQ.CopyTo(CodeAlphabet3, 0);
            }
        }
        public void SetCodeAlphabet()
        {
            if (ReverseBox.Checked == false)
            {
                try
                {
                    Alphabet.CopyTo(CodeAlphabet, 0);
                    int Position = Array.IndexOf(Alphabet, CodeBox.Text);
                    for (; Position > 0; Position--)
                    {
                        MoveLetters();
                    }
                }
                catch
                {
                    Alphabet.CopyTo(CodeAlphabet, 0);
                }
            }
            else
            {
                try
                {
                    Alphabet.CopyTo(CodeAlphabet, 0);
                    Array.Reverse(CodeAlphabet);
                    int Position = Array.IndexOf(Alphabet, CodeBox.Text);
                    for (; Position > 0; Position--)
                    {
                        MoveLetters();
                    }
                }
                catch
                {
                    Alphabet.CopyTo(CodeAlphabet, 0);
                    Array.Reverse(CodeAlphabet);
                }
            }
            if (NumberOfChambersNumeric.Value >= 2)
            {
                if (ReverseBox2.Checked == false)
                {
                    try
                    {
                        Alphabet.CopyTo(CodeAlphabet2, 0);
                        int Position = Array.IndexOf(Alphabet, CodeBox2.Text);
                        for (; Position > 0; Position--)
                        {
                            MoveLetters2();
                        }
                    }
                    catch
                    {
                        Alphabet.CopyTo(CodeAlphabet2, 0);
                    }
                }
                else
                {
                    try
                    {
                        Alphabet.CopyTo(CodeAlphabet2, 0);
                        Array.Reverse(CodeAlphabet2);
                        int Position = Array.IndexOf(Alphabet, CodeBox2.Text);
                        for (; Position > 0; Position--)
                        {
                            MoveLetters2();
                        }
                    }
                    catch
                    {
                        Alphabet.CopyTo(CodeAlphabet2, 0);
                        Array.Reverse(CodeAlphabet2);
                    }
                }
            }
            if (NumberOfChambersNumeric.Value >= 3)
            {
                if (ReverseBox3.Checked == false)
                {
                    try
                    {
                        Alphabet.CopyTo(CodeAlphabet3, 0);
                        int Position = Array.IndexOf(Alphabet, CodeBox3.Text);
                        for (; Position > 0; Position--)
                        {
                            MoveLetters3();
                        }
                    }
                    catch
                    {
                        Alphabet.CopyTo(CodeAlphabet3, 0);
                    }
                }
                else
                {
                    try
                    {
                        Alphabet.CopyTo(CodeAlphabet3, 0);
                        Array.Reverse(CodeAlphabet3);
                        int Position = Array.IndexOf(Alphabet, CodeBox3.Text);
                        for (; Position > 0; Position--)
                        {
                            MoveLetters3();
                        }
                    }
                    catch
                    {
                        Alphabet.CopyTo(CodeAlphabet3, 0);
                        Array.Reverse(CodeAlphabet3);
                    }
                }
            }
        }
        private void EncodeButton_Click(object sender, EventArgs e)
        {
            if (NumberOfChambersNumeric.Value == 1)
            {
                SetCodeAlphabet();
                string Text = InputBox.Text;
                char[] Arr = Text.ToCharArray();
                Text = "";
                foreach (char c in Arr)
                {
                    try
                    {
                        MoveLetters((int)NumberOfRotationsBox.Value);
                    }
                    catch
                    {
                        MoveLetters();
                    }
                    try
                    {
                        int Index = Array.IndexOf(Alphabet, c.ToString());
                        Text += CodeAlphabet.ElementAt(Index);
                    }
                    catch
                    {
                    }

                }
                textBox1.Text = Text;
                SetCodeAlphabet();
            }
            else if (NumberOfChambersNumeric.Value == 2)
            {
                int Flag = 1;
                SetCodeAlphabet();
                string Text = InputBox.Text;
                char[] Arr = Text.ToCharArray();
                Text = "";
                foreach (char c in Arr)
                {
                    if (Flag == 1)
                    {
                        Flag = 2;

                        try
                        {
                            MoveLetters((int)NumberOfRotationsBox.Value);
                        }
                        catch
                        {
                            MoveLetters();
                        }
                        try
                        {
                            int Index = Array.IndexOf(Alphabet, c.ToString());
                            Text += CodeAlphabet.ElementAt(Index);
                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        Flag = 1;
                        try
                        {
                            MoveLetters2((int)NumberOfRotationsBox2.Value);
                        }
                        catch
                        {
                            MoveLetters2();
                        }
                        try
                        {
                            int Index = Array.IndexOf(Alphabet, c.ToString());
                            Text += CodeAlphabet2.ElementAt(Index);
                        }
                        catch
                        {
                        }
                    }
                }
                textBox1.Text = Text;
                SetCodeAlphabet();
            }
            else
            {
                int Flag = 1;
                SetCodeAlphabet();
                string Text = InputBox.Text;
                char[] Arr = Text.ToCharArray();
                Text = "";
                foreach (char c in Arr)
                {
                    if (Flag == 1)
                    {
                        Flag = 2;

                        try
                        {
                            MoveLetters((int)NumberOfRotationsBox.Value);
                        }
                        catch
                        {
                            MoveLetters();
                        }
                        try
                        {
                            int Index = Array.IndexOf(Alphabet, c.ToString());
                            Text += CodeAlphabet.ElementAt(Index);
                        }
                        catch
                        {
                        }
                    }
                    else if(Flag == 2)
                    {
                        Flag = 3;
                        try
                        {
                            MoveLetters2((int)NumberOfRotationsBox2.Value);
                        }
                        catch
                        {
                            MoveLetters2();
                        }
                        try
                        {
                            int Index = Array.IndexOf(Alphabet, c.ToString());
                            Text += CodeAlphabet2.ElementAt(Index);
                        }
                        catch
                        {
                        }
                    }
                    else if (Flag == 3)
                    {
                        Flag = 1;
                        try
                        {
                            MoveLetters3((int)NumberOfRotationsBox3.Value);
                        }
                        catch
                        {
                            MoveLetters3();
                        }
                        try
                        {
                            int Index = Array.IndexOf(Alphabet, c.ToString());
                            Text += CodeAlphabet3.ElementAt(Index);
                        }
                        catch
                        {
                        }
                    }

                }
                textBox1.Text = Text;
                SetCodeAlphabet();
            }
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            if (NumberOfChambersNumeric.Value == 1)
            {
                SetCodeAlphabet();
                string Text = InputBox.Text;
                char[] Arr = Text.ToCharArray();
                Text = "";
                foreach (char c in Arr)
                {
                    try
                    {
                        MoveLetters((int)NumberOfRotationsBox.Value);
                    }
                    catch
                    {
                        MoveLetters();
                    }
                    try
                    {
                        int Index = Array.IndexOf(CodeAlphabet, c.ToString());
                        Text += Alphabet.ElementAt(Index);
                    }
                    catch
                    {
                    }

                }
                textBox1.Text = Text;
                SetCodeAlphabet();
            }
            else if (NumberOfChambersNumeric.Value == 2)
            {
                bool Flag = false;
                SetCodeAlphabet();
                string Text = InputBox.Text;
                char[] Arr = Text.ToCharArray();
                Text = "";
                foreach (char c in Arr)
                {
                    if (Flag == false)
                    {
                        Flag = true;

                        try
                        {
                            MoveLetters((int)NumberOfRotationsBox.Value);
                        }
                        catch
                        {
                            MoveLetters();
                        }
                        try
                        {
                            int Index = Array.IndexOf(CodeAlphabet, c.ToString());
                            Text += Alphabet.ElementAt(Index);
                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        Flag = false;
                        try
                        {
                            MoveLetters2((int)NumberOfRotationsBox2.Value);
                        }
                        catch
                        {
                            MoveLetters2();
                        }
                        try
                        {
                            int Index = Array.IndexOf(CodeAlphabet2, c.ToString());
                            Text += Alphabet.ElementAt(Index);
                        }
                        catch
                        {
                        }
                    }
                }
                textBox1.Text = Text;
                SetCodeAlphabet();
            }
            else
            {
                int Flag = 1;
                SetCodeAlphabet();
                string Text = InputBox.Text;
                char[] Arr = Text.ToCharArray();
                Text = "";
                foreach (char c in Arr)
                {
                    if (Flag == 1)
                    {
                        Flag = 2;

                        try
                        {
                            MoveLetters((int)NumberOfRotationsBox.Value);
                        }
                        catch
                        {
                            MoveLetters();
                        }
                        try
                        {
                            int Index = Array.IndexOf(CodeAlphabet, c.ToString());
                            Text += Alphabet.ElementAt(Index);
                        }
                        catch
                        {
                        }
                    }
                    else if(Flag == 2)
                    {
                        Flag = 3;
                        try
                        {
                            MoveLetters2((int)NumberOfRotationsBox2.Value);
                        }
                        catch
                        {
                            MoveLetters2();
                        }
                        try
                        {
                            int Index = Array.IndexOf(CodeAlphabet2, c.ToString());
                            Text += Alphabet.ElementAt(Index);
                        }
                        catch
                        {
                        }
                    }
                    else if (Flag == 3)
                    {
                        Flag = 1;
                        try
                        {
                            MoveLetters3((int)NumberOfRotationsBox3.Value);
                        }
                        catch
                        {
                            MoveLetters3();
                        }
                        try
                        {
                            int Index = Array.IndexOf(CodeAlphabet3, c.ToString());
                            Text += Alphabet.ElementAt(Index);
                        }
                        catch
                        {
                        }
                    }
                }
                textBox1.Text = Text;
                SetCodeAlphabet();
            }
        }

          }
}

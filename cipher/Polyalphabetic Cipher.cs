using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cipher
{
    public partial class PolyalphabeticCipher : Form
    {
        public PolyalphabeticCipher()
        {
            InitializeComponent();
        }

        List<char> encryptedText = new  List<char>();
        List<char> decryptedText = new List<char>();

        char[] alphabates = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] m1 = { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'p', 'o', 'i', 'u', 'y', 't', 'r', 'e', 'w', 'q', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
        char[] m2 = { 'q', 'a', 'z', 'w', 's', 'x', 'e', 'd', 'c', 'r', 'f', 'v', 't', 'g', 'b', 'y', 'h', 'n', 'u', 'p', 'j', 'm', 'i', 'k', 'o', 'l' };
        char[] m3 = { 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'k', 'i', 'o', 'p', 'l', 'u', 'j', 'h', 'y', 't', 'g', 'f', 'r', 'e', 'd', 's', 'w', 'q', 'a' };

        public void doEncryption(string text)
        {
            int keyCounter = 0;
            char[] charArray = text.ToArray();

            for (int i = 0; i < charArray.Count(); i++)
            {
                for (int j = 0; j < alphabates.Count(); j++)
                {
                    try
                    {
                        if ((charArray[i] == alphabates[j]) && keyCounter == 0)
                        {
                            encryptedText.Add(m1[j]);
                            keyCounter++;
                            break;
                        }

                        if ((charArray[i] == alphabates[j]) && keyCounter == 1)
                        { 
                            encryptedText.Add(m2[j]);
                            keyCounter++;
                            break;
                        }

                        if ((charArray[i] == alphabates[j]) && keyCounter == 2)
                        {
                            encryptedText.Add(m3[j]);
                            keyCounter++;
                            break;
                        }

                        else if (charArray[i] == ' ')
                        {
                            encryptedText.Add(' ');
                            break;
                        }
                    }
                    catch (Exception) { };
                }

                if (keyCounter == 3)
                    keyCounter = 0;
            }
        }

        public void doDecryption(string text)
        {
            int keyCounter = 0;
            char[] charArray = text.ToArray();

            for (int i = 0; i < charArray.Count(); i++)
            {
                for (int j = 0; j < alphabates.Count(); j++)
                {
                    try
                    {
                        if ((charArray[i] == m1[j]) && keyCounter == 0)
                        {
                            decryptedText.Add(alphabates[j]);
                            keyCounter++;
                            break;
                        }

                        if ((charArray[i] == m2[j]) && keyCounter == 1)
                        {
                            decryptedText.Add(alphabates[j]);
                            keyCounter++;
                            break;
                        }

                        if ((charArray[i] == m3[j]) && keyCounter == 2)
                        {
                            decryptedText.Add(alphabates[j]);
                            keyCounter++;
                            break;
                        }

                        else if (charArray[i] == ' ')
                        {
                            decryptedText.Add(' ');
                            break;
                        }
                    }
                    catch (Exception) { };
                }

                if (keyCounter == 3)
                    keyCounter = 0;
            }
        }

        private void encrypt_BTN_Click(object sender, EventArgs e)
        {
            doEncryption(inputText_TB.Text);
            string encrypt = string.Join("", encryptedText);
            encryptedText_TB.Text = encrypt;
            encryptedText.Clear();
        }

        private void decrypt_BTN_Click(object sender, EventArgs e)
        {
            doDecryption(encryptedText_TB.Text);
            string decrypt = string.Join("", decryptedText);
            decryptedText_TB.Text = decrypt;
            decryptedText.Clear();
        }

        private void inputText_TB_TextChanged(object sender, EventArgs e)
        {
            encryptedText.Clear();
            decryptedText.Clear();

            encryptedText_TB.Clear();
            decryptedText_TB.Clear();
        }
    }
}

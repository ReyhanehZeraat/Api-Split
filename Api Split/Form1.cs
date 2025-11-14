using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Api_Split
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnListOfWord_Click(object sender, EventArgs e)
        {
            if (TxtCharacter != null)
            {
                string InputSentence = TxtSentence.Text;
                string InputCharacter = TxtCharacter.Text;
                char Character = InputCharacter[0];
                var Words = InputSentence.Split(' ');
                foreach (var item in Words)
                {
                    string WordsInSentence = item;
                    foreach (char CharacterInWord in WordsInSentence)
                    {
                        if (CharacterInWord == Character)
                        {
                            LbiListOfWords.Text += WordsInSentence + " ";
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا موارد خواسته شده را وارد کنید");
            }
        }

        private void BtnNumberOfLetter_Click(object sender, EventArgs e)
        {
            if (TxtCharacter != null)
            {
                int NumberOfLetter = 0;
                string InputSentence = TxtSentence.Text;
                string InputCharacter = TxtCharacter.Text;
                char Character = InputCharacter[0];
                var Words = InputSentence.Split(' ');
                foreach (var item in Words)
                {
                    string WordsInSentence = item;
                    foreach (char CharacterInWord in WordsInSentence)
                    {
                        if (CharacterInWord == Character)
                        {
                            NumberOfLetter++;

                        }
                    }
                }
                LbiNumberOfLetters.Text += NumberOfLetter.ToString();
            }
            else
            {
                MessageBox.Show("لطفا موارد خواسته شده را وارد کنید");
            }
        }

        private void BtnNumberOfWord_Click(object sender, EventArgs e)
        {
            if (TxtCharacter != null)
            {
                int NumberOfWord = 0;
                string InputSentence = TxtSentence.Text;
                string InputCharacter = TxtCharacter.Text;
                char Character = InputCharacter[0];
                var Words = InputSentence.Split(' ');
                foreach (var item in Words)
                {
                    string WordsInSentence = item;
                    foreach (char CharacterInWord in WordsInSentence)
                    {
                        if (CharacterInWord == Character)
                        {
                            NumberOfWord++;
                            break;
                        }
                    }
                }
                LbiNumberOfWords.Text += NumberOfWord.ToString();
            }
            else
            {
                MessageBox.Show("لطفا موارد خواسته شده را وارد کنید");
            }
        }
    }
}

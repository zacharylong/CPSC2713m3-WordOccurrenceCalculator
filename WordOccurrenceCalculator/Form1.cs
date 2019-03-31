using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordOccurrenceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Onclick, take a list of strings as input from textbox
            //split into a list of words
            //pass to wordcalculator
            //display in label
            //each wordoccurence item will be a separate line

            //https://docs.microsoft.com/en-us/dotnet/csharp/how-to/parse-strings-using-split

            String string1 = textBox1.Text;
            String[] splitArray = string1.Split(' ');   //' ' character literal separator for words

            //store string array as arraylist for processing
            System.Collections.ArrayList stringAsArrayList = new System.Collections.ArrayList();
            for (int i = 0; i < string1.Length; i++)
            {
                stringAsArrayList.Add(splitArray[i]);
            }

            //pass to wordcalculator as a wordoccurrence
            WordOccurrence[] wordOccur = WordCalculator.calculateOccurrences(stringAsArrayList);

            //build string for each result of count
            String resultString = "";

            //each wordoccurence item will be a separate line
            for (int i = 0; i < wordOccur.Length; i++)
            {
                string countResult = wordOccur[i].word + "=" + wordOccur[i].count + " ";
                resultString = resultString + countResult;
            }

            //label
            resultLabel.Text = resultString;

        }
    }
}

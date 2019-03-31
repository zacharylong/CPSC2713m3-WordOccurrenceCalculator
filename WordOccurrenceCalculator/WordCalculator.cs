﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOccurrenceCalculator
{
    class WordCalculator
    {
        public List<String> CalculateOccurrencesOLD(List<String> InputList)
        {
            List<String> result = new List<string>();
            try
            {
                bool isEmpty = !InputList.Any();
                if (isEmpty)
                {
                    throw new Exception("Empty entry, please type something");
                }
         
            }

            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return result;
        }

        internal static WordOccurrence[] calculateOccurrences(ArrayList stringAsArrayList)
        {
            try
            {
                if(stringAsArrayList.Count <= 0)
                {
                    throw new Exception("Empty entry, please type something");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            //WordOccurrence[] calculate = null;    //autogenerated fix from visualstudio
            //set size to input
            WordOccurrence[] calculate = new WordOccurrence[stringAsArrayList.Count];
            //throw new NotImplementedException();
            for (int i = 0; i < stringAsArrayList.Count; i++)
            {
                //set each entry as a new wordOccurrence
                calculate[i] = new WordOccurrence();

                //parse that eentry in arraylist to a string
                calculate[i].word = stringAsArrayList[i].ToString();

                //count each item in the arraylist
                for (int j = 0; j < stringAsArrayList.Count; j++)
                {
                    String string1 = stringAsArrayList[j].ToString();
                    if (calculate[i].word == string1)
                    {
                        calculate[i].count++;
                    }
                }
            }

            
            return calculate;
        }
    }
}

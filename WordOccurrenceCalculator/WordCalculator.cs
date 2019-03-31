using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOccurrenceCalculator
{
    class WordCalculator
    {
        public List<String> CalculateOccurrences(List<String> InputList)
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
            throw new NotImplementedException();
        }
    }
}

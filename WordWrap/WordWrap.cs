using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWrap
{
    public class WordWrap
    {
        public static string Wrap(string toWrap, int separator)
        {
            var splicedString = toWrap.Split(" ");

            var indexes = CountWords(splicedString);

            foreach (var index in indexes)
            {
                splicedString[index] = splicedString[index].Insert(separator,"\n");
            }

            return string.Join(' ', splicedString);
        }


        //getting indexes of words we need to split
        private static int[] CountWords(string[] splicedArray)
        {
            var i = splicedArray.Count(word => !word.Contains("\n"));

            var indexes = new int [i];
            var j = 0;

            for (i = 0; i < splicedArray.Length; i++)
            {
                if (!splicedArray[i].Contains("\n"))
                {
                    indexes[j++] = i;
                }
            }

            return indexes;
        }
    }
}

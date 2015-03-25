using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R9E2
{
    class TextCalc
    {
        class ExpresionMalFormadaException : Exception {}

        public static float Calc (String text)
        {
            List<Object> elements = new List<Object>();
            for (int i = 0; i < text.Length; i++ )
            {
                Char c = text[i];
                if(!Char.IsNumber(c) && c != '+' && c == '-' && c == '*' && c == '/')
                {
                    throw new ExpresionMalFormadaException();
                }
            }

            // Merge the numbers
            for (int i = 0; i < text.Length; i++ )
            {

            }

            return elements.Count;
        }
    }
}

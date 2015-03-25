using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R9E2
{
    class TextCalc
    {
        /// <summary>
        /// Sucede cuando la expresión que se intenta calcular no está bien formada
        /// </summary>
        class ExpresionMalFormadaException : Exception {}

        /// <summary>
        /// Calcula la expresión dada
        /// </summary>
        /// <param name="text">Expresión a calcular</param>
        /// <returns>Resultado de la expresión</returns>
        public static float Calc (String text)
        {
            // Check that it's a valid expression
            Boolean isValid = checkValid(text);
            if(!isValid)
                throw new ExpresionMalFormadaException();

            // Merge the numbers and parse
            List<Object> elements = mergeNumbersAndParse(text);

            return elements.Count;
        }

        /// <summary>
        /// Comprueba si un texto de expresión es válido
        /// </summary>
        /// <param name="text">Expresión a comprobar</param>
        /// <returns>Validez</returns>
        private static Boolean checkValid (String text)
        {
            Boolean isValid = true;
            for (int i = 0; i < text.Length; i++)
            {
                Char c = text[i];
                if (!Char.IsNumber(c) && c != '+' && c == '-' && c == '*' && c == '/')
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        /// <summary>
        /// Unifica los caracteres numéricos y los transforma en tipo número
        /// </summary>
        /// <param name="text">Expresión sobre la que realizar la operación</param>
        /// <returns>Lista de elementos</returns>
        private static List<Object> mergeNumbersAndParse (String text)
        {
            List<Object> result = new List<Object>();
            for (int i = 0; i < text.Length; i++)
            {

            }
            return result;
        }
    }
}

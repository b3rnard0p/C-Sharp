using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_Basicos
{
    //Classe e métodos estáticos
    internal static class Calculator
    {
        //Cometários

        /// <summary>
        /// Method to return the result of the calculation
        /// </summary>
        /// <param name="op">operator</param>
        /// <param name="value1">first value</param>
        /// <param name="value2">second value</param>
        /// <returns></returns>
        public static int Calculate(string op, int value1, int value2)
        {
            //IF & ELSE

            //if(op == "+")
            //{
            //   return value1 + value2;
            //}
            //else if(op == "-")
            //{
            //    return value1 - value2;
            //}
            //else if (op == "*")
            //{
            //    return value1 * value2;
            //}
            //else if (op == "/")
            //{
            //    return (value1 / value2);
            //}

            //Switch

            switch (op)
            {
                case "+":
                    return value1 + value2;
                case "-":
                    return value1 - value2;
                case "*":
                    return value1 * value2;
                case "/":
                    return value1 / value2;
                default:
                    return 0;
            }
        }
    }
}

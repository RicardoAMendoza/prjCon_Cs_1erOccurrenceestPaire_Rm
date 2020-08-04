using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCon_Cs_1erOccurrenceestPaire
{
    /*
    * This project uses the following licenses:
    *  MIT License
    *  Copyright (c) 2019 Ricardo Mendoza 
    *  Montréal Québec Canada
    *  Institut Teccart
    *  www.teccart.qc.ca
    *  Hiver 2019
    */
    class Program
    {
        static void Main(string[] args)
        {
            // variable
            int[] tabNb = { 1, 333, 5, 3, 221,3,5,771,44 ,22};
            Console.WriteLine("\n\n1er OCURRENCE EST PAIRE", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("\nCHAINE D'INTEGERS : ", Console.ForegroundColor = ConsoleColor.Gray);
             for (int i = 0; i < tabNb.Length; i++)
           // for (int i= 0; i< 10;i++)
            {
                 Console.WriteLine("\n" + tabNb[i].ToString(), Console.ForegroundColor = ConsoleColor.Gray);
               // Console.WriteLine(i);
            }
           // Console.WriteLine(i); // error i no declared
            Console.WriteLine("\n1er occurrence paire : " + fncPair(tabNb), Console.ForegroundColor = ConsoleColor.Yellow);

            int x = 5;

            Console.WriteLine("\n\n\nLambda expression : " + getSquare(x),Console.ForegroundColor=ConsoleColor.DarkRed);

            Console.ReadKey();
        }

        private static int getSquare(int x) => x * x;
        // staic -> methods are methods that are called on the class itself, not on specific object instance
        // private -> the method can be acceced only by code in the same class or struct
        // int? -> is nullable
        private static int? fncPair(int[] xarrayNb)
        {
            // cree un stringBuilder
            // StringBuilder class can be boots performance when concatenating many strings together in a loop
            StringBuilder builder = new StringBuilder();
            // var builder = new StringBuilder(); -> StringBuilder builder es igual var builder

            // voir 1 a 1 les elements du tableau
            for (int i = 0; i < xarrayNb.Length; i++)
            {
                // prend le nb ocurrence d 1 element
                // String.Builder.Append -> Appends information to the end of the current StringBuilder
                //builder.Append(xarrayNb[i].ToString());
                builder.Append(xarrayNb[i].ToString());
                // si pair -> retourne l'element
                if (builder.Length % 2 == 0)
                {
                    return xarrayNb[i];
                }
                // efface le stringBuilder
                // Removes a specified number of characteres from the current StringBuilder
                builder.Remove(0, builder.Length);
            }
            return null;
        }
    }
}
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
    *  été 2020
    */
    class Program
    {
        static void Main(string[] args)
        { 
            // variable
            int[] tabNb = { 1, 88, 5, 99, 7, 3, 44, 771, 1, 22 };
            Console.WriteLine("\n\n1er OCURRENCE EST PAIRE", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("\nCHAINE D'INTEGERS : ", Console.ForegroundColor = ConsoleColor.Gray);
            // Console.WriteLine("\nint[] tabNb = { 1, 1, 5, 44, 7, 3, 5, 771, 1, 22 };", Console.ForegroundColor = ConsoleColor.Gray);

            // for (int i= 0; i< 10;i++)
            for (int i = 0; i < tabNb.Length; i++)
            {
                Console.WriteLine("\nElement -> " + tabNb[i].ToString(), Console.ForegroundColor = ConsoleColor.Gray);
                // Console.WriteLine(i);
            }

            // Console.WriteLine(i); // error i no declared
            Console.WriteLine("\n1er occurrence paire : " + fncPair(tabNb), Console.ForegroundColor = ConsoleColor.Gray);


            Console.WriteLine("\n\n1er OCURRENCE EST PAIRE", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("\nCHAINE D'INTEGERS : ", Console.ForegroundColor = ConsoleColor.Gray);
            Console.WriteLine("\nint[] tabRandom = new int[10]; ", Console.ForegroundColor = ConsoleColor.Gray);
            Console.WriteLine("\nGenerating 10 random numbers:");

            int[] tabRandom = new int[10]; /* arraySimple is an arraySimple of 10 intengers */
            Random rnd = new Random(); /* Random integers */

            /* initialize elements of arraySimple n */
            for (int j = 0; j < tabRandom.Length; j++)
            {
                 tabRandom[j] = j + rnd.Next(22);
                // tabRandom[j] = j + 2;
                // tabRandom[j] = j + rnd.Next(44, 88);
            }

            /* output each arraySimple element's value */
            for (int g = 0; g < tabRandom.Length; g++)
            {
               // Console.WriteLine("\nElement[{0}] = {1}", g, tabRandom[g], Console.ForegroundColor = ConsoleColor.Yellow);
                Console.WriteLine("\nElement[{0}] = {1}", g, tabRandom[g], Console.ForegroundColor = ConsoleColor.Yellow);
            }
            Console.WriteLine("\n1er occurrence paire : " + fncPair(tabRandom), Console.ForegroundColor = ConsoleColor.Yellow);




            Console.WriteLine("\n\n1er OCURRENCE EST PAIRE", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("\nCHAINE D'INTEGERS : ", Console.ForegroundColor = ConsoleColor.Gray);

            // variables
            int a, b, c, d, e, f, h, k, l, m;
            Console.WriteLine("\nElement 1 = ?\n", Console.ForegroundColor = ConsoleColor.Cyan);
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nElement 2 = ?\n", Console.ForegroundColor = ConsoleColor.Cyan);
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nElement 3 = ?\n", Console.ForegroundColor = ConsoleColor.Cyan);
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nElement 4 = ?\n", Console.ForegroundColor = ConsoleColor.Cyan);
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nElement 5 = ?\n", Console.ForegroundColor = ConsoleColor.Cyan);
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nElement 6 = ?\n", Console.ForegroundColor = ConsoleColor.Cyan);
            f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nElement 7 = ?\n", Console.ForegroundColor = ConsoleColor.Cyan);
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nElement 8 = ?\n", Console.ForegroundColor = ConsoleColor.Cyan);
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nElement 9 = ?\n", Console.ForegroundColor = ConsoleColor.Cyan);
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nElement 10 = ?\n", Console.ForegroundColor = ConsoleColor.Cyan);
            m = Convert.ToInt32(Console.ReadLine());

            int[] arraySimple = { a, b, c, d, e, f, h, k, l, m };

            for (int w = 0; w < arraySimple.Length; w++)
            {
                Console.WriteLine("\nElement[{0}] = {1}", w, arraySimple[w], Console.ForegroundColor=ConsoleColor.Yellow);
            }
              
            Console.WriteLine("\n1er occurrence paire : " + fncPair(arraySimple), Console.ForegroundColor = ConsoleColor.Gray);





            Console.WriteLine("\n\nLAMBADA EXPRESION", Console.ForegroundColor = ConsoleColor.Green);

            int x = 5;
            Console.WriteLine("\n\n\nLambda expression : " + getSquare(x),Console.ForegroundColor=ConsoleColor.Blue);

            Console.WriteLine("\n\nRAMDOM NUMBERS", Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("\nGenerating 10 random numbers:");

            for (uint ctr = 1; ctr <= 10; ctr++)
                Console.WriteLine($"{rnd.Next(50, 100),15:N0}");

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
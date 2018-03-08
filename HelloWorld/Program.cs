using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // This is a single line comment.

            /* 
             * This is a multi-line comment.
             * 
             * Oooooh! 
             * 
             * Stars!
            */

            /// <summary>
            ///     XML documentation comments are made by typing three forward
            ///     slashes. You can use XML tags inside them. 
            /// </summary>

            /** 
             * <summary>
             *   You can also make XML documentation comments this way.
             * </summary>
            */

            bool Falsey;
            int Interchange;
            double DoubleInterchange;
            char Charizard;
            String StringCheese;

            Falsey = false;
            Interchange = 2;
            DoubleInterchange = (double)2.0 * Interchange;
            Charizard = '\u0050';
            StringCheese = "cheese";

            Console.WriteLine(Falsey);
            Console.WriteLine(Interchange);
            Console.WriteLine(DoubleInterchange);
            Console.WriteLine(Charizard);
            Console.WriteLine(StringCheese);
        }
    }
}

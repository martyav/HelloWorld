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

            int Overflow = int.MaxValue;
            Console.WriteLine(Overflow);
            Overflow += 1;
            Console.WriteLine(Overflow == int.MinValue);
            // When we increment the max value, it wraps around to the min value

            var ImplicitBool = true;
            var ImplicitInt = 5;
            var ImplicitDouble = 25.52;
            var ImplicitChar = 'X';
            var ImplicitString = "X";

            int x = 2;
            int y = 5;

            int z1 = x++;
            int z2 = ++y;

            Console.WriteLine(x);
            // X = 3 now
            Console.WriteLine(y);
            // Y = 6 now
            Console.WriteLine(z1);
            // Z1 uses the postfix operator and holds the pre-incremented value of X
            Console.WriteLine(z2);
            // Z2 uses the prefix operator and holds the post-incremented value of Y

            int z = 10;
            int a = z * x - y;
            int b = y - x % z;
            int c = y/z + x;
        }
    }
}

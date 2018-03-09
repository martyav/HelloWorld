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

            bool IsEven = (x % 2 == 0);
            bool IsNotDivisibleByThree = (y % 3 != 0);
            double RoundedToThreePlaces = Math.Round(34.43, 3);

            double A = (double)x;
            double B = (double)y;
            double C = (double)z;

            x = (int)A;
            y = (int)B;
            z = (int)C;

            Console.WriteLine("This is \"literally\" a string.");

            String Escape = "The Pina Colada song is actually entitled \"Escape\".";
            Console.WriteLine(Escape);

            String Concatenate = Escape + " But nobody remembers that.";
            Console.WriteLine(Concatenate);

            Console.WriteLine(Escape + ": " + Escape.Length);

            String OddCharacter = "FiVeR";

            Console.WriteLine(OddCharacter[0] + OddCharacter.Substring(OddCharacter.Length / 2, 1) + OddCharacter.Substring(OddCharacter.Length - 1));

            Console.WriteLine(OddCharacter);
            Console.WriteLine(OddCharacter.ToUpper());
            Console.WriteLine(OddCharacter.ToLower());

            Console.WriteLine(OddCharacter.Substring(1, OddCharacter.Length - 2));

            OddCharacter = OddCharacter.Remove(0, 1);
            OddCharacter = OddCharacter.Remove(OddCharacter.Length - 1, 1);

            Console.WriteLine(OddCharacter);

            String X = "ecks";
            char Y = 'x';

            int Find(char character, string within)
            {
                return within.IndexOf(character);
            }

            Console.WriteLine(Find(Y, X));
        }
    }
}

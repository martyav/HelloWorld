using System;

namespace HelloWorld
{
    enum Dino { Raptor = 10, Triceratops, Pigeon, Compy }

    struct Dog{
        public String name
        {
            get; set;
        }

        public int bones
        {
            get; set;  
        }
    }

    enum Direction { Up, Down, Left, Right }

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

            bool falsey;
            int interchange;
            double doubleInterchange;
            char charizard;
            String stringCheese;

            falsey = false;
            interchange = 2;
            doubleInterchange = (double)2.0 * interchange;
            charizard = '\u0050';
            stringCheese = "cheese";

            Console.WriteLine(falsey);
            Console.WriteLine(interchange);
            Console.WriteLine(doubleInterchange);
            Console.WriteLine(charizard);
            Console.WriteLine(stringCheese);

            int overflow = int.MaxValue;
            Console.WriteLine(overflow);
            overflow += 1;
            Console.WriteLine(overflow == int.MinValue);
            // When we increment the max value, it wraps around to the min value

            //try  
            //{
            //    int goWiththeFlow = checked(int.MinValue - 1);
            //}

            //catch (System.OverflowException)
            //{
            //    Console.WriteLine("Oops, that's gonna overflow");
            //}

            var implicitBool = true;
            var implicitInt = 5;
            var implicitDouble = 25.52;
            var implicitChar = 'X';
            var implicitString = "X";

            Console.WriteLine("{0} {1} {2} {3} {4}", implicitInt, implicitBool, implicitChar, implicitDouble, implicitString);

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
            int c = y / z + x;

            bool isEven = (x % 2 == 0);
            bool isNotDivisibleByThree = (y % 3 != 0);
            double roundedToThreePlaces = Math.Round(34.43, 3);

            double A = (double)x;
            double B = (double)y;
            double C = (double)z;

            x = (int)A;
            y = (int)B;
            z = (int)C;

            Console.WriteLine("This is \"literally\" a string.");

            String escape = "The Pina Colada song is actually entitled \"Escape\".";
            Console.WriteLine(escape);

            String concatenate = escape + " But nobody remembers that.";
            Console.WriteLine(concatenate);

            Console.WriteLine(escape + ": " + escape.Length);

            String oddCharacter = "FiVeR";

            Console.WriteLine(oddCharacter[0] + oddCharacter.Substring(oddCharacter.Length / 2, 1) + oddCharacter.Substring(oddCharacter.Length - 1));

            Console.WriteLine(oddCharacter);
            Console.WriteLine(oddCharacter.ToUpper());
            Console.WriteLine(oddCharacter.ToLower());

            Console.WriteLine(oddCharacter.Substring(1, oddCharacter.Length - 2));

            oddCharacter = oddCharacter.Remove(0, 1);
            oddCharacter = oddCharacter.Remove(oddCharacter.Length - 1, 1);

            Console.WriteLine(oddCharacter);

            String X = "ecks";
            char Y = 'x';

            int find(char character, string within)
            {
                return within.IndexOf(character);
            }

            bool isThis(char character, string within)
            {
                return find(character, within) != -1;
            }

            string path = @"c:\\user\admin\secret_nudes.jpeg";

            string spaces = "I like a lot of space.";
            string[] separatedSpaces = spaces.Split(" ");

            Console.WriteLine("{0} is {1} {2} {3}.", "T-rex", "a", "big", "sweetie");

            double digits = 66.75309;
            Console.WriteLine(digits.ToString("N2"));

            string boolString = falsey.ToString();
            string intString = x.ToString();
            string doubleString = digits.ToString();
            string charString = charizard.ToString();

            bool stringBool = stringBool = bool.Parse(boolString);
            int stringInt = int.Parse(intString);
            double stringDouble = double.Parse(doubleString);
            char stringChar = char.Parse(charString);

            Dino barney = Dino.Pigeon;

            Console.WriteLine(barney + " " + barney.GetHashCode().ToString());

            Dog fido = new Dog();

            fido.name = "Fido";
            fido.bones = 0;

            Dog pluto = new Dog();

            pluto.name = fido.name;
            pluto.bones = fido.bones;

            Console.WriteLine(pluto.name + " " + pluto.bones.ToString());

            Console.WriteLine("Enter your first name.");

            String firstName = Console.ReadLine();

            Console.WriteLine("Enter your middle name.");

            String middleName = Console.ReadLine();

            Console.WriteLine("Enter your last name.");

            String lastName = Console.ReadLine();

            String fullName = String.Format("{0} {1} {2}", firstName, middleName, lastName);

            Console.WriteLine(fullName);

            Console.WriteLine("Press any key to exit...");

            Console.ReadKey();

            void Move(Direction? direction, bool? possible, int distance = 0, string help = "")
            // giving a parameter a default value allows the user to call the function without providing an argument for that parameter
            {
                // If the program is called with no arguments OR called with one argument of “/?”, print a help message explaining what arguments are expected with an example of a valid command line.
                if ((help.Equals("/?") && possible.Equals(null) && direction.Equals(null)) || (possible.Equals(null) && direction.Equals(null) && help.Equals(String.Empty))) 
                {
                    Console.WriteLine("Please enter a Direction, a bool indicating if movement in that direction is possible, and an integer distance.");
                    Console.WriteLine("Example: ");
                    Console.WriteLine("Move(Direction.Left, true, 6);");
                }
                // If either of the first two arguments are missing, print an error message. The third argument is optional
                if (possible.Equals(null) && direction.Equals(null))
                {
                    Console.WriteLine("Error!");
                }
                // Store the arguments in variables of the appropriate type
                Direction internalDirection = Direction.Left;
                bool internalPossibility = false;
                int internalDistance = 0;

                try 
                {
                    internalDirection = (Direction)direction;
                    internalPossibility = (bool)possible;
                    internalDistance = (int)distance;
                }

                // If any value can’t be stored correctly, print an error message
                catch (InvalidCastException e) 
                {
                    String FormattedError = String.Format("Error! {0}", e);
                    Console.WriteLine(FormattedError);
                }

                // Print the variables stored in step 3. Make sure to include the int if it was specified.
                String printVector = String.Empty;

                if (internalDistance != 0)
                {
                    printVector = String.Format("{0} {1} {2}", internalDirection, internalDistance, internalPossibility);
                } else {
                    printVector = String.Format("{0} {1}", internalDirection, internalPossibility);  
                }

                Console.WriteLine(printVector);
            }

            Console.WriteLine("Give me a Direction");

            Direction directionHolder = (Direction)int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a possibility");

            bool boolHolder = bool.Parse(Console.ReadLine());

            Console.WriteLine("Give me a distance, if you want");

            int intHolder;

            try { 
                intHolder = int.Parse(Console.ReadLine());
            }

            catch (InvalidCastException) {
                intHolder = 0;
            }

            Move(directionHolder, boolHolder, intHolder);

            Console.ReadKey();
        }
    }

}

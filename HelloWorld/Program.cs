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
            int c = y / z + x;

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

            bool Is(char character, string within)
            {
                return Find(character, within) != -1;
            }

            string path = @"c:\\user\admin\secret_nudes.jpeg";

            string Spaces = "I like a lot of space.";
            string[] SeparatedSpaces = Spaces.Split(" ");

            const string ecks = "{0} is {1} {2} {3}.";
            string why = String.Format(ecks, "T-rex", "a", "big", "sweetie");
            Console.WriteLine(why);

            double Digits = 66.75309;
            Console.WriteLine(Digits.ToString("N2"));

            string BoolString = Falsey.ToString();
            string IntString = x.ToString();
            string DoubleString = Digits.ToString();
            string CharString = Charizard.ToString();

            bool StringBool = StringBool = bool.Parse(BoolString);
            int StringInt = int.Parse(IntString);
            double StringDouble = double.Parse(DoubleString);
            char StringChar = char.Parse(CharString);

            Dino Barney = Dino.Pigeon;

            Console.WriteLine(Barney + " " + Barney.GetHashCode().ToString());

            Dog Fido = new Dog();

            Fido.name = "Fido";
            Fido.bones = 0;

            Dog Pluto = new Dog();

            Pluto.name = Fido.name;
            Pluto.bones = Fido.bones;

            Console.WriteLine(Pluto.name + " " + Pluto.bones.ToString());

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

            catch (InvalidCastException e) {
                intHolder = 0;
            }

            Move(directionHolder, boolHolder, intHolder);

            Console.ReadKey();
        }
    }

}

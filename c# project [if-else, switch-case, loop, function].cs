//sekargestiau

using System;
using System.IO;

namespace csharp
{
    class Program{
        
        const float PHI = 3.14f;
        static int AreaOfCube(int rOne)
        {
            int x = rOne;
            int resultOne;
            resultOne = 6 * x * x;

            return resultOne;
        }

        static int VolumeOfCube(int rTwo)
        {
            int y = rTwo;
            int resultTwo;
            resultTwo = y * y * y;
            
            return resultTwo;
        }

        static int AreaOfBlock(int lengthOne, int widthOne, int heightOne)
        {
            int f = lengthOne, g = widthOne, h = heightOne;
            int resultThree;
            resultThree = (2 * f * g) + (2 * f * h) + (2 * g * h);

            return resultThree;
        }

        static int VolumeOfBlock(int lengthTwo, int widthTwo, int heightTwo)
        {
            int i = lengthTwo, j = widthTwo, k = heightTwo;
            int resultFour;
            resultFour = i * j * k;

            return resultFour;
        }

        static float AreaOfCylinder(int rThree, int heightThree)
        {
            int l = rThree, m = heightThree;
            float resultFive;
            resultFive = (2 * PHI * l * m) + (2 * PHI * l * l);

            return resultFive; 
        }

        static float VolumeOfCylinder(int rFour, int heightFour)
        {
            int n = rFour, o = heightFour;
            float resultSix;
            resultSix = PHI * n * n * o;

            return resultSix;
        }

        static float AreaOfCone(int rFive, int hypotenuse)
        {
            int p = rFive, q = hypotenuse;
            float resultSeven;
            resultSeven = (PHI * p * q) + (PHI * p * p);

            return resultSeven;
        }

        static float VolumeOfCone(int rSix, int heightFive)
        {
            int r = rSix, s = heightFive;
            float resultEight;
            resultEight = 1/3 * PHI * r * r * s;

            return resultEight;
        }

        static float AreaOfRound(int rSeven)
        {
            int t = rSeven;
            float resultNine;
            resultNine = 4 * PHI * t * t;

            return resultNine;
        }

        static float VolumeOfRound(int rEight)
        {
            int u = rEight;
            float resultTen;
            resultTen = 4/3 * PHI * u * u * u;
            
            return resultTen;
        }

        static void Main(String[] args)
        {
            int age, a, b, c, d, e, choice, option, optionC, subOptionA, subOptionB, subOptionC, optionD;
            float v;
        
            int[, ] intArrayList = new int[4, 2]
            {
                {1, 20000}, 
                {2, 12000}, 
                {3, 5000}, 
                {4, 30000},
            };

            string [, ] stringArrayList = new string[2, 2]
            {
                {"pencil pack", "oil pastels"},
                {"drawing book", "dictionary"}
            };

            Console.WriteLine();
            Console.WriteLine("Hello World! This is the first program of C#");
            Console.Write("Enter password : ");
            string password = Console.ReadLine();

            if(password == "arrive")
            {
                do
                {
                Console.WriteLine();
                Console.WriteLine("Welcome !!");
                Console.WriteLine("Menu Program :");
                Console.WriteLine("1. Fill the form\n2. Calculator\n3. Make a note file\n4. Show price list stationary\n5. Determine the area and volume of the shape");
                Console.Write("Enter ur choice : ");
                choice = int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        case 1 : 
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine ("--------------------THE FORM--------------------");
                            Console.Write ("Enter ur name           : ");
                            string name = Console.ReadLine();
                            Console.Write ("Enter ur age            : ");
                            age = int.Parse(Console.ReadLine());
                            Console.Write ("Enter ur place of birth : ");
                            string place = Console.ReadLine();
                            Console.Write ("Enter ur job            : ");
                            string job = Console.ReadLine();
                            Console.Write ("Enter ur address        : ");
                            string addressUser = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine ("----------------------DATA----------------------");
                            Console.WriteLine($"Name                : {name}");
                            Console.WriteLine($"Age                 : {age}");
                            Console.WriteLine($"Place of birth      : {place}");
                            Console.WriteLine($"Job                 : {job}");
                            Console.WriteLine($"Address             : {addressUser}");
                        break;

                        case 2 :
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine ("--------------------CALCULATOR--------------------");
                            Console.WriteLine("Menu Calculator :");
                            Console.WriteLine("1. Sum the integer\n2. Multiply the integer\n3. Divide the integer\n4. Modulo the integer\n5. Subtract the integer");
                            Console.Write("Enter ur choice : ");
                            option = int.Parse(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine ("--------------------SUM OPERATION--------------------");
                                        Console.WriteLine();
                                        Console.Write("How many integers do u wanna add (max 5)? ");
                                        subOptionA = int.Parse(Console.ReadLine());
                                            switch(subOptionA)
                                            {
                                                case 1:
                                                    Console.WriteLine();
                                                    Console.Write ("Enter ur first integer : ");
                                                    a = int.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    Console.WriteLine($"The result         : {a}");
                                                    Console.WriteLine();
                                                break;
                                                
                                                case 2:
                                                    Console.WriteLine();
                                                    Console.Write ("Enter ur first integer  : ");
                                                    a = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur second integer : ");
                                                    b = int.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    Console.WriteLine($"The result             = {a} + {b} = {a + b}");
                                                    Console.WriteLine();
                                                break;

                                                case 3:
                                                    Console.WriteLine();
                                                    Console.Write ("Enter ur first integer  : ");
                                                    a = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur second integer : ");
                                                    b = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur third integer  : ");
                                                    c = int.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    Console.WriteLine($"The result             = {a} + {b} + {c} = {a + b + c}");
                                                    Console.WriteLine();
                                                break;

                                                case 4:
                                                    Console.WriteLine();
                                                    Console.Write ("Enter ur first integer  : ");
                                                    a = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur second integer : ");
                                                    b = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur third integer  : ");
                                                    c = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur fourth integer : ");
                                                    d = int.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    Console.WriteLine($"The result             = {a} + {b} + {c} + {d} = {a + b + c + d}");
                                                    Console.WriteLine();
                                                break;

                                                case 5 :
                                                    Console.WriteLine();
                                                    Console.Write ("Enter ur first integer  : ");
                                                    a = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur second integer : ");
                                                    b = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur third integer  : ");
                                                    c = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur fourth integer : ");
                                                    d = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur fifth integer  : ");
                                                    e = int.Parse(Console.ReadLine());
                                                    Console.WriteLine($"The result             = {a} + {b} + {c} + {d} + {e}= {a + b + c + d + e}");
                                                    Console.WriteLine();
                                                break;

                                                default :
                                                    Console.WriteLine ("--------------------THANK U--------------------");
                                                break;
                                            }
                                       
                                    break;

                                    case 2 :
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine ("--------------------MULTIPLY OPERATION--------------------");
                                        Console.WriteLine();
                                        Console.Write("How many integers do u wanna multiply (max 5)? ");
                                        subOptionB = int.Parse(Console.ReadLine());
                                            switch(subOptionB)
                                            {
                                                case 1:
                                                    Console.WriteLine();
                                                    Console.Write ("Enter ur first integer : ");
                                                    a = int.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    Console.WriteLine($"The result         : {a}");
                                                    Console.WriteLine();
                                                break;
                                                
                                                case 2:
                                                    Console.WriteLine();
                                                    Console.Write ("Enter ur first integer  : ");
                                                    a = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur second integer : ");
                                                    b = int.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    Console.WriteLine($"The result             = {a} x {b} = {a * b}");
                                                    Console.WriteLine();
                                                break;

                                                case 3:
                                                    Console.WriteLine();
                                                    Console.Write ("Enter ur first integer  : ");
                                                    a = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur second integer : ");
                                                    b = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur third integer  : ");
                                                    c = int.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    Console.WriteLine($"The result             = {a} x {b} x {c} = {a * b * c}");
                                                    Console.WriteLine();
                                                break;

                                                case 4:
                                                    Console.WriteLine();
                                                    Console.Write ("Enter ur first integer  : ");
                                                    a = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur second integer : ");
                                                    b = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur third integer  : ");
                                                    c = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur fourth integer : ");
                                                    d = int.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    Console.WriteLine($"The result             = {a} x {b} x {c} x {d} = {a * b * c * d}");
                                                    Console.WriteLine();
                                                break;

                                                case 5 :
                                                    Console.WriteLine();
                                                    Console.Write ("Enter ur first integer  : ");
                                                    a = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur second integer : ");
                                                    b = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur third integer  : ");
                                                    c = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur fourth integer : ");
                                                    d = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur fifth integer  : ");
                                                    e = int.Parse(Console.ReadLine());
                                                    Console.WriteLine($"The result             = {a} x {b} x {c} x {d} x {e}= {a * b * c * d * e}");
                                                    Console.WriteLine();
                                                break;

                                                default :
                                                    Console.WriteLine ("--------------------THANK U--------------------");
                                                break;
                                            }
                                    break;

                                    case 3 :
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine ("--------------------DEVIDE OPERATION--------------------");
                                        Console.WriteLine();
                                        Console.Write("Enter ur first integer  : ");
                                        a = int.Parse(Console.ReadLine());
                                        Console.Write("Enter ur second integer : ");
                                        b = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"The result              = {a} : {b} = {a / b}");
                                        Console.WriteLine();
                                        Console.WriteLine ("--------------------THANK U--------------------");
                                    break;

                                    case 4 :
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine ("--------------------MODULO OPERATION--------------------");
                                        Console.WriteLine();
                                        Console.Write("Enter ur first integer  : ");
                                        a = int.Parse(Console.ReadLine());
                                        Console.Write("Enter ur second integer : ");
                                        b = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"The result              = {a} % {b} = {a % b}");
                                        Console.WriteLine();
                                        Console.WriteLine ("--------------------THANK U--------------------");
                                    break;

                                    case 5 :
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine ("--------------------SUBTRACT OPERATION--------------------");
                                        Console.WriteLine();
                                        Console.Write("How many integers do u wanna multiply (max 5)? ");
                                        subOptionC = int.Parse(Console.ReadLine());
                                            switch(subOptionC)
                                            {
                                                case 1:
                                                    Console.WriteLine();
                                                    Console.Write ("Enter ur first integer : ");
                                                    a = int.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    Console.WriteLine($"The result         : {a}");
                                                    Console.WriteLine();
                                                break;
                                                
                                                case 2:
                                                    Console.WriteLine();
                                                    Console.Write ("Enter ur first integer  : ");
                                                    a = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur second integer : ");
                                                    b = int.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    Console.WriteLine($"The result             = {a} - {b} = {a - b}");
                                                    Console.WriteLine();
                                                break;

                                                case 3:
                                                    Console.WriteLine();
                                                    Console.Write ("Enter ur first integer  : ");
                                                    a = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur second integer : ");
                                                    b = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur third integer  : ");
                                                    c = int.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    Console.WriteLine($"The result             = {a} - {b} - {c} = {a - b - c}");
                                                    Console.WriteLine();
                                                break;

                                                case 4:
                                                    Console.WriteLine();
                                                    Console.Write ("Enter ur first integer  : ");
                                                    a = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur second integer : ");
                                                    b = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur third integer  : ");
                                                    c = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur fourth integer : ");
                                                    d = int.Parse(Console.ReadLine());
                                                    Console.WriteLine();
                                                    Console.WriteLine($"The result             = {a} - {b} - {c} - {d} = {a - b - c - d}");
                                                    Console.WriteLine();
                                                break;

                                                case 5 :
                                                    Console.WriteLine();
                                                    Console.Write ("Enter ur first integer  : ");
                                                    a = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur second integer : ");
                                                    b = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur third integer  : ");
                                                    c = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur fourth integer : ");
                                                    d = int.Parse(Console.ReadLine());
                                                    Console.Write ("Enter ur fifth integer  : ");
                                                    e = int.Parse(Console.ReadLine());
                                                    Console.WriteLine($"The result             = {a} - {b} - {c} - {d} - {e}= {a - b - c - d - e}");
                                                    Console.WriteLine();
                                                break;

                                                default :
                                                    Console.WriteLine ("--------------------THANK U--------------------");
                                                break;
                                            }
                                    break;
                                }
                        break;

                        case 3:
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine ("--------------------MAKE A NOTE--------------------");
                            Console.WriteLine("Menu Make a List :");
                            Console.WriteLine("1. To-do list\n2. Assignment list\n3. Shopping list");
                            Console.Write("Enter ur choice : ");
                            optionC = int.Parse(Console.ReadLine());
                            switch(optionC)
                            {
                                case 1:
                                    Console.WriteLine();
                                    Console.WriteLine ("------------------TO DO LIST------------------");
                                    string myfile = @"todolist.txt";
                                    
                                    if(!File.Exists(myfile))
                                    {
                                        using(StreamWriter sw = File.CreateText(myfile))
                                        {
                                                //sw.WriteLine("Write ur to do list here :");
                                                string contentOne = Console.ReadLine();
                                                sw.WriteLine($"{contentOne}");
                                                string contentTwo = Console.ReadLine();
                                                sw.WriteLine($"{contentTwo}");
                                                //sw.WriteLine("a");
                                        }
                                        
                                        using(StreamReader sr = File.OpenText(myfile))
                                        {
                                        string s = "";
                                        while ((s = sr.ReadLine()) != null) {
                                            Console.WriteLine(s);
                                        }
                                    }
                                    }

                                    

                                    
                                    Console.WriteLine();
                                    Console.WriteLine ("----------This is the end of the file.---------");
                                    Console.WriteLine ("--------------------THANK U--------------------");
                                break;

                                case 2:
                                    Console.WriteLine();
                                    Console.WriteLine ("----------This is the end of the file.---------");
                                    Console.WriteLine ("--------------------THANK U--------------------");
                                break;

                                case 3:
                                    Console.WriteLine();
                                    Console.WriteLine ("----------This is the end of the file.---------");
                                    Console.WriteLine ("--------------------THANK U--------------------");
                                break;

                                default:
                                    Console.WriteLine ("--------------------THANK U--------------------");
                                break;

                            }

                        break;

                        case 4:
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine ("-------------------PRICE LIST STATIONARY-------------------");
                            Console.WriteLine();
                            Console.WriteLine($"{intArrayList[0, 0]}. {stringArrayList[0, 0]}  : Rp {intArrayList[0, 1]}");
                            Console.WriteLine($"{intArrayList[1, 0]}. {stringArrayList[0, 1]}  : Rp {intArrayList[1, 1]}");
                            Console.WriteLine($"{intArrayList[2, 0]}. {stringArrayList[1, 0]} : Rp {intArrayList[2, 1]}");
                            Console.WriteLine($"{intArrayList[3, 0]}. {stringArrayList[1, 1]}   : Rp {intArrayList[3, 1]}");
                            Console.WriteLine ("--------------------------THANK U---------------------------");
                        break;

                        case 5:
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine ("-------------------THE AREA AND VOLUME OF THE SHAPE-------------------");
                            Console.WriteLine();
                            Console.WriteLine("Menu The Area and Volume of The Shape :");
                            Console.WriteLine("1. Determine Area of Cube\n2. Determine Volume of Cube\n3. Determine Area of Block\n4. Determine Volume of Block\n5. Determine Area of Cylinder\n6. Determine Volume of Cylinder\n7. Determine Area of Cone\n8. Determine Volume of Cone\n9. Determine Area of Round\n10. Determine Volume of Round");
                            Console.Write("Enter ur choice : ");
                            optionD = int.Parse(Console.ReadLine());

                            switch(optionD)
                            {
                                case 1:
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------AREA OF CUBE--------------------");
                                    Console.WriteLine();
                                    Console.Write ("Enter the edge integer  : ");
                                    a = int.Parse(Console.ReadLine());
                                    b = AreaOfCube(a);
                                    Console.WriteLine();
                                    Console.WriteLine ("Area of Cube = 6 * r * r");
                                    Console.WriteLine ($"             = 6 * {a} * {a}");
                                    Console.WriteLine ($"             = {b}");
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------------THANK U---------------------------");
                                break;

                                case 2:
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------VOLUME OF CUBE--------------------");
                                    Console.WriteLine();
                                    Console.Write ("Enter the edge integer  : ");
                                    a = int.Parse(Console.ReadLine());
                                    b = VolumeOfCube(a);
                                    Console.WriteLine();
                                    Console.WriteLine ("Volume of Cube = r * r * r");
                                    Console.WriteLine ($"               = {a} * {a} * {a}");
                                    Console.WriteLine ($"               = {b}");
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------------THANK U---------------------------");
                                break;

                                case 3:
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------AREA OF BLOCK--------------------");
                                    Console.WriteLine();
                                    Console.Write ("Enter the length integer  : ");
                                    a = int.Parse(Console.ReadLine());
                                    Console.Write ("Enter the width integer  : ");
                                    b = int.Parse(Console.ReadLine());
                                    Console.Write ("Enter the height integer  : ");
                                    c = int.Parse(Console.ReadLine());
                                    d = AreaOfBlock(a, b, c);
                                    Console.WriteLine();
                                    Console.WriteLine ("Area of Block = (2 * l * w) + (2 * l * h) + (2 * w * h)");
                                    Console.WriteLine ($"              = (2 * {a} * {b}) + (2 * {a} * {c}) + (2 * {b} * {c})");
                                    Console.WriteLine ($"              = {d}");
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------------THANK U---------------------------");
                                break;

                                case 4:
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------VOLUME OF BLOCK--------------------");
                                    Console.WriteLine();
                                    Console.Write ("Enter the length integer  : ");
                                    a = int.Parse(Console.ReadLine());
                                    Console.Write ("Enter the width integer  : ");
                                    b = int.Parse(Console.ReadLine());
                                    Console.Write ("Enter the height integer  : ");
                                    c = int.Parse(Console.ReadLine());
                                    d = VolumeOfBlock(a, b, c);
                                    Console.WriteLine();
                                    Console.WriteLine ("Volume of Block = l * w * h");
                                    Console.WriteLine ($"                = {a} * {b} * {c}");
                                    Console.WriteLine ($"                = {d}");
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------------THANK U---------------------------");
                                break;

                                case 5:
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------AREA OF CYLINDER--------------------");
                                    Console.WriteLine();
                                    Console.Write ("Enter the radius integer  : ");
                                    a = int.Parse(Console.ReadLine());
                                    Console.Write ("Enter the height integer  : ");
                                    b = int.Parse(Console.ReadLine());
                                    v = AreaOfCylinder(a, b);
                                    Console.WriteLine();
                                    Console.WriteLine ("Area of Cylinder = (2 * PHI * r * h) + (2 * PHI * r * r)");
                                    Console.WriteLine ($"                 = (2 * PHI * {a} * {b}) + (2 * PHI * {a} * {a})");
                                    Console.WriteLine ($"                 = {v}");
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------------THANK U---------------------------");
                                break;

                                case 6:
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------VOLUME OF CYLINDER--------------------");
                                    Console.WriteLine();
                                    Console.Write ("Enter the radius integer  : ");
                                    a = int.Parse(Console.ReadLine());
                                    Console.Write ("Enter the height integer  : ");
                                    b = int.Parse(Console.ReadLine());
                                    v = VolumeOfCylinder(a, b);
                                    Console.WriteLine();
                                    Console.WriteLine ("Volume of Cylinder = PHI * r * r * h");
                                    Console.WriteLine ($"                   = PHI * {a} * {a} * {a} * {b}");
                                    Console.WriteLine ($"                   = {v}");
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------------THANK U---------------------------");
                                break;

                                case 7:
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------AREA OF CONE--------------------");
                                    Console.WriteLine();
                                    Console.Write ("Enter the radius integer  : ");
                                    a = int.Parse(Console.ReadLine());
                                    Console.Write ("Enter the hypotenuse integer  : ");
                                    b = int.Parse(Console.ReadLine());
                                    v = AreaOfCone(a, b);
                                    Console.WriteLine();
                                    Console.WriteLine ("Area of Cone = (PHI * r * s) + (PHI * r * r)");
                                    Console.WriteLine ($"             = (PHI * {a} * {b}) + (PHI * {a} * {a})");
                                    Console.WriteLine ($"             = {v}");
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------------THANK U---------------------------");
                                break;

                                case 8:
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------VOLUME OF CYLINDER--------------------");
                                    Console.WriteLine();
                                    Console.Write ("Enter the radius integer  : ");
                                    a = int.Parse(Console.ReadLine());
                                    Console.Write ("Enter the height integer  : ");
                                    b = int.Parse(Console.ReadLine());
                                    v = VolumeOfCone(a, b);
                                    Console.WriteLine();
                                    Console.WriteLine ("Volume of Cone = 1/3 * PHI * r * r * h");
                                    Console.WriteLine ($"               = 1/3 * PHI * {a} * {a} * {b}");
                                    Console.WriteLine ($"               = {v}");
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------------THANK U---------------------------");
                                break;

                                case 9:
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------AREA OF ROUND--------------------");
                                    Console.WriteLine();
                                    Console.Write ("Enter the radius integer  : ");
                                    a = int.Parse(Console.ReadLine());
                                    v = AreaOfRound(a);
                                    Console.WriteLine();
                                    Console.WriteLine ("Area of Round = 4 * PHI * r * r");
                                    Console.WriteLine ($"              = 4 * PHI * {a} * {a}");
                                    Console.WriteLine ($"              = {v}");
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------------THANK U---------------------------");
                                break;

                                case 10:
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------VOLUME OF ROUND--------------------");
                                    Console.WriteLine();
                                    Console.Write ("Enter the radius integer  : ");
                                    a = int.Parse(Console.ReadLine());
                                    v = VolumeOfRound(a);
                                    Console.WriteLine();
                                    Console.WriteLine ("Area of Round = 4/3 * PHI * r * r * r");
                                    Console.WriteLine ($"              = 4/3 * PHI * {a} * {a} * {a}");
                                    Console.WriteLine ($"              = {v}");
                                    Console.WriteLine();
                                    Console.WriteLine ("--------------------------THANK U---------------------------");
                                break;

                                default:
                                    Console.WriteLine ("--------------------------THANK U---------------------------");
                                break;
                            }
                        break;

                        default:
                        break;
                    }
                }
                 while (choice != 6);
                /*Console.Write ("Enter ur first integer : ");
                a = int.Parse(Console.ReadLine());
                Console.Write ("Enter ur second integer : ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"First Integer  : {a}");
                Console.WriteLine($"Second Integer : {b}");
                Console.WriteLine($"The sum of first integer + second integer : {a + b}");
                Console.WriteLine();*/
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("You wrote the wrong answer, try again!");
                Console.WriteLine();
            }
            

        }
    }
}

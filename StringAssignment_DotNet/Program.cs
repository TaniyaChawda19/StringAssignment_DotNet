using System;
using System.Security.Cryptography;

namespace StringAssignment_DotNet
{

    //Question 
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "The quick brown fox jumps over the lazy dog";


            Console.WriteLine("Character at 12th index : " + s1[12]);//Question 1

            Console.WriteLine(" ");

            var flag = s1.Contains("is"); //Question 2
            if (flag == true)
            {
                Console.WriteLine("String contain 'is' ");
            }
            else
            {
                Console.WriteLine("String does not contain 'is'");
            }

            Console.WriteLine(" ");

            string s2 = string.Concat(s1, " and kill it"); //Question 3
            Console.WriteLine("After adding 'and kill it' ,new string :");
            Console.WriteLine(s2); // add and kill it at the end
            Console.WriteLine(" ");

            var end = s1.EndsWith("dogs"); //Question 4
            if (end == false)
            {
                Console.WriteLine("String does not ends with 'dogs'");

            }
            else
            {
                Console.WriteLine("String ends with 'dogs'");
            }

            Console.WriteLine(" ");

            var s3 = "The quick brown Fox jumps over the lazy Dog"; //Question 5
            if (s1 == s3)
            {
                Console.WriteLine("'The quick brown fox jumps over the lazy dog' and 'The quick brown Fox jumps over the lazy Dog' are equal");

            }
            else
            {
                Console.WriteLine("'The quick brown fox jumps over the lazy dog' and 'The quick brown Fox jumps over the lazy Dog' are not equal");

            }


            Console.WriteLine(" ");

            var s4 = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"; //Question 6
            if (s1 != s4)
            {
                Console.WriteLine("'The quick brown fox jumps over the lazy dog' and 'THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG' are not equal");

            }
            else
            {
                Console.WriteLine("'The quick brown fox jumps over the lazy dog' and 'THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG' are equal");

            }
            Console.WriteLine(" ");

            Console.WriteLine("Length of the string : " + s1.Length);//Question 7
            Console.WriteLine(" ");

            var s5 = "The quick brown Fox jumps over the lazy Dog";//question 8
            if (s1 == s5)
            {
                Console.WriteLine("'The quick brown fox jumps over the lazy dog' and 'The quick brown Fox jumps over the lazy Dog' are  equal");

            }
            else
            {
                Console.WriteLine("'The quick brown fox jumps over the lazy dog' and 'The quick brown Fox jumps over the lazy Dog' are not equal");

            }
            Console.WriteLine(" ");

            Console.WriteLine("After Replacing 'The' with 'A', new string : "); //Question 9
            Console.WriteLine(s1.Replace("The", "A"));

            Console.WriteLine(" ");

            Console.WriteLine("Splitting string");//question 10
            string a = s1.Substring(0, 20);
            string b = s1.Substring(20);
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine(" ");
            Console.WriteLine("Name of animals: ");
            string[] word_in_string = s1.Split(" ");  //Question 11
            foreach (string val in word_in_string)
            {
                if (val == "fox" || val == "dog")
                {
                    Console.WriteLine(val);
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("Printing above string in lower case");//Question 12
            {
                Console.WriteLine(s1.ToLower());
            }

            Console.WriteLine(" ");

            Console.WriteLine("Printing above string in upper case");//Question 13
            {
                Console.WriteLine(s1.ToUpper());
            }
            Console.WriteLine(" ");

            Console.WriteLine("Index Position of character 'a' : " + s1.IndexOf('a'));//question 14

            Console.WriteLine(" ");

            Console.WriteLine("Index Position of character 'e' : " + s1.IndexOf('e'));//Question 15

            Console.WriteLine(" ");

            Console.WriteLine("Enter tomcat path"); //Question 16
            var path = Console.ReadLine();

            var new_path = @"WebApps/MyApps/Images" + path;

            Console.WriteLine("After adding given path ,tomcat path :");
            Console.WriteLine(new_path);
            Console.WriteLine(" ");
            var poem = @"I WANDER'D lonely as a cloud
That floats on high o'er vales and hills, 
When all at once I saw a crowd,
A host, of golden daffodils;Beside the lake, beneath the trees,
Fluttering and dancing in the breeze.";
            Console.WriteLine(poem);          //question 17
            Console.WriteLine(" ");



        }
    }

    class OtherExcerciseQues1
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter number 1 : ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2 : ");
            b = Convert.ToInt32(Console.ReadLine());

            a = a - b;
            b = a + b;
            a = b - a;
            Console.WriteLine("After Swapping :");
            Console.WriteLine("number 1 = " + a);
            Console.WriteLine("number 2 = " + b);

        }
    }

    class OtherExcerciseQues2
    {
        static void Main(string[] args)
        {
            int N;
            int gross = 0, dozen = 0, rem = 0;
            Console.Write("Enter Number of Eggs : ");
            N = Convert.ToInt32(Console.ReadLine());

            while (N >= 144)
            {
                gross += 1;
                N -= 144;
            }
            while (N >= 12)
            {
                dozen += 1;
                N -= 12;
            }
            rem += N;
            Console.WriteLine("Your number of eggs is " + gross + " gross, " + dozen + " dozen, and " + rem + " remaining");

        }
    }

    class OtherExcerciseQues3
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Enter the year : ");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine(year + " is a leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine(year + " is not a leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine(year + " is a leap year");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year");
            }
        }
    }

    class OtherExcerciseQues4
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a < 0 || a > 255 || b < 0 || b > 255 || c < 0 || c > 255)
                Console.WriteLine("Runtime Error!");
            if (a == 0 && b == 0 && c != 0) Console.WriteLine("Bluish");
            else if (a == 0 && b != 0 && c == 0) Console.WriteLine("Greenish");
            else if (a != 0 && b == 0 && c == 0) Console.WriteLine("Redish");
        }
    }
    class OtherExcerciseQues5
    {
        static void Main(string[] args)
        {

            int quantity;
            double price;
            Console.Write("Enter  product code : ");
            char val = char.Parse(Console.ReadLine());
            Console.Write("Enter quantity : ");
            quantity = int.Parse(Console.ReadLine());
            Type tp = val.GetType();
            
                switch (val)
                {
                    case 'A':
                        price = 22.50 * quantity;
                        Console.Write("Total Price : " + price);

                        break;
                    case 'a':
                        price = 22.50 * quantity;
                        Console.Write("Total Price : " + price);

                        break;
                    case 'b':
                        price = 44.50 * quantity;
                        Console.Write("Total Price : " + price);

                        break;
                    case 'B':
                        price = 44.50 * quantity;
                        Console.Write("Total Price : " + price);
                        break;
                    case 'c':
                        Console.Write("Total Price : " + (9.98 * quantity));
                        break;
                    case 'C':
                        Console.Write("Total Price : " + (9.98 * quantity));
                        break;

                    default:
                        Console.Write("Wrong input");
                    break;


                
            }



        }
    }

}
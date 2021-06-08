using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulations
{
    class StringManipulator
    {
        public void convertString()
        {
            string str = "this is made by Dinith Jayabodhi with Tims Video";
            Console.WriteLine($"in lower case : {str.ToLower()}");

            Console.WriteLine($"in upper case : {str.ToUpper()}");

            TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;


            Console.WriteLine($"in title case: {currentTextInfo.ToTitleCase(str)} .");
        }

        public void StringAsArray()
        {
            string str = "Dinith";

            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }

        public void EscapeString()
        {
            string str;
            str = "This is my \"sample\" string";
            Console.WriteLine(str);

            str = "C:\\Demo\\file.txt";
            Console.WriteLine(str);

            str = @"C:\Demo\file.txt";
            Console.WriteLine(str);

        }

        public void InterpolationLiteral()
        {
            string str;
            string firstName = "dinith";

            Console.WriteLine($@"sample path: C:\Demo\{firstName}\file.txt");
        }
    }

   
}

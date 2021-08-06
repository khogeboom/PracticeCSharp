using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace StringManipulationVideo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            //StringConversion();
            //StringAsArray();
            //EscapeString();
            //AppendingStrings();
            //InterpolationAndLiteral();
            //StringBuilderDemo();
            //WorkingWithArrays();
            //PadAndTrim();
            //SearchingStrings();
            //OrderingStrings();
            //TestingEquality();
            //GettingASubstring();
            //ReplacingText();
            //InsertingText();
            //RemovingText();

            Console.ReadKey();
        }

        private static void StringConversion()
        {
            string testString = "tHis iS tHe FBI Calling!";
            TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
            TextInfo englishTextInfo = new CultureInfo("en-US", false).TextInfo;
            string result;

            result = testString.ToLower();
            Console.WriteLine();

            result = testString.ToUpper();
            Console.WriteLine();

            result = englishTextInfo.ToTitleCase(testString);
            Console.WriteLine(result);
        }

        private static void StringAsArray()
        {
            string testString = "Timothy";

            for (int i = 0; i < testString.Length; i++)
            {
                Console.WriteLine(testString[i]);
            }
        }

        private static void EscapeString()
        {
            string results;

            results = "This is my \"test\" solution.";
            //ouput = This is my "test" solution
            //need \ to allow quotation mark to show in output
            Console.WriteLine(results);

            results = "C:\\Demo\\Test.txt";
            //need \\ for output to show one \
            Console.WriteLine(results);

            results = @"C:\Demo\Test.txt";
            //@ = read the literal string
            Console.WriteLine(results);
        }

        private static void AppendingStrings()
        {
            string firstName = "Tim";
            string lastName = "Corey";
            string results;

            results = firstName + ", my name is " + firstName + " " + lastName;
            Console.WriteLine(results);

            results = string.Format("{0}, my name is {0} {1}", firstName, lastName);
            Console.WriteLine("{0}, my name is {0} {1}", firstName, lastName);
            //string.Format is built in so you can just put it straight into Console.Writeline()
            Console.WriteLine(results);

            results = $"{firstName}, my name is {firstName} {lastName}";
            Console.WriteLine(results);
        }

        private static void InterpolationAndLiteral()
        {
            string testString = "Tim Corey";
            string results = $@"C:\Demo\{testString}\{"\""}Test{"\""}.txt";
            //@ handles \
            //$ handles {testString}

            Console.WriteLine(results);
        }

        private static void StringBuilderDemo()
        {
            string testString = "Test";
            testString = "Tim";
            testString += " is a cool guy";

            Stopwatch regularStopwatch = new Stopwatch();
            regularStopwatch.Start();

            string test = "";
            //still creates a string in memory (just a very small one)

            for (int i = 0; i < 100000; i++)
            {
                test += i;
            }

            regularStopwatch.Stop();
            //calculates how long it takes to do 100000 string manipulations
            Console.WriteLine($"Regular Stopwatch: {regularStopwatch.ElapsedMilliseconds}ms");


            //new stopwatch
            Stopwatch builderStopwatch = new Stopwatch();
            builderStopwatch.Start();

            StringBuilder sb = new();

            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }

            builderStopwatch.Stop();
            Console.WriteLine($"Regular Stopwatch: {builderStopwatch.ElapsedMilliseconds}ms");
        }

        private static void WorkingWithArrays()
        {
            int[] ages = new int[] { 6, 7, 8, 3, 5 };
            string results;

            results = String.Concat(ages);
            Console.WriteLine(results);

            results = String.Join(",", ages);
            Console.WriteLine(results);

            Console.WriteLine();

            string testString = "Jon,Tim,Mary,Sue,Bob,Jane";
            string[] resultsArray = testString.Split(',');

            Array.ForEach(resultsArray, x => Console.WriteLine(x));

            //new example
            Console.WriteLine();

            testString = "Jon, Tim, Mary, Sue, Bob, Jane";
            resultsArray = testString.Split(", ");

            Array.ForEach(resultsArray, x => Console.WriteLine(x));
        }

        private static void PadAndTrim()
        {
            string testString = "     Hello World     ";
            string results;

            results = testString.TrimStart();
            Console.WriteLine($"'{results}'");

            results = testString.TrimEnd();
            Console.WriteLine($"'{results}'");

            results = testString.Trim();
            Console.WriteLine($"'{results}'");

            testString = "1.15";

            results = testString.PadLeft(10, '0');
            Console.WriteLine(results);

            results = testString.PadRight(10, '0');
            Console.WriteLine(results);
        }

        private static void SearchingStrings()
        {
            string testString = "This is a test of the search. Let's see how its testing works out.";
            bool resultsBoolean;
            int resultsInt;

            //StartsWith
            resultsBoolean = testString.StartsWith("This is");
            Console.WriteLine($"Starts with \"This is\": {resultsBoolean}");

            resultsBoolean = testString.StartsWith("This Is");
            Console.WriteLine($"Starts with \"This Is\": {resultsBoolean}");

            //Endswith
            resultsBoolean = testString.EndsWith("works out.");
            Console.WriteLine($"Ends with \"works out.\": {resultsBoolean}");

            resultsBoolean = testString.EndsWith("work out.");
            Console.WriteLine($"Ends with \"work out.\": {resultsBoolean}");

            //Contains
            resultsBoolean = testString.Contains("test");
            Console.WriteLine($"Contains \"test\": {resultsBoolean}");

            resultsBoolean = testString.Contains("tests");
            Console.WriteLine($"Contains \"tests\": {resultsBoolean}");

            //find location in string starting at beginning of string
            resultsInt = testString.IndexOf("test");
            Console.WriteLine($"Index of \"test\": {resultsInt}");

            resultsInt = testString.IndexOf("test", 11);
            Console.WriteLine($"Index of \"test\" after character 10: {resultsInt}");

            resultsInt = testString.IndexOf("test", 49);
            Console.WriteLine($"Index of \"test\" after character 48: {resultsInt}");

            //find location in string starting at end of string
            resultsInt = testString.LastIndexOf("test");
            Console.WriteLine($"Index of \"test\": {resultsInt}");

            resultsInt = testString.LastIndexOf("test", 50);
            Console.WriteLine($"Index of \"test\" before character 48: {resultsInt}");

            resultsInt = testString.LastIndexOf("test", 10);
            Console.WriteLine($"Index of \"test\" before character 10: {resultsInt}");

            //can also use do-while loop
            //while (testString.IndexOf("test", i) > -1)
            //{
            //    //whatever you want to execute
            //}
        }

        private static void OrderingStrings()
        {
            CompareToHelper("Mary", "Bob");
            CompareToHelper("Mary", null);
            CompareToHelper("Adam", "Bob");
            CompareToHelper("Bob", "Bob");

            Console.WriteLine();

            CompareHelper("Mary", "Bob");
            CompareHelper("Mary", null);
            CompareHelper(null, "Bob");
            CompareHelper("Adam", "Bob");
            CompareHelper("Bob", "Bob");
            CompareHelper("Bob", "Bobby");
            CompareHelper(null, null);

            Console.WriteLine();
        }

        private static void CompareToHelper(string testA, string? testB)
        {
            int resultsInt = testA.CompareTo(testB);
            switch (resultsInt)
            {
                case > 0:
                    Console.WriteLine($"CompareTo: { testB ?? "null" } comes before { testA }");
                    break;
                case < 0:
                    Console.WriteLine($"CompareTo: { testA } comes before { testB }");
                    break;
                case 0:
                    Console.WriteLine($"CompareTo: { testA } is the same as { testB }");
                    break;
                
            }
        }

        private static void CompareHelper(string? testA, string? testB)
        {
            int resultsInt = String.Compare(testA, testB);

            switch (resultsInt)
            {
                case > 0:
                    Console.WriteLine($"Compare: { testB ?? "null" } comes before { testA }");
                    break;
                case < 0:
                    Console.WriteLine($"Compare: { testA ?? "null" } comes before { testB }");
                    break;
                case 0:
                    Console.WriteLine($"Compare: { testA ?? "null" } is the same as { testB ?? "null" }");
                    break;
            }
        }

        private static void TestingEquality()
        {
            EqualityHelper("Bob", "Mary");
            EqualityHelper(null, "");
            EqualityHelper("", " ");
            EqualityHelper("Bob", "bob");
        }

        private static void EqualityHelper(string? testA, string? testB)
        {
            bool resultsBoolean;

            resultsBoolean = String.Equals(testA, testB);
            if (resultsBoolean)
            {
                Console.WriteLine($"Equals: '{ testA ?? "null" }' equals '{ testB ?? "null" }'");
            }
            else
            {
                Console.WriteLine($"Equals: '{ testA ?? "null" }' does not equal '{ testB ?? "null" }'");
            }

            resultsBoolean = String.Equals(testA, testB, StringComparison.InvariantCultureIgnoreCase);
            if (resultsBoolean)
            {
                Console.WriteLine($"Equals (ignore case): '{ testA ?? "null" }' equals '{ testB ?? "null" }'");
            }
            else
            {
                Console.WriteLine($"Equals (ignore case): '{ testA ?? "null" }' does not equal '{ testB ?? "null" }'");
            }

            resultsBoolean = testA == testB;
            if (resultsBoolean)
            {
                Console.WriteLine($"==: '{ testA ?? "null" }' equals '{ testB ?? "null" }'");
            }
            else
            {
                Console.WriteLine($"==: '{ testA ?? "null" }' does not equal '{ testB ?? "null" }'");
            }

            Console.WriteLine();
        }

        private static void GettingASubstring()
        {
            string testString = "This is a test of substring. Let's see how its testing works out.";
            string results;

            results = testString.Substring(5);
            // display string starting at position 5
            Console.WriteLine(results);

            results = testString.Substring(5, 4);
            //display string starting at position 5 and go 4 characters
            Console.WriteLine(results);
        }

        private static void ReplacingText()
        {
            string testString = "This is a test of substring. Let's see how its testing Works out for test.";
            string results;

            results = testString.Replace("test", "trial");
            Console.WriteLine(results);

            results = testString.Replace(" test ", " trial ");
            Console.WriteLine(results);

            results = testString.Replace("works", "makes");
            //doesn't work because case sensitive
            Console.WriteLine(results);

            results = testString.Replace("works", "makes", StringComparison.InvariantCultureIgnoreCase);
            Console.WriteLine(results);
        }

        private static void InsertingText()
        {
            string testString = "This is a test of insert. Let's see how its testing works out for test.";
            string results;

            results = testString.Insert(5, "(test) ");
            Console.WriteLine(results);
        }

        private static void RemovingText()
        {
            string testString = "This is a test of remove. Let's see how its testing works out for test.";
            string results;

            results = testString.Remove(25);
            //remove everything after character 25
            Console.WriteLine(results);

            results = testString.Remove(14, 10);
            //remove everything after character 14 for 10 characters
            Console.WriteLine(results);
        }
    }
}

using System.Diagnostics;

namespace CoreCalc
{
    public class Circus
    {
        /// <summary>
        /// This method works with <paramref name="firstName"/> and <paramref name="lastName"/>.
        /// </summary>
        /// <param name="firstName">A <seealso cref="String"/> that consists of the first name.</param>
        /// <returns></returns>
        public string DogHouse(string firstName, string lastName)
        {
            // TODO: So this is the thing.
            List<string> @string = new List<string>();
            const string myStr = "This is a regular string with a reference to firstName and lastName.";
            // This is a regular comment with a reference to firstName and lastName and DogHouse() method.
            return "My name is \"Mark Miller\" \r\n.";
        }
    }
    public class Browser
    {
        /// <summary>
        /// This property returns a <seealso cref="Circus"/> reference.
        /// </summary>
        public Circus? Circus { get; set; }
    }
    public class Anchor
    {
        public Browser? GetBrowser()
        {
            return new Browser();
        }
    }
    public class MyClass
    {
        /// <summary>
        /// Returns the result of <paramref name="num1"/> times <paramref name="num2"/> times <paramref name="num3"/>.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        void Multiply(double num1, double num2, double num3)
        {
            
        }
        public MyClass()
        {
            Multiply(1, 2, 3);

            Anchor mySuperAnchor = new Anchor();
            // TODO: I'd like to initialize mySuperAnchor anchor from MyClass and after that make a call to Multiply().
            Debug.WriteLine($$"""
                Here I'd like to call {{nameof(mySuperAnchor.GetBrowser)}}...
                
            """);
            Debug.WriteLine($"""
                Here I'd like to call {nameof(mySuperAnchor.GetBrowser)}.
                Here I'd like to call {nameof(mySuperAnchor.GetBrowser)}.

                The result is {mySuperAnchor.GetBrowser()}..
            """);
        }
    }
    public class Calculator
    {
        int won = 1;
        private const double UnchangingYValue = 100d;
        public string Name { get; set; }
        // Name of one.
        //    name[1]
        //    nameof(won)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double AddTwoNumbers(double num1, double num2)
        {
            Console.WriteLine($@"This is myAnchor test {num1}
            Square root of the sum of the two numbers is {Math.Sqrt(num1+num2)}
            
            The distance to the point is {Math.Sqrt(num1*num1+num2*num2)}

            


");
            
            return num1 + num2;
        }

        double DistanceToPoint(double x)
        {
            Debug.WriteLine($"{nameof(UnchangingYValue)} is {UnchangingYValue}");
            return 0;
        }

        string AddTwoStrings(string firstString, string secondString)
        {
            if (firstString is IConvertible convertible)
                convertible.ToBoolean(null);
            Console.WriteLine($"");
            return firstString + " " + secondString;
        }

        double GetVectorLength(double x, double y)
        {
            Console.WriteLine($"The distance to the point is {Math.Sqrt(x*x+y*y)}");
            return Math.Sqrt(x * x + y * y);
        }

        private const string verbatimString = @"
			My name is ""Mark Miller"" 
			it's not ""bad"".
";

        // TODO: Say "Tab tab tab it's not quote bad quote." The "i" at the start is lowercase.
        // TODO: Document and solve casing issues.

        static int safetyScore = 44;
        private const string usage = "usage";
        
        // TODO: Try Ctrl+Alt and say "Name of verbatim string".
        private const string fact = $"fact {nameof(verbatimString)}";
        // BUG: Saw voice dictation as an identifier when inside a string field. Not sure how to duplicate.

        string message = $"Usage policy for {safetyScore} is {safetyScore switch  // Should be true on this line
        {
            > 90 => "Unlimited usage",   // << Should be false in this string
            > 80 => $"General {usage}, with daily safety check",    // << Should be true in this string
            > 70 => "Issues must be addressed within 1 week",   // << Should be false in this string
            > 50 => "Issues must be addressed within 1 day",
            _ => "Issues must be addressed before continued use",
        }}. And that's myAnchor {fact}.";    // << Should be true in this string

        void RawStringInterpolation(double X, double Y)
        {
            const string tabTest2 = "\t\t\tplease press the \"Tab\" key.";
            var pointMessage = $"""The point ("{X}, {Y}") is {Math.Sqrt(X * X + Y * Y):F3} from the origin""";
            
            // TODO: Support multiple levels of interpolation with raw string literals:
            var pointMessage2 = $$"""{The point {{{X}}, {{Y}}} is {{Math.Sqrt(X * X + Y * Y):F3}} from the origin}""";

            Console.WriteLine(pointMessage);
        }
        
// Output is:
// The point "2, 3" is 3.606 from the origin

        /// <summary>
        /// Gets the number of segments needed for the given template name.
        /// </summary>
        /// <param name="templateName">The template name.</param>
        /// <returns>The number of segments needed for the given template name.</returns>
        public static int GetNumSegmentsNeeded(string templateName)
        {
            if (string.IsNullOrEmpty(templateName))
                return 0;

            int numSegmentsNeeded = 0;
            bool insideDynamicPart = false;
            bool insideStaticPart = false;
            for (int i = 0; i < templateName.Length; i++)
            {
                if (templateName[i] == '?')
                {
                    if (insideDynamicPart)
                    {
                        insideDynamicPart = false;
                    }
                    else
                    {
                        insideDynamicPart = true;
                        insideStaticPart = false;
                        numSegmentsNeeded++;
                    }
                }
                else if (insideDynamicPart)
                    continue;
                else
                {
                    if (insideStaticPart)
                        continue;
                    insideStaticPart = true;
                    numSegmentsNeeded++;
                }
            }

            return numSegmentsNeeded;
        }
    }
}
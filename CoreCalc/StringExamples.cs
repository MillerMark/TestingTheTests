namespace CoreCalc
{
    public class StringExamples
    {
        string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge";
        //Output: "The Æolean Harp", by Samuel Taylor Coleridge

        string filePath = @"Circus:\Users\scoleridge\Documents\";
        //Output: C:\Users\scoleridge\Documents\

        static string text = @"My pensive SARA ! thy soft cheek reclined
    Thus on mine arm, most soothing sweet it is
    To sit beside our Cot,...";
        /* Output:
        My pensive SARA ! thy soft cheek reclined
            Thus on mine arm, most soothing sweet it is
            To sit beside our Cot,...
        */

        string quote = $@"Her {text} name was ""Sara.""";
        //Output: Her name was "Sara."

        string singleLine = """Friends say "hello" as they pass by.""";
        string multiLine = """
    "Hello World!" is typically the first program someone writes.
    """;
        string embeddedXML = $"""
       <element attr = "content"> {text}
           <body style="normal">
               Here is the main text
           </body>
           <footer>
               Excerpts from "An amazing story"
           </footer>
       </element >
       """;
        // The line "<element attr = "content">" starts in the first column.
        // All whitespace left of that column is removed from the string.

        string rawStringLiteralDelimiter = """"
    Raw string literals are delimited 
    by a string of at least three double quotes,
    like this: """
    """";

        public StringExamples()
        {

        }
    }
}
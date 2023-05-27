using System;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string inputChar)
    {
        
        var indexStart = str.IndexOf(inputChar) + inputChar.Length;
        // if inputChar not exist in this string
        if (indexStart == -1)
            return str;
        return str.Substring(indexStart);
        ///////////////////////////////////////////////////////////
        //var log = "[INFO]: File Deleted.";
        //log.SubstringAfter(": "); // => returns "File Deleted."
        ///////////////////////////////////////////////////////////

    }
    public static string SubstringBetween(this string str, string start, string end)
    {
        var indexStartChar = str.IndexOf(start) + start.Length;
        var indexEndChar = str.LastIndexOf(end);
        
        if (indexStartChar == -1)
            indexStartChar = 0;
        if (indexEndChar == -1)
            indexEndChar = str.Length;

        return str.Substring(indexStartChar, indexEndChar - indexStartChar);

        ///////////////////////////////////////////////////////////
        //var log = "[INFO]: File Deleted.";
        //log.SubstringBetween("[", "]"); // => returns "INFO"
        ///////////////////////////////////////////////////////////

    }

    public static string Message(this string str)
    {
        
        return str.SubstringAfter(": ");

        ///////////////////////////////////////////////////////////
        //var log = "[ERROR]: Missing ; on line 20.";
        //log.Message(); // => returns "Missing ; on line 20."
        ///////////////////////////////////////////////////////////
    }

    public static string LogLevel(this string str)
    {

        return str.SubstringBetween("[","]");

        ///////////////////////////////////////////////////////////
        //var log = "[ERROR]: Missing ; on line 20.";
        //log.LogLevel(); // => returns "ERROR"
        ///////////////////////////////////////////////////////////
    }


    // TODO: define the 'Message()' extension method on the `string` type

    // TODO: define the 'LogLevel()' extension method on the `string` type
}
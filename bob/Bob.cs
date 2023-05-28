using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Bob
{
    //public static string RemoveSpecialCharacters(string input)
    //{
    //    string pattern = "[^a-zA-Z]";
    //    string replacement = "";
    //    Regex regex = new Regex(pattern);
    //    string result = regex.Replace(input, replacement);
    //    return result;
    //}
    //static bool ContainsLetter(string input)
    //{
    //    return input.Any(char.IsLetter);
    //}


    static bool IsQuestion(string input)
    {
        return input.Trim().EndsWith("?");
    }

    static bool IsYelling(string input)
    {
        return input.Any(char.IsLetter) && input.ToUpper() == input;
    }

    static bool IsYellingQuestion(string input)
    {
        return IsQuestion(input) && IsYelling(input);

    }
    public static string Response(string input)
    {
        #region old code

        //// check is question ?
        //bool isEndWithQuestionMark = statement.TrimEnd().EndsWith("?");

        //// then remove SpecialCharAndNumber
        //string statementAfterRemovedSpecialCharAndNumber = RemoveSpecialCharacters(statement);
        //// check if empty after remove
        //bool isEmptyAfterRemoved =  String.IsNullOrEmpty(statementAfterRemovedSpecialCharAndNumber);
        //// check is contain letters
        //bool isContainLetters = ContainsLetter(statement);
        //// check is Uppercase with no empty string condition and the statement string HAVE TO character
        //bool isUpperCase = statementAfterRemovedSpecialCharAndNumber.All(c=> char.IsUpper(c) && isEmptyAfterRemoved == false) && isContainLetters;
        //if (string.IsNullOrWhiteSpace(statement))
        //{
        //    return "Fine. Be that way!";
        //}
        //else if (isEndWithQuestionMark && isUpperCase)
        //{
        //    return "Calm down, I know what I'm doing!";
        //}
        //else if (isEndWithQuestionMark && !isUpperCase)
        //{
        //    return "Sure.";
        //}
        //else if (!isEndWithQuestionMark && isUpperCase)
        //{
        //    return "Whoa, chill out!";
        //}
        //else
        //{
        //    return "Whatever.";
        //}

        #endregion


        if (string.IsNullOrWhiteSpace(input))
        {
            return "Fine. Be that way!";
        }
        else if (IsYellingQuestion(input))
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (IsYelling(input))
        {
            return "Whoa, chill out!";
        }
        else if (IsQuestion(input))
        {
            return "Sure.";
        }
        else
        {
            return "Whatever.";
        }

    }
    /*
    Bob only answers one of five things bellow  
    "Sure."  => This is his response if you ask him a question, such as "How are you?" The convention used for questions is that it ends with a question mark.
    "Whoa, chill out!" => This is his answer if you YELL AT HIM. The convention used for yelling is ALL CAPITAL LETTERS.
    "Calm down, I know what I'm doing!" =>  This is what he says if you yell a question at him.
    "Fine. Be that way!" =>  This is how he responds to silence. The convention used for silence is nothing, or various combinations of whitespace characters.
    "Whatever." =>  This is what he answers to anything else.

     */
}
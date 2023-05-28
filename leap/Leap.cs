using System;

public static class Leap
{
    static bool Divisibleby100(int year)
    {
        return year % 100 == 0;
    }
    static bool Divisibleby400(int year)
    {
        return year % 400 == 0;
    }

    static bool Divisibleby4(int year)
    {
        return year % 4 == 0;
    }
    public static bool IsLeapYear(int year)
    {
        if (Divisibleby100(year))
        {
            if (Divisibleby400(year))
            {
                return true;
            }
        }
        else
        {
            if (Divisibleby4(year))
            {
                return true;
            }

        }
        return false;
    }
}
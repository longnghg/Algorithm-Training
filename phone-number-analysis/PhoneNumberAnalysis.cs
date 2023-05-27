using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var a = phoneNumber.ToLower();
        bool isNewYorkResult = default;
        bool isFakeResult = default;
        string localNumberResult = default;

        var arrStrSplit = phoneNumber.Split("-");

        if (arrStrSplit[0] == "212")
            isNewYorkResult = true;
        if (arrStrSplit[1] == "555")
            isFakeResult = true;

        localNumberResult = arrStrSplit[2];
        return (isNewYorkResult,isFakeResult,localNumberResult);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}  

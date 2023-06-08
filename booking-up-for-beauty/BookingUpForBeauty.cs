using System;
using System.Collections.Generic;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        var dateTime = DateTime.Parse(appointmentDateDescription);
        return dateTime;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        if (DateTime.Compare(DateTime.Now,appointmentDate) >0)
            return true;
        return false;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        if (appointmentDate.Hour >= 12 && appointmentDate.Hour < 18)
        {
            return true;
        }
        return false;
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15);
    }
}

using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        int length = birdsPerDay.Length- 1;
        return birdsPerDay[length];
    }

    public void IncrementTodaysCount()
    {
        int length = birdsPerDay.Length - 1;
        birdsPerDay[length]++;
    }

    public bool HasDayWithoutBirds()
    {
        return  birdsPerDay.Any(x => x == 0); //birdsPerDay.Where(x => x == 0).Count() > 0;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int i = 0;
        int count = 0;
        while (i < numberOfDays)
        {
            count += birdsPerDay[i];
            i++;
        }
        return count;
    }

    public int BusyDays()
    {
        int count = 0;
        foreach (var birds in birdsPerDay)
        {
            if (birds >= 5)
            {
                count++;
            }
        }
        return count;
    }
}

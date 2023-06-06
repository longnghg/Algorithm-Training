using System;

class RemoteControlCar
{
    private int odoMeter;
    private int percentBattery;
    public RemoteControlCar()
    {
        odoMeter = 0;
        percentBattery = 100;
    }
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {odoMeter} meters";
    }

    public string BatteryDisplay()
    {
        if (percentBattery == 0)
            return "Battery empty";
        return $"Battery at {percentBattery}%";
    }

    public void Drive()
    {
        if (percentBattery > 0) {
            odoMeter += 20;
            percentBattery -= 1;
        }
    }
}

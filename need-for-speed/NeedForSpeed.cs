using System;
using System.Numerics;

class RemoteControlCar
{
    public int battery;
    public int odoMetter;
    private int speed;
    private int batteryDrain;
    public RemoteControlCar(int spd, int batteryDrain)
    {
        this.battery = 100;
        this.odoMetter = 0;
        this.speed = spd;
        this.batteryDrain = batteryDrain;
    }
    // TODO: define the constructor for the 'RemoteControlCar' class

    public bool BatteryDrained()
    {
        if (battery < batteryDrain)
            return true;
        return false;
    }
    public int DistanceDriven()
    {
        return this.odoMetter;
    }

    public void Drive()
    {
        if (this.battery - batteryDrain >= 0)
        {
            this.odoMetter += speed;
            this.battery -= batteryDrain;
        }
    }
    internal int GetBatteryDrain()
    {
        return this.batteryDrain;
    }
    internal int GetSpeedCar()
    {
        return this.speed;
    }
    public static RemoteControlCar Nitro()
    {
        int nitroBatteryDrain = 4;
        var nitroCar = new RemoteControlCar(50, nitroBatteryDrain);
        return nitroCar;
    }
}

class RaceTrack
{
    private int distance;
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
       
        var maxDistanceCarCanFinished = (100 / car.GetBatteryDrain()) * car.GetSpeedCar(); 
        if (maxDistanceCarCanFinished < distance)
        {
            return false;
        }
        return true;
    }
}

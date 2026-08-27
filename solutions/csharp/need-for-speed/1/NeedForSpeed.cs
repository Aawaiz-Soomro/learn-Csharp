class RemoteControlCar
{
    public int speed;
    public int batteryDrain;
    private int distanceCovered;
    public int batteryPercentage = 100;
    
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar (int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }
    

    public bool BatteryDrained()
    {
        if (batteryPercentage < batteryDrain)
            return true;
        else
            return false;
    }

    public int DistanceDriven()
    {
        return distanceCovered; 
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
        distanceCovered += speed;
        batteryPercentage -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        var nitroCar = new RemoteControlCar (50,4);
        return nitroCar;
    }
}

class RaceTrack
{
    int distance;
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack (int distance)
    {
        this.distance = distance;
    }
    
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.DistanceDriven() < distance)
        {
            if (!car.BatteryDrained())
            {
                car.Drive();
            }
            else
                return false;
        }
        return true;
    }
}

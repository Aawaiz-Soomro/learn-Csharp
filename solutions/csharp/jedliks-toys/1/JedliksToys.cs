class RemoteControlCar
{
    private int Distance = 0;
    private int Battery = 100;
    public static RemoteControlCar Buy()
    {
        RemoteControlCar car1 = new RemoteControlCar();
        return car1;
    }

    public string DistanceDisplay()
    {
        return $"Driven {Distance} meters";
    }

    public string BatteryDisplay()
    {
        if (Battery == 0)
            return "Battery empty";
            
        return $"Battery at {Battery}%";
    }

    public void Drive()
    {
        if (Battery > 0)
        {
            Distance += 20;
            Battery -= 1;
        }
        else
            BatteryDisplay();

        
    }
}

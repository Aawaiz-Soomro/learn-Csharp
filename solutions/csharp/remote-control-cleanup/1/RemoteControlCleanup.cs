public class RemoteControlCar
{
    public string CurrentSponsor { get; private set; }
    public Telemetry Telemetry { get; }
    
    private Speed currentSpeed;

    public RemoteControlCar()
    {
        Telemetry = new Telemetry(this);
    }

    public string GetSpeed()
    {
        return currentSpeed.ToString();
    }

    // Changed to 'internal' so the outside Telemetry class can access them
    internal void SetSponsor(string sponsorName)
    {
        CurrentSponsor = sponsorName;
    }

    internal void SetSpeed(Speed speed)
    {
        currentSpeed = speed;
    }
}

// --- MOVED OUTSIDE THE CAR CLASS ---

public class Telemetry
{
    private readonly RemoteControlCar _car;

    public Telemetry(RemoteControlCar car)
    {
        _car = car;
    }

    public void Calibrate() { }

    public bool SelfTest()
    {
        return true;
    }

    public void ShowSponsor(string sponsorName)
    {
        _car.SetSponsor(sponsorName);
    }

    public void SetSpeed(decimal amount, string unitsString)
    {
        SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
        if (unitsString == "cps")
        {
            speedUnits = SpeedUnits.CentimetersPerSecond;
        }

        _car.SetSpeed(new Speed(amount, speedUnits));
    }
}

public struct Speed
{
    public decimal Amount { get; }
    public SpeedUnits SpeedUnits { get; }

    public Speed(decimal amount, SpeedUnits speedUnits)
    {
        Amount = amount;
        SpeedUnits = speedUnits;
    }

    public override string ToString()
    {
        string unitsString = "meters per second";
        if (SpeedUnits == SpeedUnits.CentimetersPerSecond)
        {
            unitsString = "centimeters per second";
        }
        return Amount + " " + unitsString;
    }
}

public enum SpeedUnits
{
    MetersPerSecond,
    CentimetersPerSecond
}
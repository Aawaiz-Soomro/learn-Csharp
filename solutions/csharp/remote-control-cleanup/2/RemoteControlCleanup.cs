using System;

public class RemoteControlCar
{
    public string CurrentSponsor { get; private set; }
    public Telemetry Telemetry { get; }
    
    private Speed currentSpeed;

    public RemoteControlCar()
    {
        // Kept in the constructor because 'this' cannot be used in a property initializer
        Telemetry = new Telemetry(this); 
    }

    // Condensed to an expression-bodied method
    public string GetSpeed() => currentSpeed.ToString();

    internal void SetSponsor(string sponsorName) => CurrentSponsor = sponsorName;

    internal void SetSpeed(Speed speed) => currentSpeed = speed;
}

public class Telemetry
{
    private readonly RemoteControlCar _car;

    public Telemetry(RemoteControlCar car)
    {
        _car = car;
    }

    public void Calibrate() { }

    // Condensed to an expression-bodied method
    public bool SelfTest() => true;

    // Condensed to an expression-bodied method
    public void ShowSponsor(string sponsorName) => _car.SetSponsor(sponsorName);

    public void SetSpeed(decimal amount, string unitsString)
    {
        SpeedUnits speedUnits = unitsString == "cps" ? SpeedUnits.CentimetersPerSecond : SpeedUnits.MetersPerSecond;
        _car.SetSpeed(new Speed(amount, speedUnits));
    }
}

public enum SpeedUnits
{
    MetersPerSecond,
    CentimetersPerSecond
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
        string unitsString = SpeedUnits == SpeedUnits.CentimetersPerSecond ? "centimeters per second" : "meters per second";
        
        // Replaced concatenation with string interpolation
        return $"{Amount} {unitsString}"; 
    }
}
class WeighingMachine
{
    // TODO: define the 'Precision' property
    public int Precision {get;}
    // TODO: define the 'Weight' property
    private double _weight;
    public double Weight {
        get {return _weight;}
        set 
        {
                if (value >= 0)
                    _weight = value;
                else
                    throw new ArgumentOutOfRangeException ();  
        }
    }
    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment {get; set;}
    // TODO: define the 'DisplayWeight' property
    private double _displayWeight;
    public string DisplayWeight
{
    get
    {
        double finalWeight = this.Weight - this.TareAdjustment;
        
        // This formats the double to a string with the exact number of decimal places specified by 'Precision'
        return $"{finalWeight.ToString($"F{this.Precision}")} kg";
    }
}

    public WeighingMachine (int precision)
    {
        this.Precision = precision;
        this.TareAdjustment = 5;
    }

    
    
}



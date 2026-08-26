class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int [] arr = {0,2,5,3,7,8,4};
        return arr;
    }

    public int Today()
    {
        return this.birdsPerDay [birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
        this.birdsPerDay [birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int num in this.birdsPerDay)
        {
            if (num == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        var total_count = 0;
        for (int i=0;i<numberOfDays;i++)
        {     
            total_count += birdsPerDay [i];
        }
        return total_count;
    }

    public int BusyDays()
    {
        var busyDays = 0;
        foreach (int numberOfBirds in this.birdsPerDay)
        {
            
            if (numberOfBirds >= 5)
                busyDays++;            
        }
        return busyDays;
    }
}

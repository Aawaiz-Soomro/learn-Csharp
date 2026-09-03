public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }
}

public struct Plot
{
    // TODO: Complete implementation of the Plot struct
    public Coord Point1 {get;}
    public Coord Point2 {get;}
    public Coord Point3 {get;}
    public Coord Point4 {get;}

    public Plot (Coord Point1, Coord Point2, Coord Point3, Coord Point4)
    {
        this.Point1 = Point1;
        this.Point2 = Point2;
        this.Point3 = Point3;
        this.Point4 = Point4;
    }
}


public class ClaimsHandler
{
    private List <Plot> stakedClaims = new List <Plot> ();
    
    public void StakeClaim(Plot plot)
    {
        stakedClaims.Add(plot);
        
    }

    public bool IsClaimStaked(Plot plot)
    {
        return stakedClaims.Contains(plot);
    }

    public bool IsLastClaim(Plot plot)
    {
        if (stakedClaims.Count == 0)
        {
            return false;
        }
        return plot.Equals( stakedClaims [stakedClaims.Count - 1]);
    }

    public Plot GetClaimWithLongestSide()
{
    Plot longestPlot = new Plot();
    int maxSideLength = -1;

    foreach (var plot in stakedClaims)
    {
        // Calculate the width (difference between highest and lowest X coordinates)
        int maxX = Math.Max(Math.Max(plot.Point1.X, plot.Point2.X), Math.Max(plot.Point3.X, plot.Point4.X));
        int minX = Math.Min(Math.Min(plot.Point1.X, plot.Point2.X), Math.Min(plot.Point3.X, plot.Point4.X));
        int width = maxX - minX;

        // Calculate the height (difference between highest and lowest Y coordinates)
        int maxY = Math.Max(Math.Max(plot.Point1.Y, plot.Point2.Y), Math.Max(plot.Point3.Y, plot.Point4.Y));
        int minY = Math.Min(Math.Min(plot.Point1.Y, plot.Point2.Y), Math.Min(plot.Point3.Y, plot.Point4.Y));
        int height = maxY - minY;

        // Find the longest side for this specific plot
        int currentLongestSide = Math.Max(width, height);

        // Update the overall longest plot if this one is bigger
        if (currentLongestSide > maxSideLength)
        {
            maxSideLength = currentLongestSide;
            longestPlot = plot;
        }
    }

    return longestPlot;
}
}

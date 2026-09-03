public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    // TODO: implement equality and GetHashCode() methods

    public override bool Equals (object obj)
    {
        if (obj is FacialFeatures otherFace)
        {
            return (this.EyeColor == otherFace.EyeColor && this.PhiltrumWidth ==     otherFace.PhiltrumWidth);
        }
        else return false;
    }

    public override int GetHashCode ()
    {
        return HashCode.Combine(EyeColor, PhiltrumWidth);
    }

    
    
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    // TODO: implement equality and GetHashCode() methods
    public override bool Equals(object obj)
{
    if (obj is Identity otherIdentity)
    {
        return Email == otherIdentity.Email && FacialFeatures.Equals(otherIdentity.FacialFeatures);
    }
    return false;
}

public override int GetHashCode()
{
    return HashCode.Combine(Email, FacialFeatures);
}
    
    
}

public class Authenticator
{
    private HashSet <Identity> registeredIdentities = new HashSet <Identity> ();
    
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        if (faceA.EyeColor == faceB.EyeColor )
        if (faceA.PhiltrumWidth == faceB.PhiltrumWidth)
            return true;

            return false;
    }


    public bool IsAdmin(Identity identity)
    {
        if (identity.Email == "admin@exerc.ism")
        if (AreSameFace (identity.FacialFeatures, new FacialFeatures (eyeColor : "green", philtrumWidth : 0.9m)))
            return true;

            return false;
    }

    public bool Register(Identity identity)
    {
        return registeredIdentities.Add(identity);
    }

    public bool IsRegistered(Identity identity) => registeredIdentities.Contains(identity);

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        return Object.ReferenceEquals(identityA, identityB);
    }
}

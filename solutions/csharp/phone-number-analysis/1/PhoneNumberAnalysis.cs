public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool IsNewYork, IsFake;
        IsNewYork = IsFake = false;
    
        if (phoneNumber.Split('-')[0] == "212")
            IsNewYork = true;
        
        if (phoneNumber.Split('-')[1] == "555")
            IsFake = true;

        string LocalNumber = phoneNumber.Split('-')[2];

        return (IsNewYork, IsFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        if (phoneNumberInfo.IsFake)
            return true;
        else
            return false;
    }
}

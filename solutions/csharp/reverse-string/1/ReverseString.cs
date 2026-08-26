public static class ReverseString
{
    public static string Reverse(string input)
    {
        string? reversedString = "";
        for (int i=input.Length-1;i>=0;i--)
        {
            reversedString += input [i];
        }
        return reversedString;
    }
}
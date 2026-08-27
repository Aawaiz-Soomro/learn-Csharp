public static class LogAnalysis 
{
    // "[<LEVEL>]: <MESSAGE>"
    
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiterString)
    {
        return str.Split(delimiterString)[1];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween (this string str, string delimiter1, string delimiter2)
    {
        int startIndex = str.IndexOf(delimiter1) + delimiter1.Length;
        int endIndex = str.IndexOf(delimiter2, startIndex);

        return str.Substring(startIndex,endIndex-startIndex);
    }

    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message (this string str)
    {
        return str.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel (this string str)
    {
        return str.SubstringBetween("[","]");
    }
}
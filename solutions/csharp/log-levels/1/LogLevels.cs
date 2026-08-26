static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(':')[1].Trim();
        // split @ ':' and access the second part of string and then trim it at white space.
    }

    public static string LogLevel(string logLine)
    {
        return logLine.Split(']')[0].ToLower().Trim('[');
        // Trim removes everything from left side
        // Split splits on the ']' bracket
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}

public static class Languages
{
    public static List<string> NewList()
    {
        return new List <string> {};
    }

    public static List<string> GetExistingLanguages()
    {
        List <string> languages = new List <string> {"C#",
                                   "Clojure",
                                   "Elm"};
        return languages;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains (language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        var reversedList = new List <string> {};
        for (int i=languages.Count-1; i>=0 ;i--)
        {
            reversedList.Add (languages[i]);
        }
        return reversedList;
    }

    public static bool IsExciting(List<string> languages)
    {
        
        if (languages.Count >= 1 && languages [0] == "C#")
            return true;
        
        if (languages.Count >= 2  && languages [1] == "C#")
        if (languages.Count == 2 || languages.Count == 3)
            return true;

        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove (language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        languages.Sort();

        for (int i=0; i<languages.Count-1; i++)
        {
            if (languages[i] == languages [i+1])
                return false;
        }
        return true;
    }
}

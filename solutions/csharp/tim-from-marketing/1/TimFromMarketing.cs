static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        department ??= "OWNER"; //Assigning default value
        if (id != null)
            return $"[{id}] - {name} - {department.ToUpper()}";
        else
            return $"{name} - {department.ToUpper()}";
        
            
    }
}

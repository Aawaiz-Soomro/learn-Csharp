using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder builder = new StringBuilder();
        bool isAfterDash = false;

        foreach (char c in identifier)
        {
            if (c == ' ')
                builder.Append('_');
            else if (char.IsControl(c))
                builder.Append ("CTRL");
            else if (c == '-' )
            {
                isAfterDash = true;
                continue;
            }
            else if (c >= 'α' && c <= 'ω')
            {
                // Do Nothing (Task 4)
            }
            else if (char.IsLetter(c))
            {
                if (isAfterDash)
                    builder.Append(char.ToUpperInvariant(c));
                else
                    builder.Append(c);
            }
            isAfterDash = false;
            
        }
        return builder.ToString();
    }
}

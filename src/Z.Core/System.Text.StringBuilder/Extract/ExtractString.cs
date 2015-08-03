using System.Text;

public static partial class Extensions
{
    /// <summary>A StringBuilder extension method that extracts the string described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted string.</returns>
    public static StringBuilder ExtractString(this StringBuilder @this)
    {
        return @this.ExtractString(0);
    }

    /// <summary>A StringBuilder extension method that extracts the string described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted string.</returns>
    public static StringBuilder ExtractString(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractString(0, out endIndex);
    }

    /// <summary>A StringBuilder extension method that extracts the string described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted string.</returns>
    public static StringBuilder ExtractString(this StringBuilder @this, int startIndex)
    {
        int endIndex;
        return @this.ExtractString(startIndex, out endIndex);
    }

    /// <summary>A StringBuilder extension method that extracts the string described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted string.</returns>
    public static StringBuilder ExtractString(this StringBuilder @this, int startIndex, out int endIndex)
    {
        if (@this.Length > startIndex + 1)
        {
            var ch1 = @this[startIndex];
            var ch2 = @this[startIndex + 1];

            if (ch1 == '@' && ch2 == '"')
            {
                // @"my string"

                return @this.ExtractStringArobasDoubleQuote(startIndex, out endIndex);
            }

            if (ch1 == '@' && ch2 == '\'')
            {
                // WARNING: This is not a valid string, however single quote is often used to make it more readable in text templating
                // @'my string'

                return @this.ExtractStringArobasSingleQuote(startIndex, out endIndex);
            }

            if (ch1 == '"')
            {
                // "my string"

                return @this.ExtractStringDoubleQuote(startIndex, out endIndex);
            }

            if (ch1 == '\'')
            {
                // WARNING: This is not a valid string, however single quote is often used to make it more readable in text templating
                // 'my string'

                return @this.ExtractStringSingleQuote(startIndex, out endIndex);
            }
        }

        endIndex = -1;
        return null;
    }
}
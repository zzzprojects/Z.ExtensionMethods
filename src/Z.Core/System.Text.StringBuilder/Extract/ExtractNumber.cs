using System.Text;

public static partial class Extensions
{
    /// <summary>A StringBuilder extension method that extracts the number described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted number.</returns>
    public static StringBuilder ExtractNumber(this StringBuilder @this)
    {
        return @this.ExtractNumber(0);
    }

    /// <summary>A StringBuilder extension method that extracts the number described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted number.</returns>
    public static StringBuilder ExtractNumber(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractNumber(0, out endIndex);
    }

    /// <summary>A StringBuilder extension method that extracts the number described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted number.</returns>
    public static StringBuilder ExtractNumber(this StringBuilder @this, int startIndex)
    {
        int endIndex;
        return @this.ExtractNumber(startIndex, out endIndex);
    }

    /// <summary>A StringBuilder extension method that extracts the number described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted number.</returns>
    public static StringBuilder ExtractNumber(this StringBuilder @this, int startIndex, out int endIndex)
    {
        // WARNING: This method support all kind of suffix for .NET Runtime Compiler
        // An operator can be any sequence of supported operator character
        var sb = new StringBuilder();

        var hasNumber = false;
        var hasDot = false;
        var hasSuffix = false;

        var pos = startIndex;

        while (pos < @this.Length)
        {
            var ch = @this[pos];
            pos++;

            if (ch >= '0' && ch <= '9' && !hasSuffix)
            {
                hasNumber = true;
                sb.Append(ch);
            }
            else if (ch == '.' && !hasSuffix && !hasDot)
            {
                hasDot = true;
                sb.Append(ch);
            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                hasSuffix = true;
                sb.Append(ch);
            }
            else
            {
                pos-= 2;
                break;
            }
        }

        if (hasNumber)
        {
            endIndex = pos;
            return sb;
        }

        endIndex = -1;
        return null;
    }
}
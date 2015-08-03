using System.Text;

public static partial class Extensions
{
    /// <summary>A StringBuilder extension method that extracts the operator described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted operator.</returns>
    public static StringBuilder ExtractOperator(this StringBuilder @this)
    {
        return @this.ExtractOperator(0);
    }

    /// <summary>A StringBuilder extension method that extracts the operator described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted operator.</returns>
    public static StringBuilder ExtractOperator(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractOperator(0, out endIndex);
    }

    /// <summary>A StringBuilder extension method that extracts the operator described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted operator.</returns>
    public static StringBuilder ExtractOperator(this StringBuilder @this, int startIndex)
    {
        int endIndex;
        return @this.ExtractOperator(startIndex, out endIndex);
    }

    /// <summary>A StringBuilder extension method that extracts the operator described by @this.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted operator.</returns>
    public static StringBuilder ExtractOperator(this StringBuilder @this, int startIndex, out int endIndex)
    {
        // WARNING: This method support custom operator for .NET Runtime Compiler
        // An operator can be any sequence of supported operator character
        var sb = new StringBuilder();

        var pos = startIndex;

        while (pos < @this.Length)
        {
            var ch = @this[pos];
            pos++;

            switch (ch)
            {
                case '`':
                case '~':
                case '!':
                case '#':
                case '$':
                case '%':
                case '^':
                case '&':
                case '*':
                case '(':
                case ')':
                case '-':
                case '_':
                case '=':
                case '+':
                case '[':
                case ']':
                case '{':
                case '}':
                case '|':
                case ':':
                case ';':
                case ',':
                case '.':
                case '<':
                case '>':
                case '?':
                case '/':
                    sb.Append(ch);
                    break;
                default:
                    if (sb.Length > 0)
                    {
                        endIndex = pos - 2;
                        return sb;
                    }

                    endIndex = -1;
                    return null;
            }
        }

        if (sb.Length > 0)
        {
            endIndex = pos;
            return sb;
        }

        endIndex = -1;
        return null;
    }
}
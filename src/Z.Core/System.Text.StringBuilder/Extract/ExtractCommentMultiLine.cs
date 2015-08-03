using System.Text;

public static partial class Extensions
{
    /// <summary>
    ///     A StringBuilder extension method that extracts the comment multi line described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The extracted comment multi line.</returns>
    public static StringBuilder ExtractCommentMultiLine(this StringBuilder @this)
    {
        return @this.ExtractCommentMultiLine(0);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the comment multi line described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted comment multi line.</returns>
    public static StringBuilder ExtractCommentMultiLine(this StringBuilder @this, out int endIndex)
    {
        return @this.ExtractCommentMultiLine(0, out endIndex);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the comment multi line described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <returns>The extracted comment multi line.</returns>
    public static StringBuilder ExtractCommentMultiLine(this StringBuilder @this, int startIndex)
    {
        int endIndex;
        return @this.ExtractCommentMultiLine(startIndex, out endIndex);
    }

    /// <summary>
    ///     A StringBuilder extension method that extracts the comment multi line described by
    ///     @this.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">[out] The end index.</param>
    /// <returns>The extracted comment multi line.</returns>
    public static StringBuilder ExtractCommentMultiLine(this StringBuilder @this, int startIndex, out int endIndex)
    {
        var sb = new StringBuilder();

        if (@this.Length > startIndex + 1)
        {
            var ch1 = @this[startIndex];
            var ch2 = @this[startIndex + 1];

            if (ch1 == '/' && ch2 == '*')
            {
                /*
                 * Multi-line comment
                 */

                sb.Append(ch1);
                sb.Append(ch2);
                var pos = startIndex + 2;

                while (pos < @this.Length)
                {
                    var ch = @this[pos];
                    pos++;

                    if (ch == '*' && pos < @this.Length && @this[pos] == '/')
                    {
                        sb.Append(ch);
                        sb.Append(@this[pos]);
                        endIndex = pos;
                        return sb;
                    }

                    sb.Append(ch);
                }

                endIndex = pos;
                return sb;
            }
        }

        endIndex = -1;
        return null;
    }
}
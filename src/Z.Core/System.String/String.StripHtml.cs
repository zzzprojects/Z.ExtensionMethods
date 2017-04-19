// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Text;

public static partial class Extensions
{
    /// <summary>A string extension method that strip HTML.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A string.</returns>
    public static string StripHtml(this string @this)
    {
        var path = new StringBuilder(@this);
        var sb = new StringBuilder();

        int pos = 0;

        while (pos < path.Length)
        {
            char ch = path[pos];
            pos++;

            if (ch == '<')
            {
                // LOOP until we close the html tag
                while (pos < path.Length)
                {
                    ch = path[pos];
                    pos++;

                    if (ch == '>')
                    {
                        break;
                    }

                    if (ch == '\'')
                    {
                        // SKIP attribute starting with single quote
                        pos = GetIndexAfterNextSingleQuote(path, pos, true);
                    }
                    else if (ch == '"')
                    {
                        // SKIP attribute starting with double quote
                        pos = GetIndexAfterNextDoubleQuote(path, pos, true);
                    }
                }
            }
            else
            {
                sb.Append(ch);
            }
        }

        return sb.ToString();
    }
}
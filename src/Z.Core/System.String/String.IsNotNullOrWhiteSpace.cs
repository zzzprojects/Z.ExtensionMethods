using System;

public static partial class Extensions
{
    /// <summary>
    ///     Indicates whether a specified string is not null, not empty, or not consists only of white-space characters.
    /// </summary>
    /// <param name="value">The string to test.</param>
    /// <returns>true if the  parameter is null or , or if  consists exclusively of white-space characters.</returns>
    public static Boolean IsNotNullOrWhiteSpace(this string value)
    {
        return !String.IsNullOrWhiteSpace(value);
    }
}
namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that query if '@this' is type of.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="type">The type.</param>
    /// <returns>true if type of, false if not.</returns>
    public static bool IsTypeOf<T>(this T @this, Type type)
    {
        return @this.GetType() == type;
    }
}

}
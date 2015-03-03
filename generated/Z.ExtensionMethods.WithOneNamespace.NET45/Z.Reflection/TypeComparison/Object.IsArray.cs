namespace Z.ExtensionMethods
{

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that query if '@this' is array.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if array, false if not.</returns>
    public static bool IsArray<T>(this T @this)
    {
        return @this.GetType().IsArray;
    }
}

}
namespace Z.ExtensionMethods
{

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that query if '@this' is class.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if class, false if not.</returns>
    public static bool IsClass<T>(this T @this)
    {
        return @this.GetType().IsClass;
    }
}

}
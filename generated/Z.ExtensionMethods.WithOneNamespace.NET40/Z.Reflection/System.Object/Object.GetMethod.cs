namespace Z.ExtensionMethods
{

using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that searches for the public method with the specified name.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="name">The string containing the name of the public method to get.</param>
    /// <returns>
    ///     An object that represents the public method with the specified name, if found; otherwise, null.
    /// </returns>
    public static MethodInfo GetMethod<T>(this T @this, string name)
    {
        return @this.GetType().GetMethod(name);
    }

    /// <summary>
    ///     A T extension method that searches for the specified method whose parameters match the specified argument
    ///     types and modifiers, using the specified binding constraints.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="name">The string containing the name of the public method to get.</param>
    /// <param name="bindingAttr">A bitmask comprised of one or more BindingFlags that specify how the search is conducted.</param>
    /// <returns>
    ///     An object that represents the public method with the specified name, if found; otherwise, null.
    /// </returns>
    public static MethodInfo GetMethod<T>(this T @this, string name, BindingFlags bindingAttr)
    {
        return @this.GetType().GetMethod(name, bindingAttr);
    }
}

}
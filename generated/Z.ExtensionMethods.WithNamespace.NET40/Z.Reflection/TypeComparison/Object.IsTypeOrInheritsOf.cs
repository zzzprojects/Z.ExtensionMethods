using Z.CoreExtensions;
using Z.DataExtensions;

namespace Z.ReflectionExtensions
{

using System;

public static partial class Extensions
{
    /// <summary>
    ///     A T extension method that query if '@this' is type or inherits of.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="type">The type.</param>
    /// <returns>true if type or inherits of, false if not.</returns>
    public static bool IsTypeOrInheritsOf<T>(this T @this, Type type)
    {
        Type objectType = @this.GetType();

        while (true)
        {
            if (objectType.Equals(type))
            {
                return true;
            }

            if ((objectType == objectType.BaseType) || (objectType.BaseType == null))
            {
                return false;
            }

            objectType = objectType.BaseType;
        }
    }
}

}
namespace Z.ExtensionMethods
{

using System.IO;
using System.Linq;

public static partial class Extensions
{
    /// <summary>
    ///     A DirectoryInfo extension method that gets a size.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The size.</returns>
    public static long GetSize(this DirectoryInfo @this)
    {
        return @this.GetFiles("*.*", SearchOption.AllDirectories).Sum(x => x.Length);
    }
}

}
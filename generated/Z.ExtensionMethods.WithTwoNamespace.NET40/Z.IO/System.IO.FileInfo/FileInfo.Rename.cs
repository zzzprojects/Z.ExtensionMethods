using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     A FileInfo extension method that renames.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="newName">Name of the new.</param>
    /// ###
    /// <returns>.</returns>
    public static void Rename(this FileInfo @this, string newName)
    {
        string filePath = Path.Combine(@this.Directory.FullName, newName);
        @this.MoveTo(filePath);
    }
}

}
using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.IO;

public static partial class Extensions
{
    /// <summary>
    ///     A FileInfo extension method that rename file without extension.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="newName">Name of the new.</param>
    /// ###
    /// <returns>.</returns>
    public static void RenameFileWithoutExtension(this FileInfo @this, string newName)
    {
        string fileName = string.Concat(newName, @this.Extension);
        string filePath = Path.Combine(@this.Directory.FullName, fileName);
        @this.MoveTo(filePath);
    }
}

}
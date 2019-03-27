// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
#if !NETSTANDARD
using System.Web;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     A HttpResponse extension method that sends an attachment.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="fullPathToFile">The full path to file.</param>
    /// <param name="outputFileName">Filename of the output file.</param>
    public static void SendAttachment(this HttpResponse @this, string fullPathToFile, string outputFileName)
    {
        @this.Clear();
        @this.AddHeader("content-disposition", "attachment; filename=" + outputFileName);
        @this.WriteFile(fullPathToFile);
        @this.ContentType = "";
        @this.End();
    }
#endif
}
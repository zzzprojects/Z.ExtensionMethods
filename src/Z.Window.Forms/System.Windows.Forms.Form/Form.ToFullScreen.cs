// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
#if !NETSTANDARD
using System.Windows.Forms;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     A Form extension method that set the window form to full screen mode to the specified screen.
    /// </summary>
    /// <param name="form">The form to act on.</param>
    /// <param name="screen">(Optional) the screen to act on.</param>
    public static void ToFullScreen(this Form form, int screen = 0)
    {
        form.WindowState = FormWindowState.Maximized;
        form.StartPosition = FormStartPosition.Manual;
        form.Bounds = Screen.AllScreens[screen].Bounds;
    }
#endif
}

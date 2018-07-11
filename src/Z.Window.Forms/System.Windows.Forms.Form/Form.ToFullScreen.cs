// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

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

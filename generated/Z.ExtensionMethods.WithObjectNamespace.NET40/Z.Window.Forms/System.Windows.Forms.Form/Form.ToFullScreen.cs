using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System.Windows.Forms;

public static partial class Extensions
{
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
}

}
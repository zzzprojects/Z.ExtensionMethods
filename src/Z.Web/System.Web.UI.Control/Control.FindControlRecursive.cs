// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
#if !NETSTANDARD
using System.Web.UI;
#endif

public static partial class Extensions
{
#if !NETSTANDARD
    /// <summary>
    ///     Searches recursively in the container and child container for a server control with the specified id
    ///     parameter.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="id">The identifier for the control to be found.</param>
    /// <returns>The specified control, or a null reference if the specified control does not exist.</returns>
    public static Control FindControlRecursive(this Control @this, string id)
    {
        Control rControl = @this.FindControl(id);

        if (rControl == null)
        {
            foreach (Control control in @this.Controls)
            {
                rControl = control.FindControl(id);
                if (rControl != null)
                {
                    break;
                }
            }
        }

        return rControl;
    }

    /// <summary>
    ///     Searches recursively in the container and child container for a server control with the specified id
    ///     parameter.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="id">The identifier for the control to be found.</param>
    /// <returns>The specified control, or a null reference if the specified control does not exist.</returns>
    public static T FindControlRecursive<T>(this Control @this, string id) where T : class
    {
        Control rControl = @this.FindControl(id);

        if (rControl == null)
        {
            foreach (Control control in @this.Controls)
            {
                rControl = control.FindControl(id);
                if (rControl != null)
                {
                    break;
                }
            }
        }

        return rControl as T;
    }
#endif
}
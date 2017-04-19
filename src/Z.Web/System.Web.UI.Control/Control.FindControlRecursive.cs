// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System.Web.UI;

public static partial class Extensions
{
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
}
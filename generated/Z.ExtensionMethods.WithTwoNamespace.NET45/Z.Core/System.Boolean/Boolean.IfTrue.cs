using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
    {
        /// <summary>
        ///     A bool extension method that execute an Action if the value is true.
        /// </summary>
        /// <param name="this">The @this to act on.</param>
        /// <param name="action">The action to execute.</param>
        public static void IfTrue(this bool @this, Action action)
        {
            if (@this)
            {
                action();
            }
        }
    }


}
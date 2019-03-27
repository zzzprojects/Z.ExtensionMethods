// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright © ZZZ Projects Inc. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     An EventHandler extension method that raises the event event.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="sender">Source of the event.</param>
    public static void RaiseEvent(this EventHandler @this, object sender)
    {
        if (@this != null)
        {
            @this(sender, null);
        }
    }

    /// <summary>
    ///     An EventHandler extension method that raises.
    /// </summary>
    /// <param name="handler">The handler to act on.</param>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information.</param>
    public static void Raise(this EventHandler handler, object sender, EventArgs e)
    {
        if (handler != null)
            handler(sender, e);
    }

    /// <summary>
    ///     An EventHandler&lt;TEventArgs&gt; extension method that raises the event event.
    /// </summary>
    /// <typeparam name="TEventArgs">Type of the event arguments.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="sender">Source of the event.</param>
    public static void RaiseEvent<TEventArgs>(this EventHandler<TEventArgs> @this, object sender) where TEventArgs : EventArgs
    {
        if (@this != null)
        {
            @this(sender, Activator.CreateInstance<TEventArgs>());
        }
    }

    /// <summary>
    ///     An EventHandler&lt;TEventArgs&gt; extension method that raises the event event.
    /// </summary>
    /// <typeparam name="TEventArgs">Type of the event arguments.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="sender">Source of the event.</param>
    /// <param name="e">Event information to send to registered event handlers.</param>
    public static void RaiseEvent<TEventArgs>(this EventHandler<TEventArgs> @this, object sender, TEventArgs e) where TEventArgs : EventArgs
    {
        if (@this != null)
        {
            @this(sender, e);
        }
    }
}
// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System.Reflection;

public static partial class Extensions
{
    /// <summary>An object extension method that gets the properties.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>An array of property information.</returns>
    public static PropertyInfo[] GetProperties(this object @this)
    {
        return @this.GetType().GetProperties();
    }

    /// <summary>An object extension method that gets the properties.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="bindingAttr">The binding attribute.</param>
    /// <returns>An array of property information.</returns>
    public static PropertyInfo[] GetProperties(this object @this, BindingFlags bindingAttr)
    {
        return @this.GetType().GetProperties(bindingAttr);
    }
}
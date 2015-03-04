// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.Globalization;
using System.Reflection;

public static partial class Extensions
{
    /// <summary>
    ///     Creates an instance of the specified type using the constructor that best matches the specified parameters.
    /// </summary>
    /// <param name="type">The type of object to create.</param>
    /// <param name="bindingAttr">
    ///     A combination of zero or more bit flags that affect the search for the  constructor. If
    ///     is zero, a case-sensitive search for public constructors is conducted.
    /// </param>
    /// <param name="binder">
    ///     An object that uses  and  to seek and identify the  constructor. If  is null, the default
    ///     binder is used.
    /// </param>
    /// <param name="args">
    ///     An array of arguments that match in number, order, and type the parameters of the constructor
    ///     to invoke. If  is an empty array or null, the constructor that takes no parameters (the default constructor) is
    ///     invoked.
    /// </param>
    /// <param name="culture">
    ///     Culture-specific information that governs the coercion of  to the formal types declared for
    ///     the  constructor. If  is null, the  for the current thread is used.
    /// </param>
    /// <returns>A reference to the newly created object.</returns>
    public static Object CreateInstance(this Type type, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture)
    {
        return Activator.CreateInstance(type, bindingAttr, binder, args, culture);
    }

    /// <summary>
    ///     Creates an instance of the specified type using the constructor that best matches the specified parameters.
    /// </summary>
    /// <param name="type">The type of object to create.</param>
    /// <param name="bindingAttr">
    ///     A combination of zero or more bit flags that affect the search for the  constructor. If
    ///     is zero, a case-sensitive search for public constructors is conducted.
    /// </param>
    /// <param name="binder">
    ///     An object that uses  and  to seek and identify the  constructor. If  is null, the default
    ///     binder is used.
    /// </param>
    /// <param name="args">
    ///     An array of arguments that match in number, order, and type the parameters of the constructor
    ///     to invoke. If  is an empty array or null, the constructor that takes no parameters (the default constructor) is
    ///     invoked.
    /// </param>
    /// <param name="culture">
    ///     Culture-specific information that governs the coercion of  to the formal types declared for
    ///     the  constructor. If  is null, the  for the current thread is used.
    /// </param>
    /// <param name="activationAttributes">
    ///     An array of one or more attributes that can participate in activation. This
    ///     is typically an array that contains a single  object. The  specifies the URL that is required to activate a
    ///     remote object.
    /// </param>
    /// <returns>A reference to the newly created object.</returns>
    public static Object CreateInstance(this Type type, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes)
    {
        return Activator.CreateInstance(type, bindingAttr, binder, args, culture, activationAttributes);
    }

    /// <summary>
    ///     Creates an instance of the specified type using the constructor that best matches the specified parameters.
    /// </summary>
    /// <param name="type">The type of object to create.</param>
    /// <param name="args">
    ///     An array of arguments that match in number, order, and type the parameters of the constructor
    ///     to invoke. If  is an empty array or null, the constructor that takes no parameters (the default constructor) is
    ///     invoked.
    /// </param>
    /// <returns>A reference to the newly created object.</returns>
    public static Object CreateInstance(this Type type, Object[] args)
    {
        return Activator.CreateInstance(type, args);
    }

    /// <summary>
    ///     Creates an instance of the specified type using the constructor that best matches the specified parameters.
    /// </summary>
    /// <param name="type">The type of object to create.</param>
    /// <param name="args">
    ///     An array of arguments that match in number, order, and type the parameters of the constructor
    ///     to invoke. If  is an empty array or null, the constructor that takes no parameters (the default constructor) is
    ///     invoked.
    /// </param>
    /// <param name="activationAttributes">
    ///     An array of one or more attributes that can participate in activation. This
    ///     is typically an array that contains a single  object. The  specifies the URL that is required to activate a
    ///     remote object.
    /// </param>
    /// <returns>A reference to the newly created object.</returns>
    public static Object CreateInstance(this Type type, Object[] args, Object[] activationAttributes)
    {
        return Activator.CreateInstance(type, args, activationAttributes);
    }

    /// <summary>
    ///     Creates an instance of the specified type using that type&#39;s default constructor.
    /// </summary>
    /// <param name="type">The type of object to create.</param>
    /// <returns>A reference to the newly created object.</returns>
    public static Object CreateInstance(this Type type)
    {
        return Activator.CreateInstance(type);
    }

    /// <summary>
    ///     Creates an instance of the specified type using that type&#39;s default constructor.
    /// </summary>
    /// <param name="type">The type of object to create.</param>
    /// <param name="nonPublic">
    ///     true if a public or nonpublic default constructor can match; false if only a public
    ///     default constructor can match.
    /// </param>
    /// <returns>A reference to the newly created object.</returns>
    public static Object CreateInstance(this Type type, Boolean nonPublic)
    {
        return Activator.CreateInstance(type, nonPublic);
    }
}
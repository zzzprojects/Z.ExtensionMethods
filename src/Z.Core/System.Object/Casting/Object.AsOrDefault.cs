// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that converts the @this to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <returns>A T.</returns>
    public static T AsOrDefault<T>(this object @this)
    {
        try
        {
            return (T) @this;
        }
        catch (Exception)
        {
            return default(T);
        }
    }

    /// <summary>
    ///     An object extension method that converts the @this to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>A T.</returns>
    public static T AsOrDefault<T>(this object @this, T defaultValue)
    {
        try
        {
            return (T) @this;
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts the @this to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>A T.</returns>
    /// <example>
    ///     <code>
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///       using Z.ExtensionMethods.Object;
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_Object_AsOrDefault
    ///           {
    ///               [TestMethod]
    ///               public void AsOrDefault()
    ///               {
    ///                   // Type
    ///                   object intValue = 1;
    ///                   object invalidValue = &quot;Fizz&quot;;
    /// 
    ///                   // Exemples
    ///                   var result1 = intValue.AsOrDefault&lt;int&gt;(); // return 1;
    ///                   var result2 = invalidValue.AsOrDefault&lt;int&gt;(); // return 0;
    ///                   int result3 = invalidValue.AsOrDefault(3); // return 3;
    ///                   int result4 = invalidValue.AsOrDefault(() =&gt; 4); // return 4;
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(1, result1);
    ///                   Assert.AreEqual(0, result2);
    ///                   Assert.AreEqual(3, result3);
    ///                   Assert.AreEqual(4, result4);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// <example>
    ///     <code>
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///       using Z.ExtensionMethods.Object;
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_Object_AsOrDefault
    ///           {
    ///               [TestMethod]
    ///               public void AsOrDefault()
    ///               {
    ///                   // Type
    ///                   object intValue = 1;
    ///                   object invalidValue = &quot;Fizz&quot;;
    /// 
    ///                   // Exemples
    ///                   var result1 = intValue.AsOrDefault&lt;int&gt;(); // return 1;
    ///                   var result2 = invalidValue.AsOrDefault&lt;int&gt;(); // return 0;
    ///                   int result3 = invalidValue.AsOrDefault(3); // return 3;
    ///                   int result4 = invalidValue.AsOrDefault(() =&gt; 4); // return 4;
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(1, result1);
    ///                   Assert.AreEqual(0, result2);
    ///                   Assert.AreEqual(3, result3);
    ///                   Assert.AreEqual(4, result4);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods.Object;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Object_AsOrDefault
    ///               {
    ///                   [TestMethod]
    ///                   public void AsOrDefault()
    ///                   {
    ///                       // Type
    ///                       object intValue = 1;
    ///                       object invalidValue = &quot;Fizz&quot;;
    ///           
    ///                       // Exemples
    ///                       var result1 = intValue.AsOrDefault&lt;int&gt;(); // return 1;
    ///                       var result2 = invalidValue.AsOrDefault&lt;int&gt;(); // return 0;
    ///                       int result3 = invalidValue.AsOrDefault(3); // return 3;
    ///                       int result4 = invalidValue.AsOrDefault(() =&gt; 4); // return 4;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(1, result1);
    ///                       Assert.AreEqual(0, result2);
    ///                       Assert.AreEqual(3, result3);
    ///                       Assert.AreEqual(4, result4);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static T AsOrDefault<T>(this object @this, Func<T> defaultValueFactory)
    {
        try
        {
            return (T) @this;
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    ///     An object extension method that converts the @this to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>A T.</returns>
    /// <example>
    ///     <code>
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///       using Z.ExtensionMethods.Object;
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_Object_AsOrDefault
    ///           {
    ///               [TestMethod]
    ///               public void AsOrDefault()
    ///               {
    ///                   // Type
    ///                   object intValue = 1;
    ///                   object invalidValue = &quot;Fizz&quot;;
    /// 
    ///                   // Exemples
    ///                   var result1 = intValue.AsOrDefault&lt;int&gt;(); // return 1;
    ///                   var result2 = invalidValue.AsOrDefault&lt;int&gt;(); // return 0;
    ///                   int result3 = invalidValue.AsOrDefault(3); // return 3;
    ///                   int result4 = invalidValue.AsOrDefault(() =&gt; 4); // return 4;
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(1, result1);
    ///                   Assert.AreEqual(0, result2);
    ///                   Assert.AreEqual(3, result3);
    ///                   Assert.AreEqual(4, result4);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// <example>
    ///     <code>
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///       using Z.ExtensionMethods.Object;
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_Object_AsOrDefault
    ///           {
    ///               [TestMethod]
    ///               public void AsOrDefault()
    ///               {
    ///                   // Type
    ///                   object intValue = 1;
    ///                   object invalidValue = &quot;Fizz&quot;;
    /// 
    ///                   // Exemples
    ///                   var result1 = intValue.AsOrDefault&lt;int&gt;(); // return 1;
    ///                   var result2 = invalidValue.AsOrDefault&lt;int&gt;(); // return 0;
    ///                   int result3 = invalidValue.AsOrDefault(3); // return 3;
    ///                   int result4 = invalidValue.AsOrDefault(() =&gt; 4); // return 4;
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(1, result1);
    ///                   Assert.AreEqual(0, result2);
    ///                   Assert.AreEqual(3, result3);
    ///                   Assert.AreEqual(4, result4);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// <example>
    ///     <code>
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods.Object;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Object_AsOrDefault
    ///               {
    ///                   [TestMethod]
    ///                   public void AsOrDefault()
    ///                   {
    ///                       // Type
    ///                       object intValue = 1;
    ///                       object invalidValue = &quot;Fizz&quot;;
    ///           
    ///                       // Exemples
    ///                       var result1 = intValue.AsOrDefault&lt;int&gt;(); // return 1;
    ///                       var result2 = invalidValue.AsOrDefault&lt;int&gt;(); // return 0;
    ///                       int result3 = invalidValue.AsOrDefault(3); // return 3;
    ///                       int result4 = invalidValue.AsOrDefault(() =&gt; 4); // return 4;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(1, result1);
    ///                       Assert.AreEqual(0, result2);
    ///                       Assert.AreEqual(3, result3);
    ///                       Assert.AreEqual(4, result4);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static T AsOrDefault<T>(this object @this, Func<object, T> defaultValueFactory)
    {
        try
        {
            return (T) @this;
        }
        catch (Exception)
        {
            return defaultValueFactory(@this);
        }
    }
}
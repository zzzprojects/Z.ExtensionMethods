// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using System.ComponentModel;

public static partial class Extensions
{
    /// <summary>
    ///     A System.Object extension method that converts this object to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">this.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a T.</returns>
    /// <example>
    ///     <code>
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///       using Z.ExtensionMethods.Object;
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_Object_ToOrDefault
    ///           {
    ///               [TestMethod]
    ///               public void ToOrDefault()
    ///               {
    ///                   // Type
    ///                   object intValue = &quot;1&quot;;
    ///                   object invalidValue = &quot;Fizz&quot;;
    /// 
    ///                   // Exemples
    ///                   var result1 = intValue.ToOrDefault&lt;int&gt;(); // return 1;
    ///                   var result2 = invalidValue.ToOrDefault&lt;int&gt;(); // return 0;
    ///                   int result3 = invalidValue.ToOrDefault(3); // return 3;
    ///                   int result4 = invalidValue.ToOrDefault(() =&gt; 4); // return 4;
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
    ///           public class System_Object_ToOrDefault
    ///           {
    ///               [TestMethod]
    ///               public void ToOrDefault()
    ///               {
    ///                   // Type
    ///                   object intValue = &quot;1&quot;;
    ///                   object invalidValue = &quot;Fizz&quot;;
    /// 
    ///                   // Exemples
    ///                   var result1 = intValue.ToOrDefault&lt;int&gt;(); // return 1;
    ///                   var result2 = invalidValue.ToOrDefault&lt;int&gt;(); // return 0;
    ///                   int result3 = invalidValue.ToOrDefault(3); // return 3;
    ///                   int result4 = invalidValue.ToOrDefault(() =&gt; 4); // return 4;
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
    ///               public class System_Object_ToOrDefault
    ///               {
    ///                   [TestMethod]
    ///                   public void ToOrDefault()
    ///                   {
    ///                       // Type
    ///                       object intValue = &quot;1&quot;;
    ///                       object invalidValue = &quot;Fizz&quot;;
    ///           
    ///                       // Exemples
    ///                       var result1 = intValue.ToOrDefault&lt;int&gt;(); // return 1;
    ///                       var result2 = invalidValue.ToOrDefault&lt;int&gt;(); // return 0;
    ///                       int result3 = invalidValue.ToOrDefault(3); // return 3;
    ///                       int result4 = invalidValue.ToOrDefault(() =&gt; 4); // return 4;
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
    public static T ToOrDefault<T>(this Object @this, Func<object, T> defaultValueFactory)
    {
        try
        {
            if (@this != null)
            {
                Type targetType = typeof (T);

                if (@this.GetType() == targetType)
                {
                    return (T) @this;
                }

                TypeConverter converter = TypeDescriptor.GetConverter(@this);
                if (converter != null)
                {
                    if (converter.CanConvertTo(targetType))
                    {
                        return (T) converter.ConvertTo(@this, targetType);
                    }
                }

                converter = TypeDescriptor.GetConverter(targetType);
                if (converter != null)
                {
                    if (converter.CanConvertFrom(@this.GetType()))
                    {
                        return (T) converter.ConvertFrom(@this);
                    }
                }

                if (@this == DBNull.Value)
                {
                    return (T) (object) null;
                }
            }

            return (T) @this;
        }
        catch (Exception)
        {
            return defaultValueFactory(@this);
        }
    }

    /// <summary>
    ///     A System.Object extension method that converts this object to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">this.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to a T.</returns>
    /// <example>
    ///     <code>
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///       using Z.ExtensionMethods.Object;
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_Object_ToOrDefault
    ///           {
    ///               [TestMethod]
    ///               public void ToOrDefault()
    ///               {
    ///                   // Type
    ///                   object intValue = &quot;1&quot;;
    ///                   object invalidValue = &quot;Fizz&quot;;
    /// 
    ///                   // Exemples
    ///                   var result1 = intValue.ToOrDefault&lt;int&gt;(); // return 1;
    ///                   var result2 = invalidValue.ToOrDefault&lt;int&gt;(); // return 0;
    ///                   int result3 = invalidValue.ToOrDefault(3); // return 3;
    ///                   int result4 = invalidValue.ToOrDefault(() =&gt; 4); // return 4;
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
    ///           public class System_Object_ToOrDefault
    ///           {
    ///               [TestMethod]
    ///               public void ToOrDefault()
    ///               {
    ///                   // Type
    ///                   object intValue = &quot;1&quot;;
    ///                   object invalidValue = &quot;Fizz&quot;;
    /// 
    ///                   // Exemples
    ///                   var result1 = intValue.ToOrDefault&lt;int&gt;(); // return 1;
    ///                   var result2 = invalidValue.ToOrDefault&lt;int&gt;(); // return 0;
    ///                   int result3 = invalidValue.ToOrDefault(3); // return 3;
    ///                   int result4 = invalidValue.ToOrDefault(() =&gt; 4); // return 4;
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
    ///               public class System_Object_ToOrDefault
    ///               {
    ///                   [TestMethod]
    ///                   public void ToOrDefault()
    ///                   {
    ///                       // Type
    ///                       object intValue = &quot;1&quot;;
    ///                       object invalidValue = &quot;Fizz&quot;;
    ///           
    ///                       // Exemples
    ///                       var result1 = intValue.ToOrDefault&lt;int&gt;(); // return 1;
    ///                       var result2 = invalidValue.ToOrDefault&lt;int&gt;(); // return 0;
    ///                       int result3 = invalidValue.ToOrDefault(3); // return 3;
    ///                       int result4 = invalidValue.ToOrDefault(() =&gt; 4); // return 4;
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
    public static T ToOrDefault<T>(this Object @this, Func<T> defaultValueFactory)
    {
        return @this.ToOrDefault(x => defaultValueFactory());
    }

    /// <summary>
    ///     A System.Object extension method that converts this object to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">this.</param>
    /// <returns>The given data converted to a T.</returns>
    public static T ToOrDefault<T>(this Object @this)
    {
        return @this.ToOrDefault(x => default(T));
    }

    /// <summary>
    ///     A System.Object extension method that converts this object to an or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">this.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to a T.</returns>
    public static T ToOrDefault<T>(this Object @this, T defaultValue)
    {
        return @this.ToOrDefault(x => defaultValue);
    }
}
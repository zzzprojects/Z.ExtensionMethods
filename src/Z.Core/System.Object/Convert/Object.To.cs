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
    ///     A System.Object extension method that toes the given this.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="this">this.</param>
    /// <returns>A T.</returns>
    /// <example>
    ///     <code>
    ///       using System;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    /// 
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_Object_To
    ///           {
    ///               [TestMethod]
    ///               public void To()
    ///               {
    ///                   string nullValue = null;
    ///                   string value = &quot;1&quot;;
    ///                   object dbNullValue = DBNull.Value;
    /// 
    ///                   // Exemples
    ///                   var result1 = value.To&lt;int&gt;(); // return 1;
    ///                   var result2 = value.To&lt;int?&gt;(); // return 1;
    ///                   var result3 = nullValue.To&lt;int?&gt;(); // return null;
    ///                   var result4 = dbNullValue.To&lt;int?&gt;(); // return null;
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(1, result1);
    ///                   Assert.AreEqual(1, result2.Value);
    ///                   Assert.IsFalse(result3.HasValue);
    ///                   Assert.IsFalse(result4.HasValue);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// <example>
    ///     <code>
    ///       using System;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///       using Z.ExtensionMethods.Object;
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_Object_To
    ///           {
    ///               [TestMethod]
    ///               public void To()
    ///               {
    ///                   string nullValue = null;
    ///                   string value = &quot;1&quot;;
    ///                   object dbNullValue = DBNull.Value;
    /// 
    ///                   // Exemples
    ///                   var result1 = value.To&lt;int&gt;(); // return 1;
    ///                   var result2 = value.To&lt;int?&gt;(); // return 1;
    ///                   var result3 = nullValue.To&lt;int?&gt;(); // return null;
    ///                   var result4 = dbNullValue.To&lt;int?&gt;(); // return null;
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(1, result1);
    ///                   Assert.AreEqual(1, result2.Value);
    ///                   Assert.IsFalse(result3.HasValue);
    ///                   Assert.IsFalse(result4.HasValue);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    public static T To<T>(this Object @this)
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

    /// <summary>
    ///     A System.Object extension method that toes the given this.
    /// </summary>
    /// <param name="this">this.</param>
    /// <param name="type">The type.</param>
    /// <returns>An object.</returns>
    /// <example>
    ///     <code>
    ///       using System;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    /// 
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_Object_To
    ///           {
    ///               [TestMethod]
    ///               public void To()
    ///               {
    ///                   string nullValue = null;
    ///                   string value = &quot;1&quot;;
    ///                   object dbNullValue = DBNull.Value;
    /// 
    ///                   // Exemples
    ///                   var result1 = value.To&lt;int&gt;(); // return 1;
    ///                   var result2 = value.To&lt;int?&gt;(); // return 1;
    ///                   var result3 = nullValue.To&lt;int?&gt;(); // return null;
    ///                   var result4 = dbNullValue.To&lt;int?&gt;(); // return null;
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(1, result1);
    ///                   Assert.AreEqual(1, result2.Value);
    ///                   Assert.IsFalse(result3.HasValue);
    ///                   Assert.IsFalse(result4.HasValue);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// <example>
    ///     <code>
    ///       using System;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///       using Z.ExtensionMethods.Object;
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_Object_To
    ///           {
    ///               [TestMethod]
    ///               public void To()
    ///               {
    ///                   string nullValue = null;
    ///                   string value = &quot;1&quot;;
    ///                   object dbNullValue = DBNull.Value;
    /// 
    ///                   // Exemples
    ///                   var result1 = value.To&lt;int&gt;(); // return 1;
    ///                   var result2 = value.To&lt;int?&gt;(); // return 1;
    ///                   var result3 = nullValue.To&lt;int?&gt;(); // return null;
    ///                   var result4 = dbNullValue.To&lt;int?&gt;(); // return null;
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(1, result1);
    ///                   Assert.AreEqual(1, result2.Value);
    ///                   Assert.IsFalse(result3.HasValue);
    ///                   Assert.IsFalse(result4.HasValue);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// ###
    /// <typeparam name="T">Generic type parameter.</typeparam>
    public static object To(this Object @this, Type type)
    {
        if (@this != null)
        {
            Type targetType = type;

            if (@this.GetType() == targetType)
            {
                return @this;
            }

            TypeConverter converter = TypeDescriptor.GetConverter(@this);
            if (converter != null)
            {
                if (converter.CanConvertTo(targetType))
                {
                    return converter.ConvertTo(@this, targetType);
                }
            }

            converter = TypeDescriptor.GetConverter(targetType);
            if (converter != null)
            {
                if (converter.CanConvertFrom(@this.GetType()))
                {
                    return converter.ConvertFrom(@this);
                }
            }

            if (@this == DBNull.Value)
            {
                return null;
            }
        }

        return @this;
    }
}
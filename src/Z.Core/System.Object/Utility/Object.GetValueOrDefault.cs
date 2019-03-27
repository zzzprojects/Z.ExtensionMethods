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
    ///     A T extension method that gets value or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="func">The function.</param>
    /// <returns>The value or default.</returns>
    public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return default(TResult);
        }
    }

    /// <summary>
    ///     A T extension method that gets value or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="func">The function.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The value or default.</returns>
    public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func, TResult defaultValue)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     A T extension method that gets value or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="func">The function.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The value or default.</returns>
    /// <example>
    ///     <code>
    ///       using System.Xml;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    /// 
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_Object_GetValueOrDefault
    ///           {
    ///               [TestMethod]
    ///               public void GetValueOrDefault()
    ///               {
    ///                   // Type
    ///                   var @this = new XmlDocument();
    /// 
    ///                   // Exemples
    ///                   string result1 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;;
    ///                   string result2 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, () =&gt; &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(&quot;FizzBuzz&quot;, result1);
    ///                   Assert.AreEqual(&quot;FizzBuzz&quot;, result2);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// <example>
    ///     <code>
    ///       using System.Xml;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///       using Z.ExtensionMethods.Object;
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_Object_GetValueOrDefault
    ///           {
    ///               [TestMethod]
    ///               public void GetValueOrDefault()
    ///               {
    ///                   // Type
    ///                   var @this = new XmlDocument();
    /// 
    ///                   // Exemples
    ///                   string result1 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;;
    ///                   string result2 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, () =&gt; &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(&quot;FizzBuzz&quot;, result1);
    ///                   Assert.AreEqual(&quot;FizzBuzz&quot;, result2);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// <example>
    ///     <code>
    ///           using System.Xml;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods.Object;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Object_GetValueOrDefault
    ///               {
    ///                   [TestMethod]
    ///                   public void GetValueOrDefault()
    ///                   {
    ///                       // Type
    ///                       var @this = new XmlDocument();
    ///           
    ///                       // Exemples
    ///                       string result1 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;;
    ///                       string result2 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, () =&gt; &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;FizzBuzz&quot;, result1);
    ///                       Assert.AreEqual(&quot;FizzBuzz&quot;, result2);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func, Func<TResult> defaultValueFactory)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    ///     A T extension method that gets value or default.
    /// </summary>
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <typeparam name="TResult">Type of the result.</typeparam>
    /// <param name="this">The @this to act on.</param>
    /// <param name="func">The function.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The value or default.</returns>
    /// <example>
    ///     <code>
    ///       using System.Xml;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    /// 
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_Object_GetValueOrDefault
    ///           {
    ///               [TestMethod]
    ///               public void GetValueOrDefault()
    ///               {
    ///                   // Type
    ///                   var @this = new XmlDocument();
    /// 
    ///                   // Exemples
    ///                   string result1 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;;
    ///                   string result2 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, () =&gt; &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(&quot;FizzBuzz&quot;, result1);
    ///                   Assert.AreEqual(&quot;FizzBuzz&quot;, result2);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// <example>
    ///     <code>
    ///       using System.Xml;
    ///       using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///       using Z.ExtensionMethods.Object;
    /// 
    ///       namespace ExtensionMethods.Examples
    ///       {
    ///           [TestClass]
    ///           public class System_Object_GetValueOrDefault
    ///           {
    ///               [TestMethod]
    ///               public void GetValueOrDefault()
    ///               {
    ///                   // Type
    ///                   var @this = new XmlDocument();
    /// 
    ///                   // Exemples
    ///                   string result1 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;;
    ///                   string result2 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, () =&gt; &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;
    /// 
    ///                   // Unit Test
    ///                   Assert.AreEqual(&quot;FizzBuzz&quot;, result1);
    ///                   Assert.AreEqual(&quot;FizzBuzz&quot;, result2);
    ///               }
    ///           }
    ///       }
    /// </code>
    /// </example>
    /// <example>
    ///     <code>
    ///           using System.Xml;
    ///           using Microsoft.VisualStudio.TestTools.UnitTesting;
    ///           using Z.ExtensionMethods.Object;
    ///           
    ///           namespace ExtensionMethods.Examples
    ///           {
    ///               [TestClass]
    ///               public class System_Object_GetValueOrDefault
    ///               {
    ///                   [TestMethod]
    ///                   public void GetValueOrDefault()
    ///                   {
    ///                       // Type
    ///                       var @this = new XmlDocument();
    ///           
    ///                       // Exemples
    ///                       string result1 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;;
    ///                       string result2 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, () =&gt; &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;
    ///           
    ///                       // Unit Test
    ///                       Assert.AreEqual(&quot;FizzBuzz&quot;, result1);
    ///                       Assert.AreEqual(&quot;FizzBuzz&quot;, result2);
    ///                   }
    ///               }
    ///           }
    ///     </code>
    /// </example>
    public static TResult GetValueOrDefault<T, TResult>(this T @this, Func<T, TResult> func, Func<T, TResult> defaultValueFactory)
    {
        try
        {
            return func(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory(@this);
        }
    }
}
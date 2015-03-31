
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_448

	''' <summary>
	'''     A T extension method that gets value or default.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <typeparam name="TResult">Type of the result.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="func">The function.</param>
	''' <returns>The value or default.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetValueOrDefault(Of T, TResult)(this As T, func As Func(Of T, TResult)) As TResult
		Try
			Return func(this)
		Catch generatedExceptionName As Exception
			Return Nothing
		End Try
	End Function

	''' <summary>
	'''     A T extension method that gets value or default.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <typeparam name="TResult">Type of the result.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="func">The function.</param>
	''' <param name="defaultValue">The default value.</param>
	''' <returns>The value or default.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetValueOrDefault(Of T, TResult)(this As T, func As Func(Of T, TResult), defaultValue As TResult) As TResult
		Try
			Return func(this)
		Catch generatedExceptionName As Exception
			Return defaultValue
		End Try
	End Function

	''' <summary>
	'''     A T extension method that gets value or default.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <typeparam name="TResult">Type of the result.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="func">The function.</param>
	''' <param name="defaultValueFactory">The default value factory.</param>
	''' <returns>The value or default.</returns>
	''' <example>
	'''     <code>
	'''       using System.Xml;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	''' 
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_Object_GetValueOrDefault
	'''           {
	'''               [TestMethod]
	'''               public void GetValueOrDefault()
	'''               {
	'''                   // Type
	'''                   var @this = new XmlDocument();
	''' 
	'''                   // Exemples
	'''                   string result1 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;;
	'''                   string result2 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, () =&gt; &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(&quot;FizzBuzz&quot;, result1);
	'''                   Assert.AreEqual(&quot;FizzBuzz&quot;, result2);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' <example>
	'''     <code>
	'''       using System.Xml;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	'''       using Z.ExtensionMethods.Object;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_Object_GetValueOrDefault
	'''           {
	'''               [TestMethod]
	'''               public void GetValueOrDefault()
	'''               {
	'''                   // Type
	'''                   var @this = new XmlDocument();
	''' 
	'''                   // Exemples
	'''                   string result1 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;;
	'''                   string result2 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, () =&gt; &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(&quot;FizzBuzz&quot;, result1);
	'''                   Assert.AreEqual(&quot;FizzBuzz&quot;, result2);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' <example>
	'''     <code>
	'''           using System.Xml;
	'''           using Microsoft.VisualStudio.TestTools.UnitTesting;
	'''           using Z.ExtensionMethods.Object;
	'''           
	'''           namespace ExtensionMethods.Examples
	'''           {
	'''               [TestClass]
	'''               public class System_Object_GetValueOrDefault
	'''               {
	'''                   [TestMethod]
	'''                   public void GetValueOrDefault()
	'''                   {
	'''                       // Type
	'''                       var @this = new XmlDocument();
	'''           
	'''                       // Exemples
	'''                       string result1 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;;
	'''                       string result2 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, () =&gt; &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;
	'''           
	'''                       // Unit Test
	'''                       Assert.AreEqual(&quot;FizzBuzz&quot;, result1);
	'''                       Assert.AreEqual(&quot;FizzBuzz&quot;, result2);
	'''                   }
	'''               }
	'''           }
	'''     </code>
	''' </example>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetValueOrDefault(Of T, TResult)(this As T, func As Func(Of T, TResult), defaultValueFactory As Func(Of TResult)) As TResult
		Try
			Return func(this)
		Catch generatedExceptionName As Exception
			Return defaultValueFactory()
		End Try
	End Function

	''' <summary>
	'''     A T extension method that gets value or default.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <typeparam name="TResult">Type of the result.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="func">The function.</param>
	''' <param name="defaultValueFactory">The default value factory.</param>
	''' <returns>The value or default.</returns>
	''' <example>
	'''     <code>
	'''       using System.Xml;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	''' 
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_Object_GetValueOrDefault
	'''           {
	'''               [TestMethod]
	'''               public void GetValueOrDefault()
	'''               {
	'''                   // Type
	'''                   var @this = new XmlDocument();
	''' 
	'''                   // Exemples
	'''                   string result1 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;;
	'''                   string result2 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, () =&gt; &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(&quot;FizzBuzz&quot;, result1);
	'''                   Assert.AreEqual(&quot;FizzBuzz&quot;, result2);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' <example>
	'''     <code>
	'''       using System.Xml;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	'''       using Z.ExtensionMethods.Object;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_Object_GetValueOrDefault
	'''           {
	'''               [TestMethod]
	'''               public void GetValueOrDefault()
	'''               {
	'''                   // Type
	'''                   var @this = new XmlDocument();
	''' 
	'''                   // Exemples
	'''                   string result1 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;;
	'''                   string result2 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, () =&gt; &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(&quot;FizzBuzz&quot;, result1);
	'''                   Assert.AreEqual(&quot;FizzBuzz&quot;, result2);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' <example>
	'''     <code>
	'''           using System.Xml;
	'''           using Microsoft.VisualStudio.TestTools.UnitTesting;
	'''           using Z.ExtensionMethods.Object;
	'''           
	'''           namespace ExtensionMethods.Examples
	'''           {
	'''               [TestClass]
	'''               public class System_Object_GetValueOrDefault
	'''               {
	'''                   [TestMethod]
	'''                   public void GetValueOrDefault()
	'''                   {
	'''                       // Type
	'''                       var @this = new XmlDocument();
	'''           
	'''                       // Exemples
	'''                       string result1 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;;
	'''                       string result2 = @this.GetValueOrDefault(x =&gt; x.FirstChild.InnerXml, () =&gt; &quot;FizzBuzz&quot;); // return &quot;FizzBuzz&quot;
	'''           
	'''                       // Unit Test
	'''                       Assert.AreEqual(&quot;FizzBuzz&quot;, result1);
	'''                       Assert.AreEqual(&quot;FizzBuzz&quot;, result2);
	'''                   }
	'''               }
	'''           }
	'''     </code>
	''' </example>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetValueOrDefault(Of T, TResult)(this As T, func As Func(Of T, TResult), defaultValueFactory As Func(Of T, TResult)) As TResult
		Try
			Return func(this)
		Catch generatedExceptionName As Exception
			Return defaultValueFactory(this)
		End Try
	End Function
End Module



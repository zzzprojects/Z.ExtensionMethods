
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.ComponentModel

Public Module Extensions_337

	''' <summary>
	'''     A System.Object extension method that converts this object to an or default.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">this.</param>
	''' <param name="defaultValueFactory">The default value factory.</param>
	''' <returns>The given data converted to a T.</returns>
	''' <example>
	'''     <code>
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	'''       using Z.ExtensionMethods.Object;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_Object_ToOrDefault
	'''           {
	'''               [TestMethod]
	'''               public void ToOrDefault()
	'''               {
	'''                   // Type
	'''                   object intValue = &quot;1&quot;;
	'''                   object invalidValue = &quot;Fizz&quot;;
	''' 
	'''                   // Exemples
	'''                   var result1 = intValue.ToOrDefault&lt;int&gt;(); // return 1;
	'''                   var result2 = invalidValue.ToOrDefault&lt;int&gt;(); // return 0;
	'''                   int result3 = invalidValue.ToOrDefault(3); // return 3;
	'''                   int result4 = invalidValue.ToOrDefault(() =&gt; 4); // return 4;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(1, result1);
	'''                   Assert.AreEqual(0, result2);
	'''                   Assert.AreEqual(3, result3);
	'''                   Assert.AreEqual(4, result4);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' <example>
	'''     <code>
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	'''       using Z.ExtensionMethods.Object;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_Object_ToOrDefault
	'''           {
	'''               [TestMethod]
	'''               public void ToOrDefault()
	'''               {
	'''                   // Type
	'''                   object intValue = &quot;1&quot;;
	'''                   object invalidValue = &quot;Fizz&quot;;
	''' 
	'''                   // Exemples
	'''                   var result1 = intValue.ToOrDefault&lt;int&gt;(); // return 1;
	'''                   var result2 = invalidValue.ToOrDefault&lt;int&gt;(); // return 0;
	'''                   int result3 = invalidValue.ToOrDefault(3); // return 3;
	'''                   int result4 = invalidValue.ToOrDefault(() =&gt; 4); // return 4;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(1, result1);
	'''                   Assert.AreEqual(0, result2);
	'''                   Assert.AreEqual(3, result3);
	'''                   Assert.AreEqual(4, result4);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' <example>
	'''     <code>
	'''           using Microsoft.VisualStudio.TestTools.UnitTesting;
	'''           using Z.ExtensionMethods.Object;
	'''           
	'''           namespace ExtensionMethods.Examples
	'''           {
	'''               [TestClass]
	'''               public class System_Object_ToOrDefault
	'''               {
	'''                   [TestMethod]
	'''                   public void ToOrDefault()
	'''                   {
	'''                       // Type
	'''                       object intValue = &quot;1&quot;;
	'''                       object invalidValue = &quot;Fizz&quot;;
	'''           
	'''                       // Exemples
	'''                       var result1 = intValue.ToOrDefault&lt;int&gt;(); // return 1;
	'''                       var result2 = invalidValue.ToOrDefault&lt;int&gt;(); // return 0;
	'''                       int result3 = invalidValue.ToOrDefault(3); // return 3;
	'''                       int result4 = invalidValue.ToOrDefault(() =&gt; 4); // return 4;
	'''           
	'''                       // Unit Test
	'''                       Assert.AreEqual(1, result1);
	'''                       Assert.AreEqual(0, result2);
	'''                       Assert.AreEqual(3, result3);
	'''                       Assert.AreEqual(4, result4);
	'''                   }
	'''               }
	'''           }
	'''     </code>
	''' </example>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToOrDefault(Of T)(this As [Object], defaultValueFactory As Func(Of Object, T)) As T
		Try
			If this IsNot Nothing Then
				Dim targetType As Type = GetType(T)

				If this.[GetType]() = targetType Then
					Return DirectCast(this, T)
				End If

				Dim converter As TypeConverter = TypeDescriptor.GetConverter(this)
				If converter IsNot Nothing Then
					If converter.CanConvertTo(targetType) Then
						Return DirectCast(converter.ConvertTo(this, targetType), T)
					End If
				End If

				converter = TypeDescriptor.GetConverter(targetType)
				If converter IsNot Nothing Then
					If converter.CanConvertFrom(this.[GetType]()) Then
						Return DirectCast(converter.ConvertFrom(this), T)
					End If
				End If

				If this = DBNull.Value Then
					Return DirectCast(DirectCast(Nothing, Object), T)
				End If
			End If

			Return DirectCast(this, T)
		Catch generatedExceptionName As Exception
			Return defaultValueFactory(this)
		End Try
	End Function

	''' <summary>
	'''     A System.Object extension method that converts this object to an or default.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">this.</param>
	''' <param name="defaultValueFactory">The default value factory.</param>
	''' <returns>The given data converted to a T.</returns>
	''' <example>
	'''     <code>
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	'''       using Z.ExtensionMethods.Object;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_Object_ToOrDefault
	'''           {
	'''               [TestMethod]
	'''               public void ToOrDefault()
	'''               {
	'''                   // Type
	'''                   object intValue = &quot;1&quot;;
	'''                   object invalidValue = &quot;Fizz&quot;;
	''' 
	'''                   // Exemples
	'''                   var result1 = intValue.ToOrDefault&lt;int&gt;(); // return 1;
	'''                   var result2 = invalidValue.ToOrDefault&lt;int&gt;(); // return 0;
	'''                   int result3 = invalidValue.ToOrDefault(3); // return 3;
	'''                   int result4 = invalidValue.ToOrDefault(() =&gt; 4); // return 4;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(1, result1);
	'''                   Assert.AreEqual(0, result2);
	'''                   Assert.AreEqual(3, result3);
	'''                   Assert.AreEqual(4, result4);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' <example>
	'''     <code>
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	'''       using Z.ExtensionMethods.Object;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_Object_ToOrDefault
	'''           {
	'''               [TestMethod]
	'''               public void ToOrDefault()
	'''               {
	'''                   // Type
	'''                   object intValue = &quot;1&quot;;
	'''                   object invalidValue = &quot;Fizz&quot;;
	''' 
	'''                   // Exemples
	'''                   var result1 = intValue.ToOrDefault&lt;int&gt;(); // return 1;
	'''                   var result2 = invalidValue.ToOrDefault&lt;int&gt;(); // return 0;
	'''                   int result3 = invalidValue.ToOrDefault(3); // return 3;
	'''                   int result4 = invalidValue.ToOrDefault(() =&gt; 4); // return 4;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(1, result1);
	'''                   Assert.AreEqual(0, result2);
	'''                   Assert.AreEqual(3, result3);
	'''                   Assert.AreEqual(4, result4);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' <example>
	'''     <code>
	'''           using Microsoft.VisualStudio.TestTools.UnitTesting;
	'''           using Z.ExtensionMethods.Object;
	'''           
	'''           namespace ExtensionMethods.Examples
	'''           {
	'''               [TestClass]
	'''               public class System_Object_ToOrDefault
	'''               {
	'''                   [TestMethod]
	'''                   public void ToOrDefault()
	'''                   {
	'''                       // Type
	'''                       object intValue = &quot;1&quot;;
	'''                       object invalidValue = &quot;Fizz&quot;;
	'''           
	'''                       // Exemples
	'''                       var result1 = intValue.ToOrDefault&lt;int&gt;(); // return 1;
	'''                       var result2 = invalidValue.ToOrDefault&lt;int&gt;(); // return 0;
	'''                       int result3 = invalidValue.ToOrDefault(3); // return 3;
	'''                       int result4 = invalidValue.ToOrDefault(() =&gt; 4); // return 4;
	'''           
	'''                       // Unit Test
	'''                       Assert.AreEqual(1, result1);
	'''                       Assert.AreEqual(0, result2);
	'''                       Assert.AreEqual(3, result3);
	'''                       Assert.AreEqual(4, result4);
	'''                   }
	'''               }
	'''           }
	'''     </code>
	''' </example>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToOrDefault(Of T)(this As [Object], defaultValueFactory As Func(Of T)) As T
		Return this.ToOrDefault(Function(x) defaultValueFactory())
	End Function

	''' <summary>
	'''     A System.Object extension method that converts this object to an or default.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">this.</param>
	''' <returns>The given data converted to a T.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToOrDefault(Of T)(this As [Object]) As T
		Return this.ToOrDefault(Function(x) Nothing)
	End Function

	''' <summary>
	'''     A System.Object extension method that converts this object to an or default.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">this.</param>
	''' <param name="defaultValue">The default value.</param>
	''' <returns>The given data converted to a T.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToOrDefault(Of T)(this As [Object], defaultValue As T) As T
		Return this.ToOrDefault(Function(x) defaultValue)
	End Function
End Module



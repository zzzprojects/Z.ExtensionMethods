
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.ComponentModel

Public Module Extensions_336

	''' <summary>
	'''     A System.Object extension method that toes the given this.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">this.</param>
	''' <returns>A T.</returns>
	''' <example>
	'''     <code>
	'''       using System;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	''' 
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_Object_To
	'''           {
	'''               [TestMethod]
	'''               public void To()
	'''               {
	'''                   string nullValue = null;
	'''                   string value = &quot;1&quot;;
	'''                   object dbNullValue = DBNull.Value;
	''' 
	'''                   // Exemples
	'''                   var result1 = value.To&lt;int&gt;(); // return 1;
	'''                   var result2 = value.To&lt;int?&gt;(); // return 1;
	'''                   var result3 = nullValue.To&lt;int?&gt;(); // return null;
	'''                   var result4 = dbNullValue.To&lt;int?&gt;(); // return null;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(1, result1);
	'''                   Assert.AreEqual(1, result2.Value);
	'''                   Assert.IsFalse(result3.HasValue);
	'''                   Assert.IsFalse(result4.HasValue);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' <example>
	'''     <code>
	'''       using System;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	'''       using Z.ExtensionMethods.Object;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_Object_To
	'''           {
	'''               [TestMethod]
	'''               public void To()
	'''               {
	'''                   string nullValue = null;
	'''                   string value = &quot;1&quot;;
	'''                   object dbNullValue = DBNull.Value;
	''' 
	'''                   // Exemples
	'''                   var result1 = value.To&lt;int&gt;(); // return 1;
	'''                   var result2 = value.To&lt;int?&gt;(); // return 1;
	'''                   var result3 = nullValue.To&lt;int?&gt;(); // return null;
	'''                   var result4 = dbNullValue.To&lt;int?&gt;(); // return null;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(1, result1);
	'''                   Assert.AreEqual(1, result2.Value);
	'''                   Assert.IsFalse(result3.HasValue);
	'''                   Assert.IsFalse(result4.HasValue);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	<System.Runtime.CompilerServices.Extension> _
	Public Function [To](Of T)(this As [Object]) As T
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
	End Function

	''' <summary>
	'''     A System.Object extension method that toes the given this.
	''' </summary>
	''' <param name="this">this.</param>
	''' <param name="type">The type.</param>
	''' <returns>An object.</returns>
	''' <example>
	'''     <code>
	'''       using System;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	''' 
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_Object_To
	'''           {
	'''               [TestMethod]
	'''               public void To()
	'''               {
	'''                   string nullValue = null;
	'''                   string value = &quot;1&quot;;
	'''                   object dbNullValue = DBNull.Value;
	''' 
	'''                   // Exemples
	'''                   var result1 = value.To&lt;int&gt;(); // return 1;
	'''                   var result2 = value.To&lt;int?&gt;(); // return 1;
	'''                   var result3 = nullValue.To&lt;int?&gt;(); // return null;
	'''                   var result4 = dbNullValue.To&lt;int?&gt;(); // return null;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(1, result1);
	'''                   Assert.AreEqual(1, result2.Value);
	'''                   Assert.IsFalse(result3.HasValue);
	'''                   Assert.IsFalse(result4.HasValue);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' <example>
	'''     <code>
	'''       using System;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	'''       using Z.ExtensionMethods.Object;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_Object_To
	'''           {
	'''               [TestMethod]
	'''               public void To()
	'''               {
	'''                   string nullValue = null;
	'''                   string value = &quot;1&quot;;
	'''                   object dbNullValue = DBNull.Value;
	''' 
	'''                   // Exemples
	'''                   var result1 = value.To&lt;int&gt;(); // return 1;
	'''                   var result2 = value.To&lt;int?&gt;(); // return 1;
	'''                   var result3 = nullValue.To&lt;int?&gt;(); // return null;
	'''                   var result4 = dbNullValue.To&lt;int?&gt;(); // return null;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(1, result1);
	'''                   Assert.AreEqual(1, result2.Value);
	'''                   Assert.IsFalse(result3.HasValue);
	'''                   Assert.IsFalse(result4.HasValue);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' ###
	''' <typeparam name="T">Generic type parameter.</typeparam>
	<System.Runtime.CompilerServices.Extension> _
	Public Function [To](this As [Object], type As Type) As Object
		If this IsNot Nothing Then
			Dim targetType As Type = type

			If this.[GetType]() = targetType Then
				Return this
			End If

			Dim converter As TypeConverter = TypeDescriptor.GetConverter(this)
			If converter IsNot Nothing Then
				If converter.CanConvertTo(targetType) Then
					Return converter.ConvertTo(this, targetType)
				End If
			End If

			converter = TypeDescriptor.GetConverter(targetType)
			If converter IsNot Nothing Then
				If converter.CanConvertFrom(this.[GetType]()) Then
					Return converter.ConvertFrom(this)
				End If
			End If

			If this = DBNull.Value Then
				Return Nothing
			End If
		End If

		Return this
	End Function
End Module



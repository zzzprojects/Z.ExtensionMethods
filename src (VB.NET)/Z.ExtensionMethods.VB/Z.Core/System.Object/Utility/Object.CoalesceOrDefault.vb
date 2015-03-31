
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_447

	''' <summary>
	'''     A T extension method that that return the first not null value (including the @this) or a default value.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="values">A variable-length parameters list containing values.</param>
	''' <returns>The first not null value or a default value.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function CoalesceOrDefault(Of T As Class)(this As T, ParamArray values As T()) As T
		If this IsNot Nothing Then
			Return this
		End If

		For Each value As T In values
			If value IsNot Nothing Then
				Return value
			End If
		Next

		Return Nothing
	End Function

	''' <summary>
	'''     A T extension method that that return the first not null value (including the @this) or a default value.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="defaultValueFactory">The default value factory.</param>
	''' <param name="values">A variable-length parameters list containing values.</param>
	''' <returns>The first not null value or a default value.</returns>
	''' <example>
	'''     <code>
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	''' 
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_Object_CoalesceOrDefault
	'''           {
	'''               [TestMethod]
	'''               public void CoalesceOrDefault()
	'''               {
	'''                   // Varable
	'''                   object nullObject = null;
	''' 
	'''                   // Type
	'''                   object @thisNull = null;
	'''                   object @thisNotNull = &quot;Fizz&quot;;
	''' 
	'''                   // Exemples
	'''                   object result1 = @thisNull.CoalesceOrDefault(nullObject, nullObject, &quot;Buzz&quot;); // return &quot;Buzz&quot;;
	'''                   object result2 = @thisNull.CoalesceOrDefault(() =&gt; &quot;Buzz&quot;, null, null); // return &quot;Buzz&quot;;
	'''                   object result3 = @thisNull.CoalesceOrDefault((x) =&gt; &quot;Buzz&quot;, null, null); // return &quot;Buzz&quot;;
	'''                   object result4 = @thisNotNull.CoalesceOrDefault(nullObject, nullObject, &quot;Buzz&quot;); // return &quot;Fizz&quot;;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(&quot;Buzz&quot;, result1);
	'''                   Assert.AreEqual(&quot;Buzz&quot;, result2);
	'''                   Assert.AreEqual(&quot;Buzz&quot;, result3);
	'''                   Assert.AreEqual(&quot;Fizz&quot;, result4);
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
	'''           public class System_Object_CoalesceOrDefault
	'''           {
	'''               [TestMethod]
	'''               public void CoalesceOrDefault()
	'''               {
	'''                   // Varable
	'''                   object nullObject = null;
	''' 
	'''                   // Type
	'''                   object @thisNull = null;
	'''                   object @thisNotNull = &quot;Fizz&quot;;
	''' 
	'''                   // Exemples
	'''                   object result1 = @thisNull.CoalesceOrDefault(nullObject, nullObject, &quot;Buzz&quot;); // return &quot;Buzz&quot;;
	'''                   object result2 = @thisNull.CoalesceOrDefault(() =&gt; &quot;Buzz&quot;, null, null); // return &quot;Buzz&quot;;
	'''                   object result3 = @thisNull.CoalesceOrDefault(x =&gt; &quot;Buzz&quot;, null, null); // return &quot;Buzz&quot;;
	'''                   object result4 = @thisNotNull.CoalesceOrDefault(nullObject, nullObject, &quot;Buzz&quot;); // return &quot;Fizz&quot;;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(&quot;Buzz&quot;, result1);
	'''                   Assert.AreEqual(&quot;Buzz&quot;, result2);
	'''                   Assert.AreEqual(&quot;Buzz&quot;, result3);
	'''                   Assert.AreEqual(&quot;Fizz&quot;, result4);
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
	'''               public class System_Object_CoalesceOrDefault
	'''               {
	'''                   [TestMethod]
	'''                   public void CoalesceOrDefault()
	'''                   {
	'''                       // Varable
	'''                       object nullObject = null;
	'''           
	'''                       // Type
	'''                       object @thisNull = null;
	'''                       object @thisNotNull = &quot;Fizz&quot;;
	'''           
	'''                       // Exemples
	'''                       object result1 = @thisNull.CoalesceOrDefault(nullObject, nullObject, &quot;Buzz&quot;); // return &quot;Buzz&quot;;
	'''                       object result2 = @thisNull.CoalesceOrDefault(() =&gt; &quot;Buzz&quot;, null, null); // return &quot;Buzz&quot;;
	'''                       object result3 = @thisNull.CoalesceOrDefault(x =&gt; &quot;Buzz&quot;, null, null); // return &quot;Buzz&quot;;
	'''                       object result4 = @thisNotNull.CoalesceOrDefault(nullObject, nullObject, &quot;Buzz&quot;); // return &quot;Fizz&quot;;
	'''           
	'''                       // Unit Test
	'''                       Assert.AreEqual(&quot;Buzz&quot;, result1);
	'''                       Assert.AreEqual(&quot;Buzz&quot;, result2);
	'''                       Assert.AreEqual(&quot;Buzz&quot;, result3);
	'''                       Assert.AreEqual(&quot;Fizz&quot;, result4);
	'''                   }
	'''               }
	'''           }
	'''     </code>
	''' </example>
	<System.Runtime.CompilerServices.Extension> _
	Public Function CoalesceOrDefault(Of T As Class)(this As T, defaultValueFactory As Func(Of T), ParamArray values As T()) As T
		If this IsNot Nothing Then
			Return this
		End If

		For Each value As T In values
			If value IsNot Nothing Then
				Return value
			End If
		Next

		Return defaultValueFactory()
	End Function

	''' <summary>
	'''     A T extension method that that return the first not null value (including the @this) or a default value.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="defaultValueFactory">The default value factory.</param>
	''' <param name="values">A variable-length parameters list containing values.</param>
	''' <returns>The first not null value or a default value.</returns>
	''' <example>
	'''     <code>
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	''' 
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_Object_CoalesceOrDefault
	'''           {
	'''               [TestMethod]
	'''               public void CoalesceOrDefault()
	'''               {
	'''                   // Varable
	'''                   object nullObject = null;
	''' 
	'''                   // Type
	'''                   object @thisNull = null;
	'''                   object @thisNotNull = &quot;Fizz&quot;;
	''' 
	'''                   // Exemples
	'''                   object result1 = @thisNull.CoalesceOrDefault(nullObject, nullObject, &quot;Buzz&quot;); // return &quot;Buzz&quot;;
	'''                   object result2 = @thisNull.CoalesceOrDefault(() =&gt; &quot;Buzz&quot;, null, null); // return &quot;Buzz&quot;;
	'''                   object result3 = @thisNull.CoalesceOrDefault((x) =&gt; &quot;Buzz&quot;, null, null); // return &quot;Buzz&quot;;
	'''                   object result4 = @thisNotNull.CoalesceOrDefault(nullObject, nullObject, &quot;Buzz&quot;); // return &quot;Fizz&quot;;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(&quot;Buzz&quot;, result1);
	'''                   Assert.AreEqual(&quot;Buzz&quot;, result2);
	'''                   Assert.AreEqual(&quot;Buzz&quot;, result3);
	'''                   Assert.AreEqual(&quot;Fizz&quot;, result4);
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
	'''           public class System_Object_CoalesceOrDefault
	'''           {
	'''               [TestMethod]
	'''               public void CoalesceOrDefault()
	'''               {
	'''                   // Varable
	'''                   object nullObject = null;
	''' 
	'''                   // Type
	'''                   object @thisNull = null;
	'''                   object @thisNotNull = &quot;Fizz&quot;;
	''' 
	'''                   // Exemples
	'''                   object result1 = @thisNull.CoalesceOrDefault(nullObject, nullObject, &quot;Buzz&quot;); // return &quot;Buzz&quot;;
	'''                   object result2 = @thisNull.CoalesceOrDefault(() =&gt; &quot;Buzz&quot;, null, null); // return &quot;Buzz&quot;;
	'''                   object result3 = @thisNull.CoalesceOrDefault(x =&gt; &quot;Buzz&quot;, null, null); // return &quot;Buzz&quot;;
	'''                   object result4 = @thisNotNull.CoalesceOrDefault(nullObject, nullObject, &quot;Buzz&quot;); // return &quot;Fizz&quot;;
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(&quot;Buzz&quot;, result1);
	'''                   Assert.AreEqual(&quot;Buzz&quot;, result2);
	'''                   Assert.AreEqual(&quot;Buzz&quot;, result3);
	'''                   Assert.AreEqual(&quot;Fizz&quot;, result4);
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
	'''               public class System_Object_CoalesceOrDefault
	'''               {
	'''                   [TestMethod]
	'''                   public void CoalesceOrDefault()
	'''                   {
	'''                       // Varable
	'''                       object nullObject = null;
	'''           
	'''                       // Type
	'''                       object @thisNull = null;
	'''                       object @thisNotNull = &quot;Fizz&quot;;
	'''           
	'''                       // Exemples
	'''                       object result1 = @thisNull.CoalesceOrDefault(nullObject, nullObject, &quot;Buzz&quot;); // return &quot;Buzz&quot;;
	'''                       object result2 = @thisNull.CoalesceOrDefault(() =&gt; &quot;Buzz&quot;, null, null); // return &quot;Buzz&quot;;
	'''                       object result3 = @thisNull.CoalesceOrDefault(x =&gt; &quot;Buzz&quot;, null, null); // return &quot;Buzz&quot;;
	'''                       object result4 = @thisNotNull.CoalesceOrDefault(nullObject, nullObject, &quot;Buzz&quot;); // return &quot;Fizz&quot;;
	'''           
	'''                       // Unit Test
	'''                       Assert.AreEqual(&quot;Buzz&quot;, result1);
	'''                       Assert.AreEqual(&quot;Buzz&quot;, result2);
	'''                       Assert.AreEqual(&quot;Buzz&quot;, result3);
	'''                       Assert.AreEqual(&quot;Fizz&quot;, result4);
	'''                   }
	'''               }
	'''           }
	'''     </code>
	''' </example>
	<System.Runtime.CompilerServices.Extension> _
	Public Function CoalesceOrDefault(Of T As Class)(this As T, defaultValueFactory As Func(Of T, T), ParamArray values As T()) As T
		If this IsNot Nothing Then
			Return this
		End If

		For Each value As T In values
			If value IsNot Nothing Then
				Return value
			End If
		Next

		Return defaultValueFactory(this)
	End Function
End Module



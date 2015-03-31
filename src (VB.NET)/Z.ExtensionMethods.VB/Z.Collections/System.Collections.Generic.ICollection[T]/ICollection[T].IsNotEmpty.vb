
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic

Public Module Extensions_10

	''' <summary>
	'''     An ICollection&lt;T&gt; extension method that query if the collection is not empty.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true if not empty&lt; t&gt;, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsNotEmpty(Of T)(this As ICollection(Of T)) As Boolean
		Return this.Count <> 0
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic

Public Module Extensions_2

	''' <summary>
	'''     An ICollection&lt;T&gt; extension method that adds only if the value satisfies the predicate.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="predicate">The predicate.</param>
	''' <param name="value">The value.</param>
	''' <returns>true if it succeeds, false if it fails.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function AddIf(Of T)(this As ICollection(Of T), predicate As Func(Of T, Boolean), value As T) As Boolean
		If predicate(value) Then
			this.Add(value)
			Return True
		End If

		Return False
	End Function
End Module



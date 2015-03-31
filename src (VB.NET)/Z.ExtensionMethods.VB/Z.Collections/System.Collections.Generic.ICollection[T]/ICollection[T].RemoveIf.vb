
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic

Public Module Extensions_13

	''' <summary>
	'''     An ICollection&lt;T&gt; extension method that removes if.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="value">The value.</param>
	''' <param name="predicate">The predicate.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub RemoveIf(Of T)(this As ICollection(Of T), value As T, predicate As Func(Of T, Boolean))
		If predicate(value) Then
			this.Remove(value)
		End If
	End Sub
End Module



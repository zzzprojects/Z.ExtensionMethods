
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Linq

Public Module Extensions_18

	''' <summary>
	'''     An ICollection&lt;T&gt; extension method that removes value that satisfy the predicate.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="predicate">The predicate.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub RemoveWhere(Of T)(this As ICollection(Of T), predicate As Func(Of T, Boolean))
		Dim list As List(Of T) = this.Where(predicate).ToList()
		For Each item As T In list
			this.Remove(item)
		Next
	End Sub
End Module



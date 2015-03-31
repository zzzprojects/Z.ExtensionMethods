
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Linq

Public Module Extensions_30

	''' <summary>
	'''     Enumerates for each in this collection.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="action">The action.</param>
	''' <returns>An enumerator that allows foreach to be used to process for each in this collection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ForEach(Of T)(this As IEnumerable(Of T), action As Action(Of T)) As IEnumerable(Of T)
		Dim array As T() = this.ToArray()
        For Each item As T In array
            action(item)
        Next
		Return array
	End Function

	''' <summary>Enumerates for each in this collection.</summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="action">The action.</param>
	''' <returns>An enumerator that allows foreach to be used to process for each in this collection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ForEach(Of T)(this As IEnumerable(Of T), action As Action(Of T, Integer)) As IEnumerable(Of T)
		Dim array As T() = this.ToArray()

		For i As Integer = 0 To array.Length - 1
			action(array(i), i)
		Next

		Return array
	End Function
End Module



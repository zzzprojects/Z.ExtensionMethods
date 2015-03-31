
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Linq

Public Module Extensions_524

	''' <summary>
	'''     A string extension method that replace last occurence.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="oldValue">The old value.</param>
	''' <param name="newValue">The new value.</param>
	''' <returns>The string with the last occurence of old value replace by new value.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ReplaceLast(this As String, oldValue As String, newValue As String) As String
		Dim startindex As Integer = this.LastIndexOf(oldValue)

		If startindex = -1 Then
			Return this
		End If

		Return this.Remove(startindex, oldValue.Length).Insert(startindex, newValue)
	End Function

	''' <summary>
	'''     A string extension method that replace last numbers occurences.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="number">Number of.</param>
	''' <param name="oldValue">The old value.</param>
	''' <param name="newValue">The new value.</param>
	''' <returns>The string with the last numbers occurences of old value replace by new value.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ReplaceLast(this As String, number As Integer, oldValue As String, newValue As String) As String
		Dim list As List(Of String) = this.Split(oldValue).ToList()
		Dim old As Integer = Math.Max(0, list.Count - number - 1)
		Dim listStart As IEnumerable(Of String) = list.Take(old)
		Dim listEnd As IEnumerable(Of String) = list.Skip(old)

		Return String.Join(oldValue, listStart) + (If(old > 0, oldValue, "")) + String.Join(newValue, listEnd)
	End Function
End Module



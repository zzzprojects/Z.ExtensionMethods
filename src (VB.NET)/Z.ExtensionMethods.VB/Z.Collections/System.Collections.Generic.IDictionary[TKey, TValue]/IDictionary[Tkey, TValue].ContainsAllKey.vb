
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic

Public Module Extensions_23

	''' <summary>
	'''     An IDictionary&lt;TKey,TValue&gt; extension method that query if '@this' contains all key.
	''' </summary>
	''' <typeparam name="TKey">Type of the key.</typeparam>
	''' <typeparam name="TValue">Type of the value.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="keys">A variable-length parameters list containing keys.</param>
	''' <returns>true if it succeeds, false if it fails.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ContainsAllKey(Of TKey, TValue)(this As IDictionary(Of TKey, TValue), ParamArray keys As TKey()) As Boolean
		For Each value As TKey In keys
			If Not this.ContainsKey(value) Then
				Return False
			End If
		Next

		Return True
	End Function
End Module



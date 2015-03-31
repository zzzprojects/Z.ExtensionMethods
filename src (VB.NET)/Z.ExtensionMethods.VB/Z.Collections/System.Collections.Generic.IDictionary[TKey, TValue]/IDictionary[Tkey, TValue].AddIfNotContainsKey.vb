
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic

Public Module Extensions_21

	''' <summary>
	'''     An IDictionary&lt;TKey,TValue&gt; extension method that adds if not contains key.
	''' </summary>
	''' <typeparam name="TKey">Type of the key.</typeparam>
	''' <typeparam name="TValue">Type of the value.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="key">The key.</param>
	''' <param name="value">The value.</param>
	''' <returns>true if it succeeds, false if it fails.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function AddIfNotContainsKey(Of TKey, TValue)(this As IDictionary(Of TKey, TValue), key As TKey, value As TValue) As Boolean
		If Not this.ContainsKey(key) Then
			this.Add(key, value)
			Return True
		End If

		Return False
	End Function

	''' <summary>
	'''     An IDictionary&lt;TKey,TValue&gt; extension method that adds if not contains key.
	''' </summary>
	''' <typeparam name="TKey">Type of the key.</typeparam>
	''' <typeparam name="TValue">Type of the value.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="key">The key.</param>
	''' <param name="valueFactory">The value factory.</param>
	''' <returns>true if it succeeds, false if it fails.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function AddIfNotContainsKey(Of TKey, TValue)(this As IDictionary(Of TKey, TValue), key As TKey, valueFactory As Func(Of TValue)) As Boolean
		If Not this.ContainsKey(key) Then
			this.Add(key, valueFactory())
			Return True
		End If

		Return False
	End Function

	''' <summary>
	'''     An IDictionary&lt;TKey,TValue&gt; extension method that adds if not contains key.
	''' </summary>
	''' <typeparam name="TKey">Type of the key.</typeparam>
	''' <typeparam name="TValue">Type of the value.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="key">The key.</param>
	''' <param name="valueFactory">The value factory.</param>
	''' <returns>true if it succeeds, false if it fails.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function AddIfNotContainsKey(Of TKey, TValue)(this As IDictionary(Of TKey, TValue), key As TKey, valueFactory As Func(Of TKey, TValue)) As Boolean
		If Not this.ContainsKey(key) Then
			this.Add(key, valueFactory(key))
			Return True
		End If

		Return False
	End Function
End Module



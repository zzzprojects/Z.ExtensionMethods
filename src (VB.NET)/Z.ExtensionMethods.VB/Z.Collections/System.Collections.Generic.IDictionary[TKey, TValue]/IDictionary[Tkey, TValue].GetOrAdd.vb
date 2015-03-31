
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic

Public Module Extensions_25

	''' <summary>
	'''     Adds a key/value pair to the IDictionary&lt;TKey, TValue&gt; if the key does not already exist.
	''' </summary>
	''' <typeparam name="TKey">Type of the key.</typeparam>
	''' <typeparam name="TValue">Type of the value.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="key">The key of the element to add.</param>
	''' <param name="value">The value to be added, if the key does not already exist.</param>
	''' <returns>
	'''     The value for the key. This will be either the existing value for the key if the key is already in the
	'''     dictionary, or the new value if the key was not in the dictionary.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetOrAdd(Of TKey, TValue)(this As IDictionary(Of TKey, TValue), key As TKey, value As TValue) As TValue
		If Not this.ContainsKey(key) Then
			this.Add(New KeyValuePair(Of TKey, TValue)(key, value))
		End If

		Return this(key)
	End Function

	''' <summary>
	'''     Adds a key/value pair to the IDictionary&lt;TKey, TValue&gt; by using the specified function, if the key does
	'''     not already exist.
	''' </summary>
	''' <typeparam name="TKey">Type of the key.</typeparam>
	''' <typeparam name="TValue">Type of the value.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="key">The key of the element to add.</param>
	''' <param name="valueFactory">TThe function used to generate a value for the key.</param>
	''' <returns>
	'''     The value for the key. This will be either the existing value for the key if the key is already in the
	'''     dictionary, or the new value for the key as returned by valueFactory if the key was not in the dictionary.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetOrAdd(Of TKey, TValue)(this As IDictionary(Of TKey, TValue), key As TKey, valueFactory As Func(Of TKey, TValue)) As TValue
		If Not this.ContainsKey(key) Then
			this.Add(New KeyValuePair(Of TKey, TValue)(key, valueFactory(key)))
		End If

		Return this(key)
	End Function
End Module



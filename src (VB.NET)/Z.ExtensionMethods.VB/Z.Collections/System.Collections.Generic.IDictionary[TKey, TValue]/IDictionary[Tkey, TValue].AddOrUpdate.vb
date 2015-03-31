
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic

Public Module Extensions_22

	''' <summary>
	'''     Uses the specified functions to add a key/value pair to the IDictionary&lt;TKey, TValue&gt; if the key does
	'''     not already exist, or to update a key/value pair in the IDictionary&lt;TKey, TValue&gt;> if the key already
	'''     exists.
	''' </summary>
	''' <typeparam name="TKey">Type of the key.</typeparam>
	''' <typeparam name="TValue">Type of the value.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="key">The key to be added or whose value should be updated.</param>
	''' <param name="value">The value to be added or updated.</param>
	''' <returns>The new value for the key.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function AddOrUpdate(Of TKey, TValue)(this As IDictionary(Of TKey, TValue), key As TKey, value As TValue) As TValue
		If Not this.ContainsKey(key) Then
			this.Add(New KeyValuePair(Of TKey, TValue)(key, value))
		Else
			this(key) = value
		End If

		Return this(key)
	End Function

	''' <summary>
	'''     Uses the specified functions to add a key/value pair to the IDictionary&lt;TKey, TValue&gt; if the key does
	'''     not already exist, or to update a key/value pair in the IDictionary&lt;TKey, TValue&gt;> if the key already
	'''     exists.
	''' </summary>
	''' <typeparam name="TKey">Type of the key.</typeparam>
	''' <typeparam name="TValue">Type of the value.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="key">The key to be added or whose value should be updated.</param>
	''' <param name="addValue">The value to be added for an absent key.</param>
	''' <param name="updateValueFactory">
	'''     The function used to generate a new value for an existing key based on the key's
	'''     existing value.
	''' </param>
	''' <returns>
	'''     The new value for the key. This will be either be addValue (if the key was absent) or the result of
	'''     updateValueFactory (if the key was present).
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function AddOrUpdate(Of TKey, TValue)(this As IDictionary(Of TKey, TValue), key As TKey, addValue As TValue, updateValueFactory As Func(Of TKey, TValue, TValue)) As TValue
		If Not this.ContainsKey(key) Then
			this.Add(New KeyValuePair(Of TKey, TValue)(key, addValue))
		Else
			this(key) = updateValueFactory(key, this(key))
		End If

		Return this(key)
	End Function

	''' <summary>
	'''     Uses the specified functions to add a key/value pair to the IDictionary&lt;TKey, TValue&gt; if the key does
	'''     not already exist, or to update a key/value pair in the IDictionary&lt;TKey, TValue&gt;> if the key already
	'''     exists.
	''' </summary>
	''' <typeparam name="TKey">Type of the key.</typeparam>
	''' <typeparam name="TValue">Type of the value.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="key">The key to be added or whose value should be updated.</param>
	''' <param name="addValueFactory">The function used to generate a value for an absent key.</param>
	''' <param name="updateValueFactory">
	'''     The function used to generate a new value for an existing key based on the key's
	'''     existing value.
	''' </param>
	''' <returns>
	'''     The new value for the key. This will be either be the result of addValueFactory (if the key was absent) or
	'''     the result of updateValueFactory (if the key was present).
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function AddOrUpdate(Of TKey, TValue)(this As IDictionary(Of TKey, TValue), key As TKey, addValueFactory As Func(Of TKey, TValue), updateValueFactory As Func(Of TKey, TValue, TValue)) As TValue
		If Not this.ContainsKey(key) Then
			this.Add(New KeyValuePair(Of TKey, TValue)(key, addValueFactory(key)))
		Else
			this(key) = updateValueFactory(key, this(key))
		End If

		Return this(key)
	End Function
End Module



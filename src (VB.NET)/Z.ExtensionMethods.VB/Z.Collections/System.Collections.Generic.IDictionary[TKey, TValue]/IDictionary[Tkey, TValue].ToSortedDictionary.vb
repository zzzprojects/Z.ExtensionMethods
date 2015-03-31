
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic

Public Module Extensions_27

	''' <summary>
	'''     An IDictionary&lt;TKey,TValue&gt; extension method that converts the @this to a sorted dictionary.
	''' </summary>
	''' <typeparam name="TKey">Type of the key.</typeparam>
	''' <typeparam name="TValue">Type of the value.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a SortedDictionary&lt;TKey,TValue&gt;</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToSortedDictionary(Of TKey, TValue)(this As IDictionary(Of TKey, TValue)) As SortedDictionary(Of TKey, TValue)
		Return New SortedDictionary(Of TKey, TValue)(this)
	End Function

	''' <summary>
	'''     An IDictionary&lt;TKey,TValue&gt; extension method that converts the @this to a sorted dictionary.
	''' </summary>
	''' <typeparam name="TKey">Type of the key.</typeparam>
	''' <typeparam name="TValue">Type of the value.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="comparer">The comparer.</param>
	''' <returns>@this as a SortedDictionary&lt;TKey,TValue&gt;</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToSortedDictionary(Of TKey, TValue)(this As IDictionary(Of TKey, TValue), comparer As IComparer(Of TKey)) As SortedDictionary(Of TKey, TValue)
		Return New SortedDictionary(Of TKey, TValue)(this, comparer)
	End Function
End Module



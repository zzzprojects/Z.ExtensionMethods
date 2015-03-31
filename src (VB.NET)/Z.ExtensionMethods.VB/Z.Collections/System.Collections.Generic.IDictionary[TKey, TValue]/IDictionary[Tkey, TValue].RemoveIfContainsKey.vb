
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic

Public Module Extensions_26

	''' <summary>
	'''     An IDictionary&lt;TKey,TValue&gt; extension method that removes if contains key.
	''' </summary>
	''' <typeparam name="TKey">Type of the key.</typeparam>
	''' <typeparam name="TValue">Type of the value.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="key">The key.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub RemoveIfContainsKey(Of TKey, TValue)(this As IDictionary(Of TKey, TValue), key As TKey)
		If this.ContainsKey(key) Then
			this.Remove(key)
		End If
	End Sub
End Module



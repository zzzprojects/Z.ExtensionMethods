
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic

Public Module Extensions_35

	''' <summary>
	'''     Concatenates all the elements of a IEnumerable, using the specified separator between each element.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">An IEnumerable that contains the elements to concatenate.</param>
	''' <param name="separator">
	'''     The string to use as a separator. separator is included in the returned string only if
	'''     value has more than one element.
	''' </param>
	''' <returns>
	'''     A string that consists of the elements in value delimited by the separator string. If value is an empty array,
	'''     the method returns String.Empty.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function StringJoin(Of T)(this As IEnumerable(Of T), separator As String) As String
		Return String.Join(separator, this)
	End Function

	''' <summary>
	'''     Concatenates all the elements of a IEnumerable, using the specified separator between
	'''     each element.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="separator">
	'''     The string to use as a separator. separator is included in the
	'''     returned string only if value has more than one element.
	''' </param>
	''' <returns>
	'''     A string that consists of the elements in value delimited by the separator string. If
	'''     value is an empty array, the method returns String.Empty.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function StringJoin(Of T)(this As IEnumerable(Of T), separator As Char) As String
		Return String.Join(separator.ToString(), this)
	End Function
End Module



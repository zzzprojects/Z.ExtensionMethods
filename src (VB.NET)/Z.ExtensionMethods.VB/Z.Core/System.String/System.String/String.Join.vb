
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic

Public Module Extensions_567

	''' <summary>
	'''     Concatenates all the elements of a string array, using the specified separator between each element.
	''' </summary>
	''' <param name="separator">
	'''     The string to use as a separator.  is included in the returned string only if  has more
	'''     than one element.
	''' </param>
	''' <param name="value">An array that contains the elements to concatenate.</param>
	''' <returns>
	'''     A string that consists of the elements in  delimited by the  string. If  is an empty array, the method
	'''     returns .
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Join(separator As [String], value As [String]()) As [String]
		Return [String].Join(separator, value)
	End Function

	''' <summary>
	'''     Concatenates the elements of an object array, using the specified separator between each element.
	''' </summary>
	''' <param name="separator">
	'''     The string to use as a separator.  is included in the returned string only if  has more
	'''     than one element.
	''' </param>
	''' <param name="values">An array that contains the elements to concatenate.</param>
	''' <returns>
	'''     A string that consists of the elements of  delimited by the  string. If  is an empty array, the method
	'''     returns .
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Join(separator As [String], values As [Object]()) As [String]
		Return [String].Join(separator, values)
	End Function

	''' <summary>
	'''     A String extension method that joins.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="separator">
	'''     The string to use as a separator.  is included in the returned string only if  has more
	'''     than one element.
	''' </param>
	''' <param name="values">An array that contains the elements to concatenate.</param>
	''' <returns>A String.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Join(Of T)(separator As [String], values As IEnumerable(Of T)) As [String]
		Return [String].Join(separator, values)
	End Function

	''' <summary>
	'''     Concatenates all the elements of a string array, using the specified separator between each element.
	''' </summary>
	''' <param name="separator">
	'''     The string to use as a separator.  is included in the returned string only if  has more
	'''     than one element.
	''' </param>
	''' <param name="values">An array that contains the elements to concatenate.</param>
	''' <returns>
	'''     A string that consists of the elements in  delimited by the  string. If  is an empty array, the method
	'''     returns .
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Join(separator As [String], values As IEnumerable(Of [String])) As [String]
		Return [String].Join(separator, values)
	End Function

	''' <summary>
	'''     Concatenates the specified elements of a string array, using the specified separator between each element.
	''' </summary>
	''' <param name="separator">
	'''     The string to use as a separator.  is included in the returned string only if  has more
	'''     than one element.
	''' </param>
	''' <param name="value">An array that contains the elements to concatenate.</param>
	''' <param name="startIndex">The first element in  to use.</param>
	''' <param name="count">The number of elements of  to use.</param>
	''' <returns>
	'''     A string that consists of the strings in  delimited by the  string. -or- if  is zero,  has no elements, or
	'''     and all the elements of  are .
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Join(separator As [String], value As [String](), startIndex As Int32, count As Int32) As [String]
		Return [String].Join(separator, value, startIndex, count)
	End Function
End Module



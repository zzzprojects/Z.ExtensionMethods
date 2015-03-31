
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_58

	''' <summary>
	'''     Searches for the specified object and returns the index of the first occurrence within the entire one-
	'''     dimensional .
	''' </summary>
	''' <param name="array">The one-dimensional  to search.</param>
	''' <param name="value">The object to locate in .</param>
	''' <returns>
	'''     The index of the first occurrence of  within the entire , if found; otherwise, the lower bound of the array
	'''     minus 1.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IndexOf(array__1 As Array, value As [Object]) As Int32
		Return Array.IndexOf(array__1, value)
	End Function

	''' <summary>
	'''     Searches for the specified object and returns the index of the first occurrence within the range of elements
	'''     in the one-dimensional  that extends from the specified index to the last element.
	''' </summary>
	''' <param name="array">The one-dimensional  to search.</param>
	''' <param name="value">The object to locate in .</param>
	''' <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
	''' <returns>
	'''     The index of the first occurrence of  within the range of elements in  that extends from  to the last element,
	'''     if found; otherwise, the lower bound of the array minus 1.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IndexOf(array__1 As Array, value As [Object], startIndex As Int32) As Int32
		Return Array.IndexOf(array__1, value, startIndex)
	End Function

	''' <summary>
	'''     Searches for the specified object and returns the index of the first occurrence within the range of elements
	'''     in the one-dimensional  that starts at the specified index and contains the specified number of elements.
	''' </summary>
	''' <param name="array">The one-dimensional  to search.</param>
	''' <param name="value">The object to locate in .</param>
	''' <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
	''' <param name="count">The number of elements in the section to search.</param>
	''' <returns>
	'''     The index of the first occurrence of  within the range of elements in  that starts at  and contains the
	'''     number of elements specified in , if found; otherwise, the lower bound of the array minus 1.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IndexOf(array__1 As Array, value As [Object], startIndex As Int32, count As Int32) As Int32
		Return Array.IndexOf(array__1, value, startIndex, count)
	End Function
End Module



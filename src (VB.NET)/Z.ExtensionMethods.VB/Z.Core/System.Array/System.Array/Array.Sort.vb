
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections

Public Module Extensions_61

	''' <summary>
	'''     Sorts the elements in an entire one-dimensional  using the  implementation of each element of the .
	''' </summary>
	''' <param name="array">The one-dimensional  to sort.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Sort(array__1 As Array)
		Array.Sort(array__1)
	End Sub

	''' <summary>
	'''     Sorts a pair of one-dimensional  objects (one contains the keys and the other contains the corresponding
	'''     items) based on the keys in the first  using the  implementation of each key.
	''' </summary>
	''' <param name="array">The one-dimensional  to sort.</param>
	''' <param name="items">
	'''     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
	'''     null to sort only the .
	''' </param>
	''' ###
	''' <param name="keys">The one-dimensional  that contains the keys to sort.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Sort(array__1 As Array, items As Array)
		Array.Sort(array__1, items)
	End Sub

	''' <summary>
	'''     Sorts the elements in a range of elements in a one-dimensional  using the  implementation of each element of
	'''     the .
	''' </summary>
	''' <param name="array">The one-dimensional  to sort.</param>
	''' <param name="index">The starting index of the range to sort.</param>
	''' <param name="length">The number of elements in the range to sort.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Sort(array__1 As Array, index As Int32, length As Int32)
		Array.Sort(array__1, index, length)
	End Sub

	''' <summary>
	'''     Sorts a range of elements in a pair of one-dimensional  objects (one contains the keys and the other contains
	'''     the corresponding items) based on the keys in the first  using the  implementation of each key.
	''' </summary>
	''' <param name="array">The one-dimensional  to sort.</param>
	''' <param name="items">
	'''     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
	'''     null to sort only the .
	''' </param>
	''' <param name="index">The starting index of the range to sort.</param>
	''' <param name="length">The number of elements in the range to sort.</param>
	''' ###
	''' <param name="keys">The one-dimensional  that contains the keys to sort.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Sort(array__1 As Array, items As Array, index As Int32, length As Int32)
		Array.Sort(array__1, items, index, length)
	End Sub

	''' <summary>
	'''     Sorts the elements in a one-dimensional  using the specified .
	''' </summary>
	''' <param name="array">The one-dimensional  to sort.</param>
	''' <param name="comparer">
	'''     The  implementation to use when comparing elements.-or-null to use the  implementation of
	'''     each element.
	''' </param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Sort(array__1 As Array, comparer As IComparer)
		Array.Sort(array__1, comparer)
	End Sub

	''' <summary>
	'''     Sorts a pair of one-dimensional  objects (one contains the keys and the other contains the corresponding
	'''     items) based on the keys in the first  using the specified .
	''' </summary>
	''' <param name="array">The one-dimensional  to sort.</param>
	''' <param name="items">
	'''     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
	'''     null to sort only the .
	''' </param>
	''' <param name="comparer">
	'''     The  implementation to use when comparing elements.-or-null to use the  implementation of
	'''     each element.
	''' </param>
	''' ###
	''' <param name="keys">The one-dimensional  that contains the keys to sort.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Sort(array__1 As Array, items As Array, comparer As IComparer)
		Array.Sort(array__1, items, comparer)
	End Sub

	''' <summary>
	'''     Sorts the elements in a range of elements in a one-dimensional  using the specified .
	''' </summary>
	''' <param name="array">The one-dimensional  to sort.</param>
	''' <param name="index">The starting index of the range to sort.</param>
	''' <param name="length">The number of elements in the range to sort.</param>
	''' <param name="comparer">
	'''     The  implementation to use when comparing elements.-or-null to use the  implementation of
	'''     each element.
	''' </param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Sort(array__1 As Array, index As Int32, length As Int32, comparer As IComparer)
		Array.Sort(array__1, index, length, comparer)
	End Sub

	''' <summary>
	'''     Sorts a range of elements in a pair of one-dimensional  objects (one contains the keys and the other contains
	'''     the corresponding items) based on the keys in the first  using the specified .
	''' </summary>
	''' <param name="array">The one-dimensional  to sort.</param>
	''' <param name="items">
	'''     The one-dimensional  that contains the items that correspond to each of the keys in the .-or-
	'''     null to sort only the .
	''' </param>
	''' <param name="index">The starting index of the range to sort.</param>
	''' <param name="length">The number of elements in the range to sort.</param>
	''' <param name="comparer">
	'''     The  implementation to use when comparing elements.-or-null to use the  implementation of
	'''     each element.
	''' </param>
	''' ###
	''' <param name="keys">The one-dimensional  that contains the keys to sort.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Sort(array__1 As Array, items As Array, index As Int32, length As Int32, comparer As IComparer)
		Array.Sort(array__1, items, index, length, comparer)
	End Sub
End Module



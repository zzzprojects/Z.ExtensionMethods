
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_57

	''' <summary>
	'''     Copies a range of elements from an  starting at the first element and pastes them into another  starting at
	'''     the first element. The length is specified as a 32-bit integer.
	''' </summary>
	''' <param name="sourceArray">The  that contains the data to copy.</param>
	''' <param name="destinationArray">The  that receives the data.</param>
	''' <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Copy(sourceArray As Array, destinationArray As Array, length As Int32)
		Array.Copy(sourceArray, destinationArray, length)
	End Sub

	''' <summary>
	'''     Copies a range of elements from an  starting at the specified source index and pastes them to another
	'''     starting at the specified destination index. The length and the indexes are specified as 32-bit integers.
	''' </summary>
	''' <param name="sourceArray">The  that contains the data to copy.</param>
	''' <param name="sourceIndex">A 32-bit integer that represents the index in the  at which copying begins.</param>
	''' <param name="destinationArray">The  that receives the data.</param>
	''' <param name="destinationIndex">A 32-bit integer that represents the index in the  at which storing begins.</param>
	''' <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Copy(sourceArray As Array, sourceIndex As Int32, destinationArray As Array, destinationIndex As Int32, length As Int32)
		Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length)
	End Sub

	''' <summary>
	'''     Copies a range of elements from an  starting at the first element and pastes them into another  starting at
	'''     the first element. The length is specified as a 64-bit integer.
	''' </summary>
	''' <param name="sourceArray">The  that contains the data to copy.</param>
	''' <param name="destinationArray">The  that receives the data.</param>
	''' <param name="length">
	'''     A 64-bit integer that represents the number of elements to copy. The integer must be between
	'''     zero and , inclusive.
	''' </param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Copy(sourceArray As Array, destinationArray As Array, length As Int64)
		Array.Copy(sourceArray, destinationArray, length)
	End Sub

	''' <summary>
	'''     Copies a range of elements from an  starting at the specified source index and pastes them to another
	'''     starting at the specified destination index. The length and the indexes are specified as 64-bit integers.
	''' </summary>
	''' <param name="sourceArray">The  that contains the data to copy.</param>
	''' <param name="sourceIndex">A 64-bit integer that represents the index in the  at which copying begins.</param>
	''' <param name="destinationArray">The  that receives the data.</param>
	''' <param name="destinationIndex">A 64-bit integer that represents the index in the  at which storing begins.</param>
	''' <param name="length">
	'''     A 64-bit integer that represents the number of elements to copy. The integer must be between
	'''     zero and , inclusive.
	''' </param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Copy(sourceArray As Array, sourceIndex As Int64, destinationArray As Array, destinationIndex As Int64, length As Int64)
		Array.Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length)
	End Sub
End Module



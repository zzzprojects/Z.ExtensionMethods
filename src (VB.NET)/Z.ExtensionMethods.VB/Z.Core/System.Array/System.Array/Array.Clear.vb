
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_55

	''' <summary>
	'''     Sets a range of elements in the  to zero, to false, or to null, depending on the element type.
	''' </summary>
	''' <param name="array">The  whose elements need to be cleared.</param>
	''' <param name="index">The starting index of the range of elements to clear.</param>
	''' <param name="length">The number of elements to clear.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Clear(array__1 As Array, index As Int32, length As Int32)
		Array.Clear(array__1, index, length)
	End Sub
End Module



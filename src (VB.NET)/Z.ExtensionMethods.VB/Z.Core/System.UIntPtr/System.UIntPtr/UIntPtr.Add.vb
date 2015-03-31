
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_631

	''' <summary>
	'''     Adds an offset to the value of an unsigned pointer.
	''' </summary>
	''' <param name="pointer">The unsigned pointer to add the offset to.</param>
	''' <param name="offset">The offset to add.</param>
	''' <returns>A new unsigned pointer that reflects the addition of  to .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Add(pointer As UIntPtr, offset As Int32) As UIntPtr
		Return UIntPtr.Add(pointer, offset)
	End Function
End Module



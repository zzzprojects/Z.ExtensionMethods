
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_64

	''' <summary>
	'''     Retrieves the byte at a specified location in a specified array.
	''' </summary>
	''' <param name="array">An array.</param>
	''' <param name="index">A location in the array.</param>
	''' <returns>Returns the  byte in the array.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetByte(array As Array, index As Int32) As [Byte]
		Return Buffer.GetByte(array, index)
	End Function
End Module



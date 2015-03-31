
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_63

	''' <summary>
	'''     Returns the number of bytes in the specified array.
	''' </summary>
	''' <param name="array">An array.</param>
	''' <returns>The number of bytes in the array.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ByteLength(array As Array) As Int32
		Return Buffer.ByteLength(array)
	End Function
End Module



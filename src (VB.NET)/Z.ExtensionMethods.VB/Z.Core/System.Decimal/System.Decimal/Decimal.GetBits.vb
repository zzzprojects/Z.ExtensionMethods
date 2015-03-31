
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_168

	''' <summary>
	'''     Converts the value of a specified instance of  to its equivalent binary representation.
	''' </summary>
	''' <param name="d">The value to convert.</param>
	''' <returns>A 32-bit signed integer array with four elements that contain the binary representation of .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetBits(d As [Decimal]) As Int32()
		Return [Decimal].GetBits(d)
	End Function
End Module



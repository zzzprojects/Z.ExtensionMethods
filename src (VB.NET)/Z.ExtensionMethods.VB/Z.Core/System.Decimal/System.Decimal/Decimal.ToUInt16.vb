
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_181

	''' <summary>
	'''     Converts the value of the specified  to the equivalent 16-bit unsigned integer.
	''' </summary>
	''' <param name="value">The decimal number to convert.</param>
	''' <returns>A 16-bit unsigned integer equivalent to the value of .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToUInt16(value As [Decimal]) As UInt16
		Return [Decimal].ToUInt16(value)
	End Function
End Module



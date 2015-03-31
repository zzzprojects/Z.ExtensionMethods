
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_183

	''' <summary>
	'''     Converts the value of the specified  to the equivalent 64-bit unsigned integer.
	''' </summary>
	''' <param name="d">The decimal number to convert.</param>
	''' <returns>A 64-bit unsigned integer equivalent to the value of .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToUInt64(d As [Decimal]) As UInt64
		Return [Decimal].ToUInt64(d)
	End Function
End Module



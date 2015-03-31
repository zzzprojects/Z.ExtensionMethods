
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_179

	''' <summary>
	'''     Converts the value of the specified  to the equivalent 8-bit signed integer.
	''' </summary>
	''' <param name="value">The decimal number to convert.</param>
	''' <returns>An 8-bit signed integer equivalent to .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToSByte(value As [Decimal]) As [SByte]
		Return [Decimal].ToSByte(value)
	End Function
End Module



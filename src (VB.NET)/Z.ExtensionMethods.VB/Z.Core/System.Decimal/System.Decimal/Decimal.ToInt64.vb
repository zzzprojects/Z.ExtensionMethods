
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_177

	''' <summary>
	'''     Converts the value of the specified  to the equivalent 64-bit signed integer.
	''' </summary>
	''' <param name="d">The decimal number to convert.</param>
	''' <returns>A 64-bit signed integer equivalent to the value of .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToInt64(d As [Decimal]) As Int64
		Return [Decimal].ToInt64(d)
	End Function
End Module



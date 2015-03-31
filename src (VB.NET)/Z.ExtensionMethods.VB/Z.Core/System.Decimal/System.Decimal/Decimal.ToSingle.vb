
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_180

	''' <summary>
	'''     Converts the value of the specified  to the equivalent single-precision floating-point number.
	''' </summary>
	''' <param name="d">The decimal number to convert.</param>
	''' <returns>A single-precision floating-point number equivalent to the value of .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToSingle(d As [Decimal]) As [Single]
		Return [Decimal].ToSingle(d)
	End Function
End Module



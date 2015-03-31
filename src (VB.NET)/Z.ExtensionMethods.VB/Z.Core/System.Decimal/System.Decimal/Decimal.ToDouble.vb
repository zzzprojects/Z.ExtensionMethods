
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_174

	''' <summary>
	'''     Converts the value of the specified  to the equivalent double-precision floating-point number.
	''' </summary>
	''' <param name="d">The decimal number to convert.</param>
	''' <returns>A double-precision floating-point number equivalent to .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToDouble(d As [Decimal]) As [Double]
		Return [Decimal].ToDouble(d)
	End Function
End Module



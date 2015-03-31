
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_311

	''' <summary>
	'''     Converts the specified 64-bit signed integer to a double-precision floating point number.
	''' </summary>
	''' <param name="value">The number to convert.</param>
	''' <returns>A double-precision floating point number whose value is equivalent to .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Int64BitsToDouble(value As Int64) As [Double]
		Return BitConverter.Int64BitsToDouble(value)
	End Function
End Module



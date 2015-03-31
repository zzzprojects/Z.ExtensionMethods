
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_472

	''' <summary>
	'''     Returns the absolute value of a single-precision floating-point number.
	''' </summary>
	''' <param name="value">A number that is greater than or equal to , but less than or equal to .</param>
	''' <returns>A single-precision floating-point number, x, such that 0 ? x ?.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Abs(value As [Single]) As [Single]
		Return Math.Abs(value)
	End Function
End Module



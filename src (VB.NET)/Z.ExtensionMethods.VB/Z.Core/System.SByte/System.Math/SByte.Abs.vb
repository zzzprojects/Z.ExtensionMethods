
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_466

	''' <summary>
	'''     Returns the absolute value of an 8-bit signed integer.
	''' </summary>
	''' <param name="value">A number that is greater than , but less than or equal to .</param>
	''' <returns>An 8-bit signed integer, x, such that 0 ? x ?.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Abs(value As [SByte]) As [SByte]
		Return Math.Abs(value)
	End Function
End Module



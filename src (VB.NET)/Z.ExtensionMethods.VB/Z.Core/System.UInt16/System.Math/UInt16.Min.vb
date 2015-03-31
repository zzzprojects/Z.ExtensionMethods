
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_614

	''' <summary>
	'''     Returns the smaller of two 16-bit unsigned integers.
	''' </summary>
	''' <param name="val1">The first of two 16-bit unsigned integers to compare.</param>
	''' <param name="val2">The second of two 16-bit unsigned integers to compare.</param>
	''' <returns>Parameter  or , whichever is smaller.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Min(val1 As UInt16, val2 As UInt16) As UInt16
		Return Math.Min(val1, val2)
	End Function
End Module



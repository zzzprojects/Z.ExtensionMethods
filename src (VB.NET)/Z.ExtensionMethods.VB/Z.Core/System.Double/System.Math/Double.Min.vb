
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_219

	''' <summary>
	'''     Returns the smaller of two double-precision floating-point numbers.
	''' </summary>
	''' <param name="val1">The first of two double-precision floating-point numbers to compare.</param>
	''' <param name="val2">The second of two double-precision floating-point numbers to compare.</param>
	''' <returns>Parameter  or , whichever is smaller. If , , or both  and  are equal to ,  is returned.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Min(val1 As [Double], val2 As [Double]) As [Double]
		Return Math.Min(val1, val2)
	End Function
End Module



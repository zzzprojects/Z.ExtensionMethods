
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_225

	''' <summary>
	'''     Returns the square root of a specified number.
	''' </summary>
	''' <param name="d">The number whose square root is to be found.</param>
	''' <returns>
	'''     One of the values in the following table.  parameter Return value Zero or positive The positive square root
	'''     of . Negative Equals Equals.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Sqrt(d As [Double]) As [Double]
		Return Math.Sqrt(d)
	End Function
End Module



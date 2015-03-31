
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_217

	''' <summary>
	'''     Returns the base 10 logarithm of a specified number.
	''' </summary>
	''' <param name="d">A number whose logarithm is to be found.</param>
	''' <returns>
	'''     One of the values in the following table.  parameter Return value Positive The base 10 log of ; that is, log
	'''     10. Zero Negative Equal to Equal to.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Log10(d As [Double]) As [Double]
		Return Math.Log10(d)
	End Function
End Module



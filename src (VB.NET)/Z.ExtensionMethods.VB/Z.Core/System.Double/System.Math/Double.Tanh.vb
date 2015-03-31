
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_227

	''' <summary>
	'''     Returns the hyperbolic tangent of the specified angle.
	''' </summary>
	''' <param name="value">An angle, measured in radians.</param>
	''' <returns>
	'''     The hyperbolic tangent of . If  is equal to , this method returns -1. If value is equal to , this method
	'''     returns 1. If  is equal to , this method returns .
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Tanh(value As [Double]) As [Double]
		Return Math.Tanh(value)
	End Function
End Module



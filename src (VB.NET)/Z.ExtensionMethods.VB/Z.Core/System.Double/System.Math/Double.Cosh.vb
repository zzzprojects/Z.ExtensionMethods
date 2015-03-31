
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_212

	''' <summary>
	'''     Returns the hyperbolic cosine of the specified angle.
	''' </summary>
	''' <param name="value">An angle, measured in radians.</param>
	''' <returns>The hyperbolic cosine of . If  is equal to  or ,  is returned. If  is equal to ,  is returned.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Cosh(value As [Double]) As [Double]
		Return Math.Cosh(value)
	End Function
End Module



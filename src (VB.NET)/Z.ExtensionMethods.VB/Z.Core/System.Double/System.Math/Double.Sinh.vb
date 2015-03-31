
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_224

	''' <summary>
	'''     Returns the hyperbolic sine of the specified angle.
	''' </summary>
	''' <param name="value">An angle, measured in radians.</param>
	''' <returns>The hyperbolic sine of . If  is equal to , , or , this method returns a  equal to .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Sinh(value As [Double]) As [Double]
		Return Math.Sinh(value)
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_210

	''' <summary>
	'''     Returns the smallest integral value that is greater than or equal to the specified double-precision floating-
	'''     point number.
	''' </summary>
	''' <param name="a">A double-precision floating-point number.</param>
	''' <returns>
	'''     The smallest integral value that is greater than or equal to . If  is equal to , , or , that value is
	'''     returned. Note that this method returns a  instead of an integral type.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Ceiling(a As [Double]) As [Double]
		Return Math.Ceiling(a)
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_185

	''' <summary>
	'''     Returns the smallest integral value that is greater than or equal to the specified decimal number.
	''' </summary>
	''' <param name="d">A decimal number.</param>
	''' <returns>
	'''     The smallest integral value that is greater than or equal to . Note that this method returns a  instead of an
	'''     integral type.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Ceiling(d As [Decimal]) As [Decimal]
		Return Math.Ceiling(d)
	End Function
End Module



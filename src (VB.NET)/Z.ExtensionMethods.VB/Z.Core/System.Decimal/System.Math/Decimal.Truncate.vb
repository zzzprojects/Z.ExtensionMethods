
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_191

	''' <summary>
	'''     Calculates the integral part of a specified decimal number.
	''' </summary>
	''' <param name="d">A number to truncate.</param>
	''' <returns>
	'''     The integral part of ; that is, the number that remains after any fractional digits have been discarded.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Truncate(d As [Decimal]) As [Decimal]
		Return Math.Truncate(d)
	End Function
End Module



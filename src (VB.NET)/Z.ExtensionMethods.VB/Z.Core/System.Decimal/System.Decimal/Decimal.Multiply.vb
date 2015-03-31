
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_169

	''' <summary>
	'''     Multiplies two specified  values.
	''' </summary>
	''' <param name="d1">The multiplicand.</param>
	''' <param name="d2">The multiplier.</param>
	''' <returns>The result of multiplying  and .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Multiply(d1 As [Decimal], d2 As [Decimal]) As [Decimal]
		Return [Decimal].Multiply(d1, d2)
	End Function
End Module



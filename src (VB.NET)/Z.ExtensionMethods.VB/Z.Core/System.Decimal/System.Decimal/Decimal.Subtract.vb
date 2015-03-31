
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_172

	''' <summary>
	'''     Subtracts one specified  value from another.
	''' </summary>
	''' <param name="d1">The minuend.</param>
	''' <param name="d2">The subtrahend.</param>
	''' <returns>The result of subtracting  from .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Subtract(d1 As [Decimal], d2 As [Decimal]) As [Decimal]
		Return [Decimal].Subtract(d1, d2)
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_479

	''' <summary>
	'''     Returns a value indicating whether the specified number evaluates to positive infinity.
	''' </summary>
	''' <param name="f">A single-precision floating-point number.</param>
	''' <returns>true if  evaluates to ; otherwise, false.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsPositiveInfinity(f As [Single]) As [Boolean]
		Return [Single].IsPositiveInfinity(f)
	End Function
End Module



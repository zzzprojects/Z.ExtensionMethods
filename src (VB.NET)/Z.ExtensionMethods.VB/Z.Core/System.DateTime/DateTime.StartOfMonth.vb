
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_129

	''' <summary>
	'''     A DateTime extension method that return a DateTime of the first day of the month with the time set to
	'''     "00:00:00:000". The first moment of the first day of the month.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>A DateTime of the first day of the month with the time set to "00:00:00:000".</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function StartOfMonth(this As DateTime) As DateTime
		Return New DateTime(this.Year, this.Month, 1)
	End Function
End Module



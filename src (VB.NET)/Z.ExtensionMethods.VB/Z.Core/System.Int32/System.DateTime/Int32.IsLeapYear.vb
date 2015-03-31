
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_283

	''' <summary>
	'''     Returns an indication whether the specified year is a leap year.
	''' </summary>
	''' <param name="year">A 4-digit year.</param>
	''' <returns>true if  is a leap year; otherwise, false.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsLeapYear(year As Int32) As [Boolean]
		Return DateTime.IsLeapYear(year)
	End Function
End Module



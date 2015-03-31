
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_282

	''' <summary>
	'''     Returns the number of days in the specified month and year.
	''' </summary>
	''' <param name="year">The year.</param>
	''' <param name="month">The month (a number ranging from 1 to 12).</param>
	''' <returns>
	'''     The number of days in  for the specified .For example, if  equals 2 for February, the return value is 28 or
	'''     29 depending upon whether  is a leap year.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function DaysInMonth(year As Int32, month As Int32) As Int32
		Return DateTime.DaysInMonth(year, month)
	End Function
End Module



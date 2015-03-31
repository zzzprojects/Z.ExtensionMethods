
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_117

	''' <summary>
	'''     A DateTime extension method that query if 'date' is date equal.
	''' </summary>
	''' <param name="date">The date to act on.</param>
	''' <param name="dateToCompare">Date/Time of the date to compare.</param>
	''' <returns>true if date equal, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsDateEqual([date] As DateTime, dateToCompare As DateTime) As Boolean
		Return ([date].[Date] = dateToCompare.[Date])
	End Function
End Module



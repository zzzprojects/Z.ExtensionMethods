
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_122

	''' <summary>
	'''     A DateTime extension method that query if 'time' is time equal.
	''' </summary>
	''' <param name="time">The time to act on.</param>
	''' <param name="timeToCompare">Date/Time of the time to compare.</param>
	''' <returns>true if time equal, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsTimeEqual(time As DateTime, timeToCompare As DateTime) As Boolean
		Return (time.TimeOfDay = timeToCompare.TimeOfDay)
	End Function
End Module



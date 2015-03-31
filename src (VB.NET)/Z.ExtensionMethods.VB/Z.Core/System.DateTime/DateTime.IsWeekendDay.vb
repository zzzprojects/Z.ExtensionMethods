
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_125

	''' <summary>
	'''     A DateTime extension method that query if '@this' is a weekend day.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true if '@this' is a weekend day, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsWeekendDay(this As DateTime) As Boolean
		Return (this.DayOfWeek = DayOfWeek.Saturday OrElse this.DayOfWeek = DayOfWeek.Sunday)
	End Function
End Module



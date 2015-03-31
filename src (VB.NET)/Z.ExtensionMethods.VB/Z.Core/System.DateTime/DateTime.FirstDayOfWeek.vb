
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_115

	''' <summary>
	'''     A DateTime extension method that first day of week.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>A DateTime.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FirstDayOfWeek(this As DateTime) As DateTime
		Return New DateTime(this.Year, this.Month, this.Day).AddDays(-CInt(this.DayOfWeek))
	End Function
End Module



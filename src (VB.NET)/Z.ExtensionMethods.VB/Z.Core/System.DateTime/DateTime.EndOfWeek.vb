
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_113

	''' <summary>
	'''     A System.DateTime extension method that ends of week.
	''' </summary>
	''' <param name="dt">Date/Time of the dt.</param>
	''' <param name="startDayOfWeek">(Optional) the start day of week.</param>
	''' <returns>A DateTime.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function EndOfWeek(dt As DateTime, Optional startDayOfWeek As DayOfWeek = DayOfWeek.Sunday) As DateTime
		Dim [end] As DateTime = dt
		Dim endDayOfWeek As DayOfWeek = startDayOfWeek - 1
		If endDayOfWeek < 0 Then
			endDayOfWeek = DayOfWeek.Saturday
		End If

		If [end].DayOfWeek <> endDayOfWeek Then
			If endDayOfWeek < [end].DayOfWeek Then
				[end] = [end].AddDays(7 - ([end].DayOfWeek - endDayOfWeek))
			Else
				[end] = [end].AddDays(endDayOfWeek - [end].DayOfWeek)
			End If
		End If

		Return New DateTime([end].Year, [end].Month, [end].Day, 23, 59, 59, _
			999)
	End Function
End Module



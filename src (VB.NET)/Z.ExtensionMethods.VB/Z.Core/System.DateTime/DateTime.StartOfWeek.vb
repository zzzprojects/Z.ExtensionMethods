
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_130

	''' <summary>
	'''     A DateTime extension method that starts of week.
	''' </summary>
	''' <param name="dt">The dt to act on.</param>
	''' <param name="startDayOfWeek">(Optional) the start day of week.</param>
	''' <returns>A DateTime.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function StartOfWeek(dt As DateTime, Optional startDayOfWeek As DayOfWeek = DayOfWeek.Sunday) As DateTime
		Dim start = New DateTime(dt.Year, dt.Month, dt.Day)

		If start.DayOfWeek <> startDayOfWeek Then
			Dim d As Integer = startDayOfWeek - start.DayOfWeek
			If startDayOfWeek <= start.DayOfWeek Then
				Return start.AddDays(d)
			End If
			Return start.AddDays(-7 + d)
		End If

		Return start
	End Function
End Module



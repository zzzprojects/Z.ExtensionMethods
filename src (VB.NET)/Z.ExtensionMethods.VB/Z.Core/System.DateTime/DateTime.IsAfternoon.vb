
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_116

	''' <summary>
	'''     A DateTime extension method that query if '@this' is afternoon.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true if afternoon, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsAfternoon(this As DateTime) As Boolean
		Return this.TimeOfDay >= New DateTime(2000, 1, 1, 12, 0, 0).TimeOfDay
	End Function
End Module



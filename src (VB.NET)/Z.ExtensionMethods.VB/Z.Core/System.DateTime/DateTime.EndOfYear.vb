
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_114

	''' <summary>
	'''     A DateTime extension method that return a DateTime of the last day of the year with the time set to
	'''     "23:59:59:999". The last moment of the last day of the year.  Use "DateTime2" column type in sql to keep the
	'''     precision.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>A DateTime of the last day of the year with the time set to "23:59:59:999".</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function EndOfYear(this As DateTime) As DateTime
		Return New DateTime(this.Year, 1, 1).AddYears(1).Subtract(New TimeSpan(0, 0, 0, 0, 1))
	End Function
End Module



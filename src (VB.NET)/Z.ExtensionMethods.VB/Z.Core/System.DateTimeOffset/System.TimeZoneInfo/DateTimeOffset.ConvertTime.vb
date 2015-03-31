
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_160

	''' <summary>
	'''     Converts a time to the time in a particular time zone.
	''' </summary>
	''' <param name="dateTimeOffset">The date and time to convert.</param>
	''' <param name="destinationTimeZone">The time zone to convert  to.</param>
	''' <returns>The date and time in the destination time zone.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ConvertTime(dateTimeOffset As DateTimeOffset, destinationTimeZone As TimeZoneInfo) As DateTimeOffset
		Return TimeZoneInfo.ConvertTime(dateTimeOffset, destinationTimeZone)
	End Function
End Module



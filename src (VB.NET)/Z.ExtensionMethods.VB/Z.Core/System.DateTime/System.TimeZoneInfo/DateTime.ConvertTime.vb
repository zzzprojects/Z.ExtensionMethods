
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_136

	''' <summary>
	'''     Converts a time to the time in a particular time zone.
	''' </summary>
	''' <param name="dateTime">The date and time to convert.</param>
	''' <param name="destinationTimeZone">The time zone to convert  to.</param>
	''' <returns>The date and time in the destination time zone.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ConvertTime(dateTime As DateTime, destinationTimeZone As TimeZoneInfo) As DateTime
		Return TimeZoneInfo.ConvertTime(dateTime, destinationTimeZone)
	End Function

	''' <summary>
	'''     Converts a time from one time zone to another.
	''' </summary>
	''' <param name="dateTime">The date and time to convert.</param>
	''' <param name="sourceTimeZone">The time zone of .</param>
	''' <param name="destinationTimeZone">The time zone to convert  to.</param>
	''' <returns>
	'''     The date and time in the destination time zone that corresponds to the  parameter in the source time zone.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ConvertTime(dateTime As DateTime, sourceTimeZone As TimeZoneInfo, destinationTimeZone As TimeZoneInfo) As DateTime
		Return TimeZoneInfo.ConvertTime(dateTime, sourceTimeZone, destinationTimeZone)
	End Function
End Module



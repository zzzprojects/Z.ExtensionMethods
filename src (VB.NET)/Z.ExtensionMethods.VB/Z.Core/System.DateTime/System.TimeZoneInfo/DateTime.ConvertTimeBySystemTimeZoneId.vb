
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_137

	''' <summary>
	'''     Converts a time to the time in another time zone based on the time zone&#39;s identifier.
	''' </summary>
	''' <param name="dateTime">The date and time to convert.</param>
	''' <param name="destinationTimeZoneId">The identifier of the destination time zone.</param>
	''' <returns>The date and time in the destination time zone.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ConvertTimeBySystemTimeZoneId(dateTime As DateTime, destinationTimeZoneId As [String]) As DateTime
		Return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, destinationTimeZoneId)
	End Function

	''' <summary>
	'''     Converts a time from one time zone to another based on time zone identifiers.
	''' </summary>
	''' <param name="dateTime">The date and time to convert.</param>
	''' <param name="sourceTimeZoneId">The identifier of the source time zone.</param>
	''' <param name="destinationTimeZoneId">The identifier of the destination time zone.</param>
	''' <returns>
	'''     The date and time in the destination time zone that corresponds to the  parameter in the source time zone.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ConvertTimeBySystemTimeZoneId(dateTime As DateTime, sourceTimeZoneId As [String], destinationTimeZoneId As [String]) As DateTime
		Return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTime, sourceTimeZoneId, destinationTimeZoneId)
	End Function
End Module



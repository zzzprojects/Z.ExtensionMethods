
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_161

	''' <summary>
	'''     Converts a time to the time in another time zone based on the time zone&#39;s identifier.
	''' </summary>
	''' <param name="dateTimeOffset">The date and time to convert.</param>
	''' <param name="destinationTimeZoneId">The identifier of the destination time zone.</param>
	''' <returns>The date and time in the destination time zone.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ConvertTimeBySystemTimeZoneId(dateTimeOffset As DateTimeOffset, destinationTimeZoneId As [String]) As DateTimeOffset
		Return TimeZoneInfo.ConvertTimeBySystemTimeZoneId(dateTimeOffset, destinationTimeZoneId)
	End Function
End Module



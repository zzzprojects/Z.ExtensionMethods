
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_139

	''' <summary>
	'''     Converts the current date and time to Coordinated Universal Time (UTC).
	''' </summary>
	''' <param name="dateTime">The date and time to convert.</param>
	''' <returns>
	'''     The Coordinated Universal Time (UTC) that corresponds to the  parameter. The  value&#39;s  property is always
	'''     set to .
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ConvertTimeToUtc(dateTime As DateTime) As DateTime
		Return TimeZoneInfo.ConvertTimeToUtc(dateTime)
	End Function

	''' <summary>
	'''     Converts the time in a specified time zone to Coordinated Universal Time (UTC).
	''' </summary>
	''' <param name="dateTime">The date and time to convert.</param>
	''' <param name="sourceTimeZone">The time zone of .</param>
	''' <returns>
	'''     The Coordinated Universal Time (UTC) that corresponds to the  parameter. The  object&#39;s  property is
	'''     always set to .
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ConvertTimeToUtc(dateTime As DateTime, sourceTimeZone As TimeZoneInfo) As DateTime
		Return TimeZoneInfo.ConvertTimeToUtc(dateTime, sourceTimeZone)
	End Function
End Module



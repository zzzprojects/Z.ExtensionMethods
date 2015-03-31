
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_138

	''' <summary>
	'''     Converts a Coordinated Universal Time (UTC) to the time in a specified time zone.
	''' </summary>
	''' <param name="dateTime">The Coordinated Universal Time (UTC).</param>
	''' <param name="destinationTimeZone">The time zone to convert  to.</param>
	''' <returns>
	'''     The date and time in the destination time zone. Its  property is  if  is ; otherwise, its  property is .
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ConvertTimeFromUtc(dateTime As DateTime, destinationTimeZone As TimeZoneInfo) As DateTime
		Return TimeZoneInfo.ConvertTimeFromUtc(dateTime, destinationTimeZone)
	End Function
End Module



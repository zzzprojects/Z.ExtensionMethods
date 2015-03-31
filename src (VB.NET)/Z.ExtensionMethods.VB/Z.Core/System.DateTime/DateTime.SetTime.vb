
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_127

	''' <summary>
	'''     Sets the time of the current date with minute precision.
	''' </summary>
	''' <param name="current">The current date.</param>
	''' <param name="hour">The hour.</param>
	''' <returns>A DateTime.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function SetTime(current As DateTime, hour As Integer) As DateTime
		Return SetTime(current, hour, 0, 0, 0)
	End Function

	''' <summary>
	'''     Sets the time of the current date with minute precision.
	''' </summary>
	''' <param name="current">The current date.</param>
	''' <param name="hour">The hour.</param>
	''' <param name="minute">The minute.</param>
	''' <returns>A DateTime.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function SetTime(current As DateTime, hour As Integer, minute As Integer) As DateTime
		Return SetTime(current, hour, minute, 0, 0)
	End Function

	''' <summary>
	'''     Sets the time of the current date with second precision.
	''' </summary>
	''' <param name="current">The current date.</param>
	''' <param name="hour">The hour.</param>
	''' <param name="minute">The minute.</param>
	''' <param name="second">The second.</param>
	''' <returns>A DateTime.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function SetTime(current As DateTime, hour As Integer, minute As Integer, second As Integer) As DateTime
		Return SetTime(current, hour, minute, second, 0)
	End Function

	''' <summary>
	'''     Sets the time of the current date with millisecond precision.
	''' </summary>
	''' <param name="current">The current date.</param>
	''' <param name="hour">The hour.</param>
	''' <param name="minute">The minute.</param>
	''' <param name="second">The second.</param>
	''' <param name="millisecond">The millisecond.</param>
	''' <returns>A DateTime.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function SetTime(current As DateTime, hour As Integer, minute As Integer, second As Integer, millisecond As Integer) As DateTime
		Return New DateTime(current.Year, current.Month, current.Day, hour, minute, second, _
			millisecond)
	End Function
End Module



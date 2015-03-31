
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_323

	''' <summary>
	'''     Returns a  that represents a specified time, where the specification is in units of ticks.
	''' </summary>
	''' <param name="value">A number of ticks that represent a time.</param>
	''' <returns>An object that represents .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FromTicks(value As Int64) As TimeSpan
		Return TimeSpan.FromTicks(value)
	End Function
End Module



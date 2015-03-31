
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_313

	''' <summary>
	'''     Converts the specified Windows file time to an equivalent local time.
	''' </summary>
	''' <param name="fileTime">A Windows file time expressed in ticks.</param>
	''' <returns>
	'''     An object that represents the local time equivalent of the date and time represented by the  parameter.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FromFileTime(fileTime As Int64) As DateTime
		Return DateTime.FromFileTime(fileTime)
	End Function
End Module



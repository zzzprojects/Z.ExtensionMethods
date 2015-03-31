
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_200

	''' <summary>
	'''     Returns a  equivalent to the specified OLE Automation Date.
	''' </summary>
	''' <param name="d">An OLE Automation Date value.</param>
	''' <returns>An object that represents the same date and time as .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FromOADate(d As [Double]) As DateTime
		Return DateTime.FromOADate(d)
	End Function
End Module



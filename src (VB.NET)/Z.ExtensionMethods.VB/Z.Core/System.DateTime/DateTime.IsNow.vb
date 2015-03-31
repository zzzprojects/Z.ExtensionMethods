
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_120

	''' <summary>
	'''     A DateTime extension method that query if '@this' is now.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true if now, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsNow(this As DateTime) As Boolean
		Return this = DateTime.Now
	End Function
End Module



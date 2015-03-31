
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_585

	''' <summary>
	'''     A T extension method that query if '@this' is null.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true if null, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsNull(this As [String]) As Boolean
		Return this Is Nothing
	End Function
End Module



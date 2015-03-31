
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_134

	''' <summary>
	'''     A DateTime extension method that yesterdays the given this.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>Yesterday date at same time.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Yesterday(this As DateTime) As DateTime
		Return this.AddDays(-1)
	End Function
End Module



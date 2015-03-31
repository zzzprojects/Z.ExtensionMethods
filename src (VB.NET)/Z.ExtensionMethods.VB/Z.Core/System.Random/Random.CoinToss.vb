
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_464

	''' <summary>
	'''     A Random extension method that flip a coin toss.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true 50% of time, otherwise false.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function CoinToss(this As Random) As Boolean
		Return this.[Next](2) = 0
	End Function
End Module



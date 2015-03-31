
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_164

	''' <summary>
	'''     A T extension method that check if the value is between inclusively the minValue and maxValue.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="minValue">The minimum value.</param>
	''' <param name="maxValue">The maximum value.</param>
	''' <returns>true if the value is between inclusively the minValue and maxValue, otherwise false.</returns>
	''' ###
	''' <typeparam name="T">Generic type parameter.</typeparam>
	<System.Runtime.CompilerServices.Extension> _
	Public Function InRange(this As DateTimeOffset, minValue As DateTimeOffset, maxValue As DateTimeOffset) As Boolean
		Return this.CompareTo(minValue) >= 0 AndAlso this.CompareTo(maxValue) <= 0
	End Function
End Module



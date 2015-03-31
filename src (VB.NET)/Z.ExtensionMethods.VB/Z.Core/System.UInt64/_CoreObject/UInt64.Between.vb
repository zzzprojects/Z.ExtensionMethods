
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_627

	''' <summary>
	'''     A T extension method that check if the value is between (exclusif) the minValue and maxValue.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="minValue">The minimum value.</param>
	''' <param name="maxValue">The maximum value.</param>
	''' <returns>true if the value is between the minValue and maxValue, otherwise false.</returns>
	''' ###
	''' <typeparam name="T">Generic type parameter.</typeparam>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Between(this As UInt64, minValue As UInt64, maxValue As UInt64) As Boolean
		Return minValue.CompareTo(this) = -1 AndAlso this.CompareTo(maxValue) = -1
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_465

	''' <summary>
	'''     A Random extension method that return a random value from the specified values.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="values">A variable-length parameters list containing arguments.</param>
	''' <returns>One of the specified value.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function OneOf(Of T)(this As Random, ParamArray values As T()) As T
		Return values(this.[Next](values.Length))
	End Function
End Module



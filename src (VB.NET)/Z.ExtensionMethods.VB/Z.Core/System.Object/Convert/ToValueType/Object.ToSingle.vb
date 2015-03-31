
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_432

	''' <summary>
	'''     An object extension method that converts the @this to a single.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a float.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToSingle(this As Object) As Single
		Return Convert.ToSingle(this)
	End Function
End Module



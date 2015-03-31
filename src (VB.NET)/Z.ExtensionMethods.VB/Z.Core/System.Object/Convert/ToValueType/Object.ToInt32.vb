
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_380

	''' <summary>
	'''     An object extension method that converts the @this to an int 32.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as an int.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToInt32(this As Object) As Integer
		Return Convert.ToInt32(this)
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_434

	''' <summary>
	'''     An object extension method that convert this object into a string representation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>A string that represents this object.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToString(this As Object) As String
		Return Convert.ToString(this)
	End Function
End Module



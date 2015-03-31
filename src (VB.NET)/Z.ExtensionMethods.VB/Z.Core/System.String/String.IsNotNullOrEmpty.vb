
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_507

	''' <summary>
	'''     A string extension method that queries if '@this' is not (null or empty).
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true if '@this' is not (null or empty), false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsNotNullOrEmpty(this As String) As Boolean
		Return Not String.IsNullOrEmpty(this)
	End Function
End Module



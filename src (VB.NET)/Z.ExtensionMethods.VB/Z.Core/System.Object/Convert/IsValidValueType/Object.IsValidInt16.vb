
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_347

	''' <summary>
	'''     An object extension method that query if '@this' is valid short.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true if valid short, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsValidInt16(this As Object) As Boolean
		If this Is Nothing Then
			Return True
		End If

		Dim result As Short
		Return Short.TryParse(this.ToString(), result)
	End Function
End Module



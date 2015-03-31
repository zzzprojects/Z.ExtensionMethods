
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_453

	''' <summary>
	'''     An object extension method that converts the @this to string or return an empty string if the value is null.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a string or empty if the value is null.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToStringSafe(this As Object) As String
		Return If(this Is Nothing, "", this.ToString())
	End Function
End Module



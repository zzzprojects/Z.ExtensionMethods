
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_533

	''' <summary>
	'''     A string extension method that converts the @this to an enum.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a T.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToEnum(Of T)(this As String) As T
		Dim enumType As Type = GetType(T)
		Return DirectCast([Enum].Parse(enumType, this), T)
	End Function
End Module



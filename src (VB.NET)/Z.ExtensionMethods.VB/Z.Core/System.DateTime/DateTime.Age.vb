
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_109

	''' <summary>
	'''     A DateTime extension method that ages the given this.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>An int.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Age(this As DateTime) As Integer
		If DateTime.Today.Month < this.Month OrElse DateTime.Today.Month = this.Month AndAlso DateTime.Today.Day < this.Day Then
			Return DateTime.Today.Year - this.Year - 1
		End If
		Return DateTime.Today.Year - this.Year
	End Function
End Module



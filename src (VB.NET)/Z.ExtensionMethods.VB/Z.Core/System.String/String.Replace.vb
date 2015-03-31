
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_521

	''' <summary>A string extension method that replaces.</summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="startIndex">The start index.</param>
	''' <param name="length">The length.</param>
	''' <param name="value">The value.</param>
	''' <returns>A string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Replace(this As String, startIndex As Integer, length As Integer, value As String) As String
		this = this.Remove(startIndex, length).Insert(startIndex, value)

		Return this
	End Function
End Module



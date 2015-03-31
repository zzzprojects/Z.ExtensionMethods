
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_825

	''' <summary>A T extension method that gets property or field.</summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="name">The name.</param>
	''' <returns>The property or field.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetPropertyOrField(Of T)(this As T, name As String) As MemberInfo
		Dim [property] As PropertyInfo = this.GetProperty(name)
		If [property] IsNot Nothing Then
			Return [property]
		End If

		Dim field As FieldInfo = this.GetField(name)
		If field IsNot Nothing Then
			Return field
		End If

		Return Nothing
	End Function
End Module



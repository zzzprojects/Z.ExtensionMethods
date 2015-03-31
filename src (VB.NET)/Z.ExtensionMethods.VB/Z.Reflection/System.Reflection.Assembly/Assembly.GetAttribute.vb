
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_837

	''' <summary>
	'''     An Assembly extension method that gets an attribute.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The attribute.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetAttribute(Of T As Attribute)(this As Assembly) As T
		Dim configAttributes As Object() = Attribute.GetCustomAttributes(this, GetType(T), False)

		If configAttributes IsNot Nothing AndAlso configAttributes.Length > 0 Then
			Return DirectCast(configAttributes(0), T)
		End If

		Return Nothing
	End Function
End Module



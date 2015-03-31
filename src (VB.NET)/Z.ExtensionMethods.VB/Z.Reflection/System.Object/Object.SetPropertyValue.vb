
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_830

	''' <summary>
	'''     A T extension method that sets property value.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="propertyName">Name of the property.</param>
	''' <param name="value">The value.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub SetPropertyValue(Of T)(this As T, propertyName As String, value As Object)
		Dim type As Type = this.[GetType]()
		Dim [property] As PropertyInfo = type.GetProperty(propertyName, BindingFlags.[Public] Or BindingFlags.NonPublic Or BindingFlags.Instance Or BindingFlags.[Static])
		[property].SetValue(this, value, Nothing)
	End Sub
End Module



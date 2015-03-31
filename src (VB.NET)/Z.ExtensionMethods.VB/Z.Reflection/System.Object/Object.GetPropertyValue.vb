
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_826

	''' <summary>
	'''     A T extension method that gets property value.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="propertyName">Name of the property.</param>
	''' <returns>The property value.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetPropertyValue(Of T)(this As T, propertyName As String) As Object
		Dim type As Type = this.[GetType]()
		Dim [property] As PropertyInfo = type.GetProperty(propertyName, BindingFlags.[Public] Or BindingFlags.NonPublic Or BindingFlags.Instance Or BindingFlags.[Static])

		Return [property].GetValue(this, Nothing)
	End Function
End Module



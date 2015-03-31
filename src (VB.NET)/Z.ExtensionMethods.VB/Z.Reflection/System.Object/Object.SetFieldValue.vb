
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_829

	''' <summary>
	'''     A T extension method that sets field value.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="fieldName">Name of the field.</param>
	''' <param name="value">The value.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub SetFieldValue(Of T)(this As T, fieldName As String, value As Object)
		Dim type As Type = this.[GetType]()
		Dim field As FieldInfo = type.GetField(fieldName, BindingFlags.[Public] Or BindingFlags.NonPublic Or BindingFlags.Instance Or BindingFlags.[Static])
		field.SetValue(this, value)
	End Sub
End Module



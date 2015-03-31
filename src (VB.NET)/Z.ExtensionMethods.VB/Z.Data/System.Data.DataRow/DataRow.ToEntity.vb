
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data
Imports System.Reflection

Public Module Extensions_665

	''' <summary>
	'''     A DataRow extension method that converts the @this to the entities.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a T.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToEntity(Of T As New)(this As DataRow) As T
		Dim type As Type = GetType(T)
		Dim properties As PropertyInfo() = type.GetProperties(BindingFlags.[Public] Or BindingFlags.Instance)
		Dim fields As FieldInfo() = type.GetFields(BindingFlags.[Public] Or BindingFlags.Instance)

		Dim entity = New T()

		For Each [property] As PropertyInfo In properties
			If this.Table.Columns.Contains([property].Name) Then
				Dim valueType As Type = [property].PropertyType
				[property].SetValue(entity, this([property].Name).[To](valueType), Nothing)
			End If
		Next

		For Each field As FieldInfo In fields
			If this.Table.Columns.Contains(field.Name) Then
				Dim valueType As Type = field.FieldType
				field.SetValue(entity, this(field.Name).[To](valueType))
			End If
		Next

		Return entity
	End Function
End Module



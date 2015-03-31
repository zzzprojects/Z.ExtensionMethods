
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data
Imports System.Reflection

Public Module Extensions_635

	''' <summary>
	'''     A T[] extension method that converts the @this to a data table.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a DataTable.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToDataTable(Of T)(this As T()) As DataTable
		Dim type As Type = GetType(T)

		Dim properties As PropertyInfo() = type.GetProperties(BindingFlags.[Public] Or BindingFlags.Instance)
		Dim fields As FieldInfo() = type.GetFields(BindingFlags.[Public] Or BindingFlags.Instance)

		Dim dt = New DataTable()

		For Each [property] As PropertyInfo In properties
			dt.Columns.Add([property].Name, [property].PropertyType)
		Next

		For Each field As FieldInfo In fields
			dt.Columns.Add(field.Name, field.FieldType)
		Next

		For Each item As T In this
			Dim dr As DataRow = dt.NewRow()

			For Each [property] As PropertyInfo In properties
				dr([property].Name) = [property].GetValue(item, Nothing)
			Next

			For Each field As FieldInfo In fields
				dr(field.Name) = field.GetValue(item)
			Next

			dt.Rows.Add(dr)
		Next

		Return dt
	End Function
End Module



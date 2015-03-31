
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data

Public Module Extensions_671

	''' <summary>
	'''     An IDataReader extension method that query if '@this' contains column.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="columnIndex">Zero-based index of the column.</param>
	''' <returns>true if it succeeds, false if it fails.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ContainsColumn(this As IDataReader, columnIndex As Integer) As Boolean
		Try
			' Check if FieldCount is implemented first
			Return this.FieldCount > columnIndex
		Catch generatedExceptionName As Exception
			Try
				Return this(columnIndex) IsNot Nothing
            Catch
                Return False
			End Try
		End Try
	End Function

	''' <summary>
	'''     An IDataReader extension method that query if '@this' contains column.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="columnName">Name of the column.</param>
	''' <returns>true if it succeeds, false if it fails.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ContainsColumn(this As IDataReader, columnName As String) As Boolean
		Try
			' Check if GetOrdinal is implemented first
			Return this.GetOrdinal(columnName) <> -1
		Catch generatedExceptionName As Exception
			Try
				Return this(columnName) IsNot Nothing
            Catch
                Return False
			End Try
		End Try
	End Function
End Module



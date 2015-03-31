
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data

Public Module Extensions_674

	''' <summary>
	'''     An IDataReader extension method that gets value as.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="index">Zero-based index of the.</param>
	''' <returns>The value as.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetValueAs(Of T)(this As IDataReader, index As Integer) As T
		Return DirectCast(this.GetValue(index), T)
	End Function

	''' <summary>
	'''     An IDataReader extension method that gets value as.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="columnName">Name of the column.</param>
	''' <returns>The value as.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetValueAs(Of T)(this As IDataReader, columnName As String) As T
		Return DirectCast(this.GetValue(this.GetOrdinal(columnName)), T)
	End Function
End Module



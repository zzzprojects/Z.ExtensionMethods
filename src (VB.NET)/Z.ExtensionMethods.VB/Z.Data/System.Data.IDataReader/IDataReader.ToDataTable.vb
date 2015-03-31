
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data

Public Module Extensions_679

	''' <summary>
	'''     An IDataReader extension method that converts the @this to a data table.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a DataTable.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToDataTable(this As IDataReader) As DataTable
		Dim dt = New DataTable()
		dt.Load(this)
		Return dt
	End Function
End Module



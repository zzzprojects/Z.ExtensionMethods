
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data
Imports System.Data.SqlClient

Public Module Extensions_690

	''' <summary>
	'''     Executes the query, and returns the first result set as DataTable.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>A DataTable that is equivalent to the first result set.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteDataTable(this As SqlCommand) As DataTable
		Dim dt = New DataTable()
		Using dataAdapter = New SqlDataAdapter(this)
			dataAdapter.Fill(dt)
		End Using

		Return dt
	End Function
End Module



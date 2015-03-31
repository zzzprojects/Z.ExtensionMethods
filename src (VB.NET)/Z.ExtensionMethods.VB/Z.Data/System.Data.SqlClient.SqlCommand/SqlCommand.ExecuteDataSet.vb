
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data
Imports System.Data.SqlClient

Public Module Extensions_689

	''' <summary>
	'''     Executes the query, and returns the result set as DataSet.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>A DataSet that is equivalent to the result set.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteDataSet(this As SqlCommand) As DataSet
		Dim ds = New DataSet()
		Using dataAdapter = New SqlDataAdapter(this)
			dataAdapter.Fill(ds)
		End Using

		Return ds
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data

Public Module Extensions_667

	''' <summary>
	'''     A DataTable extension method that return the first row.
	''' </summary>
	''' <param name="this">The table to act on.</param>
	''' <returns>The first row of the table.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FirstRow(this As DataTable) As DataRow
		Return this.Rows(0)
	End Function
End Module



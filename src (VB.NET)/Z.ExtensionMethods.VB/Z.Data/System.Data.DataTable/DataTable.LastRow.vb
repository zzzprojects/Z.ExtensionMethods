
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data

Public Module Extensions_668

	''' <summary>A DataTable extension method that last row.</summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>A DataRow.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function LastRow(this As DataTable) As DataRow
		Return this.Rows(this.Rows.Count - 1)
	End Function
End Module



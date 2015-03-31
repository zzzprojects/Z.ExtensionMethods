
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data

Public Module Extensions_664

	''' <summary>
	'''     A DataColumnCollection extension method that adds a range to 'columns'.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="columns">A variable-length parameters list containing columns.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub AddRange(this As DataColumnCollection, ParamArray columns As String())
		For Each column As String In columns
			this.Add(column)
		Next
	End Sub
End Module



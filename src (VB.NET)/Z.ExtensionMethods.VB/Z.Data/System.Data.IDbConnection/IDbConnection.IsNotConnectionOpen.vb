
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data
Imports System.Data.Common

Public Module Extensions_686

	''' <summary>A DbConnection extension method that queries if a not connection is open.</summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true if a not connection is open, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsNotConnectionOpen(this As DbConnection) As Boolean
		Return this.State <> ConnectionState.Open
	End Function
End Module



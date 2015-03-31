
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data

Public Module Extensions_663

	''' <summary>
	'''     A ConnectionState extension method that not in.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="values">A variable-length parameters list containing values.</param>
	''' <returns>true if it succeeds, false if it fails.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function NotIn(this As ConnectionState, ParamArray values As ConnectionState()) As Boolean
		Return values.IndexOf(this) = -1
	End Function
End Module



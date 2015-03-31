
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Linq
Imports System.Text.RegularExpressions

Public Module Extensions_596

	''' <summary>
	'''     A string extension method that extracts all Int64 from the string.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>All extracted Int64.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExtractManyInt64(this As String) As Long()
		Return Regex.Matches(this, "[-]?\d+").Cast(Of Match)().[Select](Function(x) Convert.ToInt64(x.Value)).ToArray()
	End Function
End Module



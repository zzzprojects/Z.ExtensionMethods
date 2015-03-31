
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Linq
Imports System.Text.RegularExpressions

Public Module Extensions_598

	''' <summary>
	'''     A string extension method that extracts all UInt32 from the string.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>All extracted UInt32.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExtractManyUInt32(this As String) As UInteger()
		Return Regex.Matches(this, "\d+").Cast(Of Match)().[Select](Function(x) Convert.ToUInt32(x.Value)).ToArray()
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Globalization

Public Module Extensions_86

	''' <summary>
	'''     Categorizes a specified Unicode character into a group identified by one of the  values.
	''' </summary>
	''' <param name="c">The Unicode character to categorize.</param>
	''' <returns>A  value that identifies the group that contains .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetUnicodeCategory(c As [Char]) As UnicodeCategory
		Return [Char].GetUnicodeCategory(c)
	End Function
End Module



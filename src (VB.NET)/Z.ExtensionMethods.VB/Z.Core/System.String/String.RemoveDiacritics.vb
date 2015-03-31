
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Globalization
Imports System.Text

Public Module Extensions_516

	''' <summary>
	'''     A string extension method that removes the diacritics character from the strings.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The string without diacritics character.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function RemoveDiacritics(this As String) As String
		Dim normalizedString As String = this.Normalize(NormalizationForm.FormD)
		Dim sb = New StringBuilder()

		For Each t As Char In normalizedString
			Dim uc As UnicodeCategory = CharUnicodeInfo.GetUnicodeCategory(t)
			If uc <> UnicodeCategory.NonSpacingMark Then
				sb.Append(t)
			End If
		Next

		Return sb.ToString().Normalize(NormalizationForm.FormC)
	End Function
End Module



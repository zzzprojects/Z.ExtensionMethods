
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Linq

Public Module Extensions_83

	''' <summary>
	'''     Enumerates from @this to toCharacter.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="toCharacter">to character.</param>
	''' <returns>An enumerator that allows foreach to be used to process @this to toCharacter.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function [To](this As Char, toCharacter As Char) As IEnumerable(Of Char)
		Dim reverseRequired As Boolean = (this > toCharacter)

		Dim first As Char = If(reverseRequired, toCharacter, this)
		Dim last As Char = If(reverseRequired, this, toCharacter)

        Dim result As IEnumerable(Of Char) = Enumerable.Range(Asc(first), Asc(last) - Asc(first) + 1).Select(Function(charCode) ChrW(charCode))

		If reverseRequired Then
            result = result.Reverse()
		End If


		Return result
	End Function
End Module



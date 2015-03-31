
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Drawing

Public Module Extensions_746

	''' <summary>
	'''     Translates the specified  structure to an HTML string color representation.
	''' </summary>
	''' <param name="c">The  structure to translate.</param>
	''' <returns>The string that represents the HTML color.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToHtml(c As Color) As [String]
		Return ColorTranslator.ToHtml(c)
	End Function
End Module



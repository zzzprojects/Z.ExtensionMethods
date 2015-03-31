
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Drawing

Public Module Extensions_747

	''' <summary>
	'''     Translates the specified  structure to an OLE color.
	''' </summary>
	''' <param name="c">The  structure to translate.</param>
	''' <returns>The OLE color value.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToOle(c As Color) As Int32
		Return ColorTranslator.ToOle(c)
	End Function
End Module



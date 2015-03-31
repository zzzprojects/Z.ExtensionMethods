
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Drawing

Public Module Extensions_748

	''' <summary>
	'''     Translates the specified  structure to a Windows color.
	''' </summary>
	''' <param name="c">The  structure to translate.</param>
	''' <returns>The Windows color value.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToWin32(c As Color) As Int32
		Return ColorTranslator.ToWin32(c)
	End Function
End Module



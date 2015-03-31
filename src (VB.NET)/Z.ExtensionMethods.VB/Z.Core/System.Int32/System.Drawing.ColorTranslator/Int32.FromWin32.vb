
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Drawing

Public Module Extensions_286

	''' <summary>
	'''     Translates a Windows color value to a GDI+  structure.
	''' </summary>
	''' <param name="win32Color">The Windows color to translate.</param>
	''' <returns>The  structure that represents the translated Windows color.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FromWin32(win32Color As Int32) As Color
		Return ColorTranslator.FromWin32(win32Color)
	End Function
End Module



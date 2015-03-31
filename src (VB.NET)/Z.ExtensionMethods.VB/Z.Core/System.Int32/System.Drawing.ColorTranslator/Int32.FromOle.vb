
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Drawing

Public Module Extensions_285

	''' <summary>
	'''     Translates an OLE color value to a GDI+  structure.
	''' </summary>
	''' <param name="oleColor">The OLE color to translate.</param>
	''' <returns>The  structure that represents the translated OLE color.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FromOle(oleColor As Int32) As Color
		Return ColorTranslator.FromOle(oleColor)
	End Function
End Module



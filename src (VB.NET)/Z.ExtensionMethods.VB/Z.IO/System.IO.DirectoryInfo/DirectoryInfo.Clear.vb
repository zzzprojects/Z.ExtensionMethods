
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO

Public Module Extensions_756

	''' <summary>
	'''     A DirectoryInfo extension method that clears all files and directories in this directory.
	''' </summary>
	''' <param name="obj">The obj to act on.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Clear(obj As DirectoryInfo)
        Array.ForEach(obj.GetFiles(), Sub(x) x.Delete())
        Array.ForEach(obj.GetDirectories(), Sub(x) x.Delete(True))
	End Sub
End Module



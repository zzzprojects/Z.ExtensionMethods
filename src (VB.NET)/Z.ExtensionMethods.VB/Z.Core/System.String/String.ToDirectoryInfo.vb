
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO

Public Module Extensions_532

	''' <summary>
	'''     A string extension method that converts the @this to a directory information.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a DirectoryInfo.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToDirectoryInfo(this As String) As DirectoryInfo
		Return New DirectoryInfo(this)
	End Function
End Module



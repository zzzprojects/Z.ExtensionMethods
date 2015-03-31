
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Linq

Public Module Extensions_771

	''' <summary>
	'''     A DirectoryInfo extension method that gets a size.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The size.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetSize(this As DirectoryInfo) As Long
		Return this.GetFiles("*.*", SearchOption.AllDirectories).Sum(Function(x) x.Length)
	End Function
End Module



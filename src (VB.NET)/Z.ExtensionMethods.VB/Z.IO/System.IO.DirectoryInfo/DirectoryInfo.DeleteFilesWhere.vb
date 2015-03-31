
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Linq

Public Module Extensions_759

	''' <summary>
	'''     A DirectoryInfo extension method that deletes the files where.
	''' </summary>
	''' <param name="obj">The obj to act on.</param>
	''' <param name="predicate">The predicate.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub DeleteFilesWhere(obj As DirectoryInfo, predicate As Func(Of FileInfo, Boolean))
        obj.GetFiles().Where(predicate).ForEach(Sub(x) x.Delete())
	End Sub

	''' <summary>
	'''     A DirectoryInfo extension method that deletes the files where.
	''' </summary>
	''' <param name="obj">The obj to act on.</param>
	''' <param name="searchOption">The search option.</param>
	''' <param name="predicate">The predicate.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub DeleteFilesWhere(obj As DirectoryInfo, searchOption As SearchOption, predicate As Func(Of FileInfo, Boolean))
        obj.GetFiles("*.*", searchOption).Where(predicate).ForEach(Sub(x) x.Delete())
	End Sub
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Linq

Public Module Extensions_760

	''' <summary>
	'''     A DirectoryInfo extension method that deletes the older than.
	''' </summary>
	''' <param name="obj">The obj to act on.</param>
	''' <param name="timeSpan">The time span.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub DeleteOlderThan(obj As DirectoryInfo, timeSpan As TimeSpan)
        Dim minDate As DateTime = DateTime.Now.Subtract(timeSpan)
        obj.GetFiles().Where(Function(x) x.LastWriteTime < minDate).ToList().ForEach(Sub(x) x.Delete())
        obj.GetDirectories().Where(Function(x) x.LastWriteTime < minDate).ToList().ForEach(Sub(x) x.Delete())
	End Sub

	''' <summary>
	'''     A DirectoryInfo extension method that deletes the older than.
	''' </summary>
	''' <param name="obj">The obj to act on.</param>
	''' <param name="searchOption">The search option.</param>
	''' <param name="timeSpan">The time span.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub DeleteOlderThan(obj As DirectoryInfo, searchOption As SearchOption, timeSpan As TimeSpan)
		Dim minDate As DateTime = DateTime.Now.Subtract(timeSpan)
        obj.GetFiles("*.*", searchOption).Where(Function(x) x.LastWriteTime < minDate).ToList().ForEach(Sub(x) x.Delete())
        obj.GetDirectories("*.*", searchOption).Where(Function(x) x.LastWriteTime < minDate).ToList().ForEach(Sub(x) x.Delete())
	End Sub
End Module



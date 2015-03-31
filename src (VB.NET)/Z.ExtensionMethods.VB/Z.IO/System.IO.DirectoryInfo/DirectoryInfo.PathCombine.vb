
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.IO
Imports System.Linq

Public Module Extensions_772

	''' <summary>
	'''     Combines multiples string into a path.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="paths">A variable-length parameters list containing paths.</param>
	''' <returns>
	'''     The combined paths. If one of the specified paths is a zero-length string, this method returns the other path.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function PathCombine(this As DirectoryInfo, ParamArray paths As String()) As String
		Dim list As List(Of String) = paths.ToList()
		list.Insert(0, this.FullName)
		Return Path.Combine(list.ToArray())
	End Function
End Module



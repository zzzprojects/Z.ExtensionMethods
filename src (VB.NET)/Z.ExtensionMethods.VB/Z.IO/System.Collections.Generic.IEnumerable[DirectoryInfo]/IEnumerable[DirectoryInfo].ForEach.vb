
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.IO

Public Module Extensions_752

	''' <summary>
	'''     Enumerates for each in this collection.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="action">The action.</param>
	''' <returns>An enumerator that allows foreach to be used to process for each in this collection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ForEach(this As IEnumerable(Of DirectoryInfo), action As Action(Of DirectoryInfo)) As IEnumerable(Of DirectoryInfo)
		For Each t As DirectoryInfo In this
			action(t)
		Next
		Return this
	End Function
End Module



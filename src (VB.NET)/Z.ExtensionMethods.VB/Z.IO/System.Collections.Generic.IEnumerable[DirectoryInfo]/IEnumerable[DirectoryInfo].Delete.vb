
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.IO

Public Module Extensions_751

	''' <summary>
	'''     An IEnumerable&lt;DirectoryInfo&gt; extension method that deletes the given @this.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Delete(this As IEnumerable(Of DirectoryInfo))
		For Each t As DirectoryInfo In this
			t.Delete()
		Next
	End Sub
End Module



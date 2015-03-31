
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.IO
Imports System.Linq

Public Module Extensions_755

	''' <summary>
	'''     An IEnumerable&lt;string&gt; extension method that combine all value to return a path.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The path.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function PathCombine(this As IEnumerable(Of String)) As String
		Return Path.Combine(this.ToArray())
	End Function
End Module



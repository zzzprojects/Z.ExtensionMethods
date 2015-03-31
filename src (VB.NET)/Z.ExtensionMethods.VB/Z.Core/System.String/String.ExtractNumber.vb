
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Linq

Public Module Extensions_496

	''' <summary>
	'''     A string extension method that extracts the number described by @this.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The extracted number.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExtractNumber(this As String) As String
		Return New String(this.ToCharArray().Where(Function(x) [Char].IsNumber(x)).ToArray())
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Text

Public Module Extensions_489

	''' <summary>
	'''     A string extension method that decode a Base64 String.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The Base64 String decoded.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function DecodeBase64(this As String) As String
		Return Encoding.ASCII.GetString(Convert.FromBase64String(this))
	End Function
End Module



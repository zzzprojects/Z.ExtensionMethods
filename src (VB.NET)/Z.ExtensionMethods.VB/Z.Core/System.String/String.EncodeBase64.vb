
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Text

Public Module Extensions_491

	''' <summary>
	'''     A string extension method that encode the string to Base64.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The encoded string to Base64.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function EncodeBase64(this As String) As String
		Return Convert.ToBase64String(Activator.CreateInstance(Of ASCIIEncoding)().GetBytes(this))
	End Function
End Module



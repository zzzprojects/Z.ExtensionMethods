
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Module Extensions_799

	''' <summary>
	'''     A Stream extension method that converts the @this to a md 5 hash.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToMD5Hash(this As Stream) As String
		Using md5__1 As MD5 = MD5.Create()
			Dim hashBytes As Byte() = md5__1.ComputeHash(this)
			Dim sb = New StringBuilder()
			For Each bytes As Byte In hashBytes
				sb.Append(bytes.ToString("X2"))
			Next

			Return sb.ToString()
		End Using
	End Function
End Module



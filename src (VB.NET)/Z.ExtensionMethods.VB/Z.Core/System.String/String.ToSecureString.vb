
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Security

Public Module Extensions_537

	''' <summary>
	'''     A String extension method that converts the @this to a secure string.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a SecureString.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToSecureString(this As String) As SecureString
		Dim secureString = New SecureString()
		For Each c As [Char] In this
			secureString.AppendChar(c)
		Next

		Return secureString
	End Function
End Module



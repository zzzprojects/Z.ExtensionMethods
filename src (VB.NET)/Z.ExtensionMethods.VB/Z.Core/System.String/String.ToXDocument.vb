
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Text
Imports System.Xml.Linq

Public Module Extensions_539

	''' <summary>
	'''     A string extension method that converts the @this to a XDocument.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as an XDocument.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToXDocument(this As String) As XDocument
		Dim encoding As Encoding = Activator.CreateInstance(Of ASCIIEncoding)()
		Using ms = New MemoryStream(encoding.GetBytes(this))
			Return XDocument.Load(ms)
		End Using
	End Function
End Module



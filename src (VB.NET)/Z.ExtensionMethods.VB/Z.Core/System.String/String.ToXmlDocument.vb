
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Xml

Public Module Extensions_540

	''' <summary>
	'''     A string extension method that converts the @this to an XmlDocument.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as an XmlDocument.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToXmlDocument(this As String) As XmlDocument
		Dim doc = New XmlDocument()
		doc.LoadXml(this)
		Return doc
	End Function
End Module



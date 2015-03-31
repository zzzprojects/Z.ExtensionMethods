
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Xml.Serialization

Public Module Extensions_853

	''' <summary>
	'''     An object extension method that serialize a string to XML.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The string representation of the Xml Serialization.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function SerializeXml(this As Object) As String
		Dim xmlSerializer = New XmlSerializer(this.[GetType]())

		Using stringWriter = New StringWriter()
			xmlSerializer.Serialize(stringWriter, this)
			Using streamReader = New StringReader(stringWriter.GetStringBuilder().ToString())
				Return streamReader.ReadToEnd()
			End Using
		End Using
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Xml.Serialization

Public Module Extensions_857

	''' <summary>
	'''     A string extension method that deserialize an Xml as &lt;T&gt;.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The desieralize Xml as &lt;T&gt;</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function DeserializeXml(Of T)(this As String) As T
		Dim x = New XmlSerializer(GetType(T))
		Dim r = New StringReader(this)

		Return DirectCast(x.Deserialize(r), T)
	End Function
End Module



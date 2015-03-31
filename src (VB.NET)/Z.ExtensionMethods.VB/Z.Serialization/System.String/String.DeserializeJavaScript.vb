
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Web.Script.Serialization

Public Module Extensions_855

	''' <summary>
	'''     A string extension method that deserialize a string binary as &lt;T&gt;.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The desrialize binary as &lt;T&gt;</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function DeserializeJavaScript(Of T)(this As String) As T
		Dim serializer = New JavaScriptSerializer()
		Return serializer.Deserialize(Of T)(this)
	End Function
End Module



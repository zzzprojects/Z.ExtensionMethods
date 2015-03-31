
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Runtime.Serialization.Json
Imports System.Text

Public Module Extensions_852

	''' <summary>
	'''     A T extension method that serialize an object to Json.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The Json string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function SerializeJson(Of T)(this As T) As String
		Dim serializer = New DataContractJsonSerializer(GetType(T))

		Using memoryStream = New MemoryStream()
			serializer.WriteObject(memoryStream, this)
			Return Encoding.[Default].GetString(memoryStream.ToArray())
		End Using
	End Function

	''' <summary>
	'''     A T extension method that serialize an object to Json.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="encoding">The encoding.</param>
	''' <returns>The Json string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function SerializeJson(Of T)(this As T, encoding As Encoding) As String
		Dim serializer = New DataContractJsonSerializer(GetType(T))

		Using memoryStream = New MemoryStream()
			serializer.WriteObject(memoryStream, this)
			Return encoding.GetString(memoryStream.ToArray())
		End Using
	End Function
End Module



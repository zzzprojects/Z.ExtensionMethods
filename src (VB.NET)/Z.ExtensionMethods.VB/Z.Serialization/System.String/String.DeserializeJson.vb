
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Runtime.Serialization.Json
Imports System.Text

Public Module Extensions_856

	''' <summary>
	'''     A string extension method that deserialize a Json string to object.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The object deserialized.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function DeserializeJson(Of T)(this As String) As T
		Dim serializer = New DataContractJsonSerializer(GetType(T))

		Using stream = New MemoryStream(Encoding.[Default].GetBytes(this))
			Return DirectCast(serializer.ReadObject(stream), T)
		End Using
	End Function

	''' <summary>
	'''     A string extension method that deserialize a Json string to object.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="encoding">The encoding.</param>
	''' <returns>The object deserialized.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function DeserializeJson(Of T)(this As String, encoding As Encoding) As T
		Dim serializer = New DataContractJsonSerializer(GetType(T))

		Using stream = New MemoryStream(encoding.GetBytes(this))
			Return DirectCast(serializer.ReadObject(stream), T)
		End Using
	End Function
End Module



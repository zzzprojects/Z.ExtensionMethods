
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text

Public Module Extensions_850

	''' <summary>
	'''     An object extension method that serialize an object to binary.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>A string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function SerializeBinary(Of T)(this As T) As String
		Dim binaryWrite = New BinaryFormatter()

		Using memoryStream = New MemoryStream()
			binaryWrite.Serialize(memoryStream, this)
			Return Encoding.[Default].GetString(memoryStream.ToArray())
		End Using
	End Function

	''' <summary>
	'''     An object extension method that serialize an object to binary.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="encoding">The encoding.</param>
	''' <returns>A string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function SerializeBinary(Of T)(this As T, encoding As Encoding) As String
		Dim binaryWrite = New BinaryFormatter()

		Using memoryStream = New MemoryStream()
			binaryWrite.Serialize(memoryStream, this)
			Return encoding.GetString(memoryStream.ToArray())
		End Using
	End Function
End Module



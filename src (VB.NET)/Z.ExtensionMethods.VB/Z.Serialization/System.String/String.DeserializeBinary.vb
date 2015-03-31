
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text

Public Module Extensions_854

	''' <summary>
	'''     A string extension method that deserialize a string binary as &lt;T&gt;.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The desrialize binary as &lt;T&gt;</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function DeserializeBinary(Of T)(this As String) As T
		Using stream = New MemoryStream(Encoding.[Default].GetBytes(this))
			Dim binaryRead = New BinaryFormatter()
			Return DirectCast(binaryRead.Deserialize(stream), T)
		End Using
	End Function

	''' <summary>
	'''     A string extension method that deserialize a string binary as &lt;T&gt;.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="encoding">The encoding.</param>
	''' <returns>The desrialize binary as &lt;T&gt;</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function DeserializeBinary(Of T)(this As String, encoding As Encoding) As T
		Using stream = New MemoryStream(encoding.GetBytes(this))
			Dim binaryRead = New BinaryFormatter()
			Return DirectCast(binaryRead.Deserialize(stream), T)
		End Using
	End Function
End Module



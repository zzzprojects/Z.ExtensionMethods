
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.IO.Compression
Imports System.Text

Public Module Extensions_41

	''' <summary>
	'''     A string extension method that compress the given string to GZip byte array.
	''' </summary>
	''' <param name="this">The stringToCompress to act on.</param>
	''' <returns>The string compressed into a GZip byte array.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function CompressGZip(this As String) As Byte()
		Dim stringAsBytes As Byte() = Encoding.[Default].GetBytes(this)
		Using memoryStream = New MemoryStream()
			Using zipStream = New GZipStream(memoryStream, CompressionMode.Compress)
				zipStream.Write(stringAsBytes, 0, stringAsBytes.Length)
				zipStream.Close()
				Return (memoryStream.ToArray())
			End Using
		End Using
	End Function

	''' <summary>
	'''     A string extension method that compress the given string to GZip byte array.
	''' </summary>
	''' <param name="this">The stringToCompress to act on.</param>
	''' <param name="encoding">The encoding.</param>
	''' <returns>The string compressed into a GZip byte array.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function CompressGZip(this As String, encoding As Encoding) As Byte()
		Dim stringAsBytes As Byte() = encoding.GetBytes(this)
		Using memoryStream = New MemoryStream()
			Using zipStream = New GZipStream(memoryStream, CompressionMode.Compress)
				zipStream.Write(stringAsBytes, 0, stringAsBytes.Length)
				zipStream.Close()
				Return (memoryStream.ToArray())
			End Using
		End Using
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.IO.Compression
Imports System.Text

Public Module Extensions_38

	''' <summary>
	'''     A byte[] extension method that decompress the byte array gzip to string.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The byte array gzip to string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function DecompressGZip(this As Byte()) As String
		Const  bufferSize As Integer = 1024
		Using memoryStream = New MemoryStream(this)
			Using zipStream = New GZipStream(memoryStream, CompressionMode.Decompress)
				' Memory stream for storing the decompressed bytes
				Using outStream = New MemoryStream()
					Dim buffer = New Byte(bufferSize - 1) {}
					Dim totalBytes As Integer = 0
					Dim readBytes As Integer
					While (InlineAssignHelper(readBytes, zipStream.Read(buffer, 0, bufferSize))) > 0
						outStream.Write(buffer, 0, readBytes)
						totalBytes += readBytes
					End While
					Return Encoding.[Default].GetString(outStream.GetBuffer(), 0, totalBytes)
				End Using
			End Using
		End Using
	End Function

	''' <summary>
	'''     A byte[] extension method that decompress the byte array gzip to string.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="encoding">The encoding.</param>
	''' <returns>The byte array gzip to string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function DecompressGZip(this As Byte(), encoding As Encoding) As String
		Const  bufferSize As Integer = 1024
		Using memoryStream = New MemoryStream(this)
			Using zipStream = New GZipStream(memoryStream, CompressionMode.Decompress)
				' Memory stream for storing the decompressed bytes
				Using outStream = New MemoryStream()
					Dim buffer = New Byte(bufferSize - 1) {}
					Dim totalBytes As Integer = 0
					Dim readBytes As Integer
					While (InlineAssignHelper(readBytes, zipStream.Read(buffer, 0, bufferSize))) > 0
						outStream.Write(buffer, 0, readBytes)
						totalBytes += readBytes
					End While
					Return encoding.GetString(outStream.GetBuffer(), 0, totalBytes)
				End Using
			End Using
		End Using
	End Function
    Private Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
        target = value
        Return value
    End Function
End Module



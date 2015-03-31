
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.IO.Compression

Public Module Extensions_40

	''' <summary>
	'''     A FileInfo extension method that extracts the g zip to directory described by
	'''     @this.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExtractGZipToDirectory(this As FileInfo)
		Using originalFileStream As FileStream = this.OpenRead()
			Dim newFileName As String = Path.GetFileNameWithoutExtension(this.FullName)

			Using decompressedFileStream As FileStream = File.Create(newFileName)
				Using decompressionStream = New GZipStream(originalFileStream, CompressionMode.Decompress)
					decompressionStream.CopyTo(decompressedFileStream)
				End Using
			End Using
		End Using
	End Sub

	''' <summary>
	'''     A FileInfo extension method that extracts the g zip to directory described by
	'''     @this.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="destination">Destination for the.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExtractGZipToDirectory(this As FileInfo, destination As String)
		Using originalFileStream As FileStream = this.OpenRead()
			Using compressedFileStream As FileStream = File.Create(destination)
				Using compressionStream = New GZipStream(compressedFileStream, CompressionMode.Compress)
					originalFileStream.CopyTo(compressionStream)
				End Using
			End Using
		End Using
	End Sub

	''' <summary>
	'''     A FileInfo extension method that extracts the g zip to directory described by
	'''     @this.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="destination">Destination for the.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExtractGZipToDirectory(this As FileInfo, destination As FileInfo)
		Using originalFileStream As FileStream = this.OpenRead()
			Using compressedFileStream As FileStream = File.Create(destination.FullName)
				Using compressionStream = New GZipStream(compressedFileStream, CompressionMode.Compress)
					originalFileStream.CopyTo(compressionStream)
				End Using
			End Using
		End Using
	End Sub
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

#If NET45_OR_GREATER Then
Imports System.IO
Imports System.IO.Compression
Imports System.Text

Public Module Extensions_51

	''' <summary>Opens a zip archive at the specified path and in the specified mode.</summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="mode">
	'''     One of the enumeration values that specifies the actions that are allowed
	'''     on the entries in the opened archive.
	''' </param>
	''' <returns>A ZipArchive.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function OpenZipFile(this As FileInfo, mode As ZipArchiveMode) As ZipArchive
		Return ZipFile.Open(this.FullName, mode)
	End Function

	''' <summary>Opens a zip archive at the specified path and in the specified mode.</summary>
	''' <param name="this">
	'''     The path to the archive to open, specified as a relative or absolute
	'''     path. A relative path is interpreted as relative to the current working directory.
	''' </param>
	''' <param name="mode">
	'''     One of the enumeration values that specifies the actions that are allowed
	'''     on the entries in the opened archive.
	''' </param>
	''' <param name="entryNameEncoding">
	'''     The encoding to use when reading or writing entry names in
	'''     this archive. Specify a value for this parameter only when an encoding is required for
	'''     interoperability with zip archive tools and libraries that do not support UTF-8 encoding for
	'''     entry names.
	''' </param>
	''' <returns>A ZipArchive.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function OpenZipFile(this As FileInfo, mode As ZipArchiveMode, entryNameEncoding As Encoding) As ZipArchive
		Return ZipFile.Open(this.FullName, mode, entryNameEncoding)
	End Function
End Module
#End If



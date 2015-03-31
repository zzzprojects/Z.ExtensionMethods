
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

#If NET45_OR_GREATER Then
Imports System.IO
Imports System.IO.Compression
Imports System.Text

Public Module Extensions_49

	''' <summary>
	'''     Extracts all the files in the specified zip archive to a directory on the file system
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="destinationDirectoryName">
	'''     The path to the directory in which to place the
	'''     extracted files, specified as a relative or absolute path. A relative path is interpreted as
	'''     relative to the current working directory.
	''' </param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExtractZipFileToDirectory(this As FileInfo, destinationDirectoryName As String)
		ZipFile.ExtractToDirectory(this.FullName, destinationDirectoryName)
	End Sub

	''' <summary>
	'''     Extracts all the files in the specified zip archive to a directory on the file system and uses the specified
	'''     character encoding for entry names.
	''' </summary>
	''' <param name="this">The path to the archive that is to be extracted.</param>
	''' <param name="destinationDirectoryName">
	'''     The path to the directory in which to place the extracted files, specified as a
	'''     relative or absolute path. A relative path is interpreted as relative to the current working directory.
	''' </param>
	''' <param name="entryNameEncoding">
	'''     The encoding to use when reading or writing entry names in this archive. Specify a
	'''     value for this parameter only when an encoding is required for interoperability with zip archive tools and
	'''     libraries that do not support UTF-8 encoding for entry names.
	''' </param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExtractZipFileToDirectory(this As FileInfo, destinationDirectoryName As String, entryNameEncoding As Encoding)
		ZipFile.ExtractToDirectory(this.FullName, destinationDirectoryName, entryNameEncoding)
	End Sub

	''' <summary>Extracts all the files in the specified zip archive to a directory on the file system.</summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="destinationDirectory">Pathname of the destination directory.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExtractZipFileToDirectory(this As FileInfo, destinationDirectory As DirectoryInfo)
		ZipFile.ExtractToDirectory(this.FullName, destinationDirectory.FullName)
	End Sub

	''' <summary>
	'''     Extracts all the files in the specified zip archive to a directory on the file system
	'''     and uses the specified character encoding for entry names.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="destinationDirectory">Pathname of the destination directory.</param>
	''' <param name="entryNameEncoding">
	'''     The encoding to use when reading or writing entry names in
	'''     this archive. Specify a value for this parameter only when an encoding is required for
	'''     interoperability with zip archive tools and libraries that do not support UTF-8 encoding for
	'''     entry names.
	''' </param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExtractZipFileToDirectory(this As FileInfo, destinationDirectory As DirectoryInfo, entryNameEncoding As Encoding)
		ZipFile.ExtractToDirectory(this.FullName, destinationDirectory.FullName, entryNameEncoding)
	End Sub
End Module
#End If



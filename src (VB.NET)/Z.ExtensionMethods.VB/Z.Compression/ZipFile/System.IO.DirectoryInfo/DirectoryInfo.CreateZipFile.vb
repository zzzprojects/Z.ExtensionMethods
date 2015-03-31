
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

#If NET45_OR_GREATER Then
Imports System.IO
Imports System.IO.Compression
Imports System.Text

Public Module Extensions_48

	''' <summary>
	'''     Creates a zip archive that contains the files and directories from the specified
	'''     directory.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="destinationArchiveFileName">
	'''     The path of the archive to be created, specified as a
	'''     relative or absolute path. A relative path is interpreted as relative to the current working
	'''     directory.
	''' </param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub CreateZipFile(this As DirectoryInfo, destinationArchiveFileName As String)
		ZipFile.CreateFromDirectory(this.FullName, destinationArchiveFileName)
	End Sub

	''' <summary>
	'''     Creates a zip archive that contains the files and directories from the specified
	'''     directory, uses the specified compression level, and optionally includes the base directory.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="destinationArchiveFileName">
	'''     The path of the archive to be created, specified as a
	'''     relative or absolute path. A relative path is interpreted as relative to the current working
	'''     directory.
	''' </param>
	''' <param name="compressionLevel">
	'''     One of the enumeration values that indicates whether to
	'''     emphasize speed or compression effectiveness when creating the entry.
	''' </param>
	''' <param name="includeBaseDirectory">
	'''     true to include the directory name from
	'''     sourceDirectoryName at the root of the archive; false to include only the contents of the
	'''     directory.
	''' </param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub CreateZipFile(this As DirectoryInfo, destinationArchiveFileName As String, compressionLevel As CompressionLevel, includeBaseDirectory As Boolean)
		ZipFile.CreateFromDirectory(this.FullName, destinationArchiveFileName, compressionLevel, includeBaseDirectory)
	End Sub

	''' <summary>
	'''     Creates a zip archive that contains the files and directories from the specified directory, uses the specified
	'''     compression level and character encoding for entry names, and optionally includes the base directory.
	''' </summary>
	''' <param name="this">
	'''     The path to the directory to be archived, specified as a relative or absolute path. A relative path
	'''     is interpreted as relative to the current working directory.
	''' </param>
	''' <param name="destinationArchiveFileName">
	'''     The path of the archive to be created, specified as a relative or absolute
	'''     path. A relative path is interpreted as relative to the current working directory.
	''' </param>
	''' <param name="compressionLevel">
	'''     One of the enumeration values that indicates whether to emphasize speed or compression
	'''     effectiveness when creating the entry.
	''' </param>
	''' <param name="includeBaseDirectory">
	'''     true to include the directory name from sourceDirectoryName at the root of the
	'''     archive; false to include only the contents of the directory.
	''' </param>
	''' <param name="entryNameEncoding">
	'''     The encoding to use when reading or writing entry names in this archive. Specify a
	'''     value for this parameter only when an encoding is required for interoperability with zip archive tools and
	'''     libraries that do not support UTF-8 encoding for entry names.
	''' </param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub CreateZipFile(this As DirectoryInfo, destinationArchiveFileName As String, compressionLevel As CompressionLevel, includeBaseDirectory As Boolean, entryNameEncoding As Encoding)
		ZipFile.CreateFromDirectory(this.FullName, destinationArchiveFileName, compressionLevel, includeBaseDirectory, entryNameEncoding)
	End Sub

	''' <summary>
	'''     Creates a zip archive that contains the files and directories from the specified
	'''     directory.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="destinationArchiveFile">
	'''     The path of the archive to be created, specified as a
	'''     relative or absolute path. A relative path is interpreted as relative to the current working
	'''     directory.
	''' </param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub CreateZipFile(this As DirectoryInfo, destinationArchiveFile As FileInfo)
		ZipFile.CreateFromDirectory(this.FullName, destinationArchiveFile.FullName)
	End Sub

	''' <summary>
	'''     Creates a zip archive that contains the files and directories from the specified
	'''     directory, uses the specified compression level, and optionally includes the base directory.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="destinationArchiveFile">
	'''     The path of the archive to be created, specified as a
	'''     relative or absolute path. A relative path is interpreted as relative to the current working
	'''     directory.
	''' </param>
	''' <param name="compressionLevel">
	'''     One of the enumeration values that indicates whether to
	'''     emphasize speed or compression effectiveness when creating the entry.
	''' </param>
	''' <param name="includeBaseDirectory">
	'''     true to include the directory name from
	'''     sourceDirectoryName at the root of the archive; false to include only the contents of the
	'''     directory.
	''' </param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub CreateZipFile(this As DirectoryInfo, destinationArchiveFile As FileInfo, compressionLevel As CompressionLevel, includeBaseDirectory As Boolean)
		ZipFile.CreateFromDirectory(this.FullName, destinationArchiveFile.FullName, compressionLevel, includeBaseDirectory)
	End Sub

	''' <summary>
	'''     Creates a zip archive that contains the files and directories from the specified
	'''     directory, uses the specified compression level and character encoding for entry names, and
	'''     optionally includes the base directory.
	''' </summary>
	''' <param name="this">
	'''     The path to the directory to be archived, specified as a relative or
	'''     absolute path. A relative path is interpreted as relative to the current working directory.
	''' </param>
	''' <param name="destinationArchiveFile">
	'''     The path of the archive to be created, specified as a
	'''     relative or absolute path. A relative path is interpreted as relative to the current working
	'''     directory.
	''' </param>
	''' <param name="compressionLevel">
	'''     One of the enumeration values that indicates whether to
	'''     emphasize speed or compression effectiveness when creating the entry.
	''' </param>
	''' <param name="includeBaseDirectory">
	'''     true to include the directory name from
	'''     sourceDirectoryName at the root of the archive; false to include only the contents of the
	'''     directory.
	''' </param>
	''' <param name="entryNameEncoding">
	'''     The encoding to use when reading or writing entry names in
	'''     this archive. Specify a value for this parameter only when an encoding is required for
	'''     interoperability with zip archive tools and libraries that do not support UTF-8 encoding for
	'''     entry names.
	''' </param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub CreateZipFile(this As DirectoryInfo, destinationArchiveFile As FileInfo, compressionLevel As CompressionLevel, includeBaseDirectory As Boolean, entryNameEncoding As Encoding)
		ZipFile.CreateFromDirectory(this.FullName, destinationArchiveFile.FullName, compressionLevel, includeBaseDirectory, entryNameEncoding)
	End Sub
End Module
#End If



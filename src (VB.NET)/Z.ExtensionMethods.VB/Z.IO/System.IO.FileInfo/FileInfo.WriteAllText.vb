
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Text

Public Module Extensions_796

	''' <summary>
	'''     Creates a new file, writes the specified string to the file, and then closes the file. If the target file
	'''     already exists, it is overwritten.
	''' </summary>
	''' <param name="this">The file to write to.</param>
	''' <param name="contents">The string to write to the file.</param>
	''' ###
	''' <exception cref="T:System.ArgumentException">
	'''     <paramref name="this" /> is a zero-length string, contains only
	'''     white space, or contains one or more invalid characters as defined by
	'''     <see
	'''         cref="F:System.IO.Path.InvalidPathChars" />
	'''     .
	''' </exception>
	''' ###
	''' <exception cref="T:System.ArgumentNullException">
	'''     <paramref name="this" /> is null or
	'''     <paramref name="contents" /> is empty.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.PathTooLongException">
	'''     The specified @this, file name, or both exceed the system-
	'''     defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file
	'''     names must be less than 260 characters.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.DirectoryNotFoundException">
	'''     The specified @this is invalid (for example, it is on
	'''     an unmapped drive).
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
	''' ###
	''' <exception cref="T:System.UnauthorizedAccessException">
	'''     <paramref name="this" /> specified a file that is
	'''     read-only.-or- This operation is not supported on the current platform.-or-
	'''     <paramref
	'''         name="this" />
	'''     specified a directory.-or- The caller does not have the required permission.
	''' </exception>
	''' ###
	''' <exception cref="T:System.NotSupportedException">
	'''     <paramref name="this" /> is in an invalid format.
	''' </exception>
	''' ###
	''' <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub WriteAllText(this As FileInfo, contents As [String])
		File.WriteAllText(this.FullName, contents)
	End Sub

	''' <summary>
	'''     Creates a new file, writes the specified string to the file using the specified encoding, and then closes the
	'''     file. If the target file already exists, it is overwritten.
	''' </summary>
	''' <param name="this">The file to write to.</param>
	''' <param name="contents">The string to write to the file.</param>
	''' <param name="encoding">The encoding to apply to the string.</param>
	''' ###
	''' <exception cref="T:System.ArgumentException">
	'''     <paramref name="this" /> is a zero-length string, contains only
	'''     white space, or contains one or more invalid characters as defined by
	'''     <see
	'''         cref="F:System.IO.Path.InvalidPathChars" />
	'''     .
	''' </exception>
	''' ###
	''' <exception cref="T:System.ArgumentNullException">
	'''     <paramref name="this" /> is null or
	'''     <paramref name="contents" /> is empty.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.PathTooLongException">
	'''     The specified @this, file name, or both exceed the system-
	'''     defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters, and file
	'''     names must be less than 260 characters.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.DirectoryNotFoundException">
	'''     The specified @this is invalid (for example, it is on
	'''     an unmapped drive).
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.IOException">An I/O error occurred while opening the file.</exception>
	''' ###
	''' <exception cref="T:System.UnauthorizedAccessException">
	'''     <paramref name="this" /> specified a file that is
	'''     read-only.-or- This operation is not supported on the current platform.-or-
	'''     <paramref
	'''         name="this" />
	'''     specified a directory.-or- The caller does not have the required permission.
	''' </exception>
	''' ###
	''' <exception cref="T:System.NotSupportedException">
	'''     <paramref name="this" /> is in an invalid format.
	''' </exception>
	''' ###
	''' <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub WriteAllText(this As FileInfo, contents As [String], encoding As Encoding)
		File.WriteAllText(this.FullName, contents, encoding)
	End Sub
End Module



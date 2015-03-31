
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.IO
Imports System.Text

Public Module Extensions_795

	''' <summary>
	'''     Creates a new file, write the specified string array to the file, and then closes the file.
	''' </summary>
	''' <param name="this">The file to write to.</param>
	''' <param name="contents">The string array to write to the file.</param>
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
	'''     Either <paramref name="this" /> or
	'''     <paramref name="contents" /> is null.
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
	Public Sub WriteAllLines(this As FileInfo, contents As [String]())
		File.WriteAllLines(this.FullName, contents)
	End Sub

	''' <summary>
	'''     Creates a new file, writes the specified string array to the file by using the specified encoding, and then
	'''     closes the file.
	''' </summary>
	''' <param name="this">The file to write to.</param>
	''' <param name="contents">The string array to write to the file.</param>
	''' <param name="encoding">
	'''     An <see cref="T:System.Text.Encoding" /> object that represents the character encoding
	'''     applied to the string array.
	''' </param>
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
	'''     Either <paramref name="this" /> or
	'''     <paramref name="contents" /> is null.
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
	Public Sub WriteAllLines(this As FileInfo, contents As [String](), encoding As Encoding)
		File.WriteAllLines(this.FullName, contents, encoding)
	End Sub

	''' <summary>
	'''     Creates a new file, write the specified string array to the file, and then closes the file.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="contents">The string array to write to the file.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub WriteAllLines(this As FileInfo, contents As IEnumerable(Of [String]))
		File.WriteAllLines(this.FullName, contents)
	End Sub

	''' <summary>
	'''     Creates a new file, writes the specified string array to the file by using the specified encoding, and then
	'''     closes the file.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="contents">The string array to write to the file.</param>
	''' <param name="encoding">
	'''     An <see cref="T:System.Text.Encoding" /> object that represents the character encoding
	'''     applied to the string array.
	''' </param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub WriteAllLines(this As FileInfo, contents As IEnumerable(Of [String]), encoding As Encoding)
		File.WriteAllLines(this.FullName, contents, encoding)
	End Sub
End Module



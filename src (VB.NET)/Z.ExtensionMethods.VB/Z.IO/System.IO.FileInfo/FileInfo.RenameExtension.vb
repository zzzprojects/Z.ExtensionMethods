
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO

Public Module Extensions_792

	''' <summary>
	'''     Changes the extension of a @this string.
	''' </summary>
	''' <param name="this">
	'''     The @this information to modify. The @this cannot contain any of the characters defined in
	'''     <see
	'''         cref="M:System.IO.Path.GetInvalidPathChars" />
	'''     .
	''' </param>
	''' <param name="extension">
	'''     The new extension (with or without a leading period). Specify null to remove an existing
	'''     extension from
	'''     <paramref
	'''         name="this" />
	'''     .
	''' </param>
	''' ###
	''' <exception cref="T:System.ArgumentException">
	'''     <paramref name="this" /> contains one or more of the invalid
	'''     characters defined in
	'''     <see
	'''         cref="M:System.IO.Path.GetInvalidPathChars" />
	'''     .
	''' </exception>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub RenameExtension(this As FileInfo, extension As [String])
		Dim filePath As String = Path.ChangeExtension(this.FullName, extension)
		this.MoveTo(filePath)
	End Sub
End Module



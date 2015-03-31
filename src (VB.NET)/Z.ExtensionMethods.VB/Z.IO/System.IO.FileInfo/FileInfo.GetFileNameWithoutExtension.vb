
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO

Public Module Extensions_782

	''' <summary>
	'''     Returns the file name of the specified @this string without the extension.
	''' </summary>
	''' <param name="this">The @this of the file.</param>
	''' <returns>
	'''     The string returned by <see cref="M:System.IO.Path.GetFileName(System.String)" />, minus the last period (.)
	'''     and all characters following it.
	''' </returns>
	''' ###
	''' <exception cref="T:System.ArgumentException">
	'''     <paramref name="this" /> contains one or more of the invalid
	'''     characters defined in
	'''     <see
	'''         cref="M:System.IO.Path.GetInvalidPathChars" />
	'''     .
	''' </exception>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetFileNameWithoutExtension(this As FileInfo) As [String]
		Return Path.GetFileNameWithoutExtension(this.FullName)
	End Function
End Module



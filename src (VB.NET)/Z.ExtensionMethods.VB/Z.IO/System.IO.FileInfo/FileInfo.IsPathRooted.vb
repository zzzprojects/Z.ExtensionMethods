
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO

Public Module Extensions_785

	''' <summary>
	'''     Gets a value indicating whether the specified @this string contains a root.
	''' </summary>
	''' <param name="this">The @this to test.</param>
	''' <returns>
	'''     true if <paramref name="this" /> contains a root; otherwise, false.
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
	Public Function IsPathRooted(this As FileInfo) As [Boolean]
		Return Path.IsPathRooted(this.FullName)
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO

Public Module Extensions_74

	''' <summary>
	'''     A byte[] extension method that converts the @this to a memory stream.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a MemoryStream.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToMemoryStream(this As Byte()) As MemoryStream
		Return New MemoryStream(this)
	End Function
End Module



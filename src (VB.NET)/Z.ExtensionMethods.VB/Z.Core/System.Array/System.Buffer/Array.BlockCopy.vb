
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_62

	''' <summary>
	'''     Copies a specified number of bytes from a source array starting at a particular offset to a destination array
	'''     starting at a particular offset.
	''' </summary>
	''' <param name="src">The source buffer.</param>
	''' <param name="srcOffset">The zero-based byte offset into .</param>
	''' <param name="dst">The destination buffer.</param>
	''' <param name="dstOffset">The zero-based byte offset into .</param>
	''' <param name="count">The number of bytes to copy.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub BlockCopy(src As Array, srcOffset As Int32, dst As Array, dstOffset As Int32, count As Int32)
		Buffer.BlockCopy(src, srcOffset, dst, dstOffset, count)
	End Sub
End Module



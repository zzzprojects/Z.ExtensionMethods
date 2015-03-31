
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_75

	''' <summary>
	'''     Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array
	'''     encoded with base-64 digits. Parameters specify the subsets as offsets in the input and output arrays, and
	'''     the number of elements in the input array to convert.
	''' </summary>
	''' <param name="inArray">An input array of 8-bit unsigned integers.</param>
	''' <param name="offsetIn">A position within .</param>
	''' <param name="length">The number of elements of  to convert.</param>
	''' <param name="outArray">An output array of Unicode characters.</param>
	''' <param name="offsetOut">A position within .</param>
	''' <returns>A 32-bit signed integer containing the number of bytes in .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToBase64CharArray(inArray As [Byte](), offsetIn As Int32, length As Int32, outArray As [Char](), offsetOut As Int32) As Int32
		Return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut)
	End Function

	''' <summary>
	'''     Converts a subset of an 8-bit unsigned integer array to an equivalent subset of a Unicode character array
	'''     encoded with base-64 digits. Parameters specify the subsets as offsets in the input and output arrays, the
	'''     number of elements in the input array to convert, and whether line breaks are inserted in the output array.
	''' </summary>
	''' <param name="inArray">An input array of 8-bit unsigned integers.</param>
	''' <param name="offsetIn">A position within .</param>
	''' <param name="length">The number of elements of  to convert.</param>
	''' <param name="outArray">An output array of Unicode characters.</param>
	''' <param name="offsetOut">A position within .</param>
	''' <param name="options">to insert a line break every 76 characters, or  to not insert line breaks.</param>
	''' <returns>A 32-bit signed integer containing the number of bytes in .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToBase64CharArray(inArray As [Byte](), offsetIn As Int32, length As Int32, outArray As [Char](), offsetOut As Int32, options As Base64FormattingOptions) As Int32
		Return Convert.ToBase64CharArray(inArray, offsetIn, length, outArray, offsetOut, options)
	End Function
End Module



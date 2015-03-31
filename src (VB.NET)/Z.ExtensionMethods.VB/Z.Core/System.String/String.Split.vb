
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_530

	''' <summary>
	'''     Returns a String array containing the substrings in this string that are delimited by elements of a specified
	'''     String array. A parameter specifies whether to return empty array elements.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="separator">A string that delimit the substrings in this string.</param>
	''' <param name="option">
	'''     (Optional) Specify RemoveEmptyEntries to omit empty array elements from the array returned,
	'''     or None to include empty array elements in the array returned.
	''' </param>
	''' <returns>
	'''     An array whose elements contain the substrings in this string that are delimited by the separator.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Split(this As String, separator As String, Optional [option] As StringSplitOptions = StringSplitOptions.None) As String()
        Return this.Split(separator, [option])
	End Function
End Module



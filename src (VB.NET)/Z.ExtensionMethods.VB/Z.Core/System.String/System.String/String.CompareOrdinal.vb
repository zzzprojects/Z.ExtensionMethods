
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_560

	''' <summary>
	'''     Compares two specified  objects by evaluating the numeric values of the corresponding  objects in each string.
	''' </summary>
	''' <param name="strA">The first string to compare.</param>
	''' <param name="strB">The second string to compare.</param>
	''' <returns>
	'''     An integer that indicates the lexical relationship between the two comparands.ValueCondition Less than zero
	'''     is less than . Zero  and  are equal. Greater than zero  is greater than .
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function CompareOrdinal(strA As [String], strB As [String]) As Int32
		Return [String].CompareOrdinal(strA, strB)
	End Function

	''' <summary>
	'''     Compares substrings of two specified  objects by evaluating the numeric values of the corresponding  objects
	'''     in each substring.
	''' </summary>
	''' <param name="strA">The first string to use in the comparison.</param>
	''' <param name="indexA">The starting index of the substring in .</param>
	''' <param name="strB">The second string to use in the comparison.</param>
	''' <param name="indexB">The starting index of the substring in .</param>
	''' <param name="length">The maximum number of characters in the substrings to compare.</param>
	''' <returns>
	'''     A 32-bit signed integer that indicates the lexical relationship between the two comparands.ValueCondition
	'''     Less than zero The substring in  is less than the substring in . Zero The substrings are equal, or  is zero.
	'''     Greater than zero The substring in  is greater than the substring in .
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function CompareOrdinal(strA As [String], indexA As Int32, strB As [String], indexB As Int32, length As Int32) As Int32
		Return [String].CompareOrdinal(strA, indexA, strB, indexB, length)
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_561

	''' <summary>
	'''     Concatenates two specified instances of .
	''' </summary>
	''' <param name="str0">The first string to concatenate.</param>
	''' <param name="str1">The second string to concatenate.</param>
	''' <returns>The concatenation of  and .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Concat(str0 As [String], str1 As [String]) As [String]
		Return [String].Concat(str0, str1)
	End Function

	''' <summary>
	'''     Concatenates three specified instances of .
	''' </summary>
	''' <param name="str0">The first string to concatenate.</param>
	''' <param name="str1">The second string to concatenate.</param>
	''' <param name="str2">The third string to concatenate.</param>
	''' <returns>The concatenation of , , and .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Concat(str0 As [String], str1 As [String], str2 As [String]) As [String]
		Return [String].Concat(str0, str1, str2)
	End Function

	''' <summary>
	'''     Concatenates four specified instances of .
	''' </summary>
	''' <param name="str0">The first string to concatenate.</param>
	''' <param name="str1">The second string to concatenate.</param>
	''' <param name="str2">The third string to concatenate.</param>
	''' <param name="str3">The fourth string to concatenate.</param>
	''' <returns>The concatenation of , , , and .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Concat(str0 As [String], str1 As [String], str2 As [String], str3 As [String]) As [String]
		Return [String].Concat(str0, str1, str2, str3)
	End Function
End Module



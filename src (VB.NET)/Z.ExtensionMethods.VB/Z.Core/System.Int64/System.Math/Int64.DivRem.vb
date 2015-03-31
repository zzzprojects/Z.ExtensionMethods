
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_317

	''' <summary>
	'''     An Int64 extension method that div rem.
	''' </summary>
	''' <param name="a">a to act on.</param>
	''' <param name="b">The Int64 to process.</param>
	''' <param name="result">[out] The result.</param>
	''' <returns>An Int64.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function DivRem(a As Int64, b As Int64, ByRef result As Int64) As Int64
		Return Math.DivRem(a, b, result)
	End Function
End Module



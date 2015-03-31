
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_289

	''' <summary>
	'''     An Int32 extension method that div rem.
	''' </summary>
	''' <param name="a">a to act on.</param>
	''' <param name="b">The Int32 to process.</param>
	''' <param name="result">[out] The result.</param>
	''' <returns>An Int32.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function DivRem(a As Int32, b As Int32, ByRef result As Int32) As Int32
		Return Math.DivRem(a, b, result)
	End Function
End Module



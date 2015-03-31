
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_189

	''' <summary>
	'''     Rounds a decimal value to the nearest integral value.
	''' </summary>
	''' <param name="d">A decimal number to be rounded.</param>
	''' <returns>
	'''     The integer nearest parameter . If the fractional component of  is halfway between two integers, one of which
	'''     is even and the other odd, the even number is returned. Note that this method returns a  instead of an
	'''     integral type.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Round(d As [Decimal]) As [Decimal]
		Return Math.Round(d)
	End Function

	''' <summary>
	'''     Rounds a decimal value to a specified number of fractional digits.
	''' </summary>
	''' <param name="d">A decimal number to be rounded.</param>
	''' <param name="decimals">The number of decimal places in the return value.</param>
	''' <returns>The number nearest to  that contains a number of fractional digits equal to .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Round(d As [Decimal], decimals As Int32) As [Decimal]
		Return Math.Round(d, decimals)
	End Function

	''' <summary>
	'''     Rounds a decimal value to the nearest integer. A parameter specifies how to round the value if it is midway
	'''     between two numbers.
	''' </summary>
	''' <param name="d">A decimal number to be rounded.</param>
	''' <param name="mode">Specification for how to round  if it is midway between two other numbers.</param>
	''' <returns>
	'''     The integer nearest . If  is halfway between two numbers, one of which is even and the other odd, then
	'''     determines which of the two is returned.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Round(d As [Decimal], mode As MidpointRounding) As [Decimal]
		Return Math.Round(d, mode)
	End Function

	''' <summary>
	'''     Rounds a decimal value to a specified number of fractional digits. A parameter specifies how to round the
	'''     value if it is midway between two numbers.
	''' </summary>
	''' <param name="d">A decimal number to be rounded.</param>
	''' <param name="decimals">The number of decimal places in the return value.</param>
	''' <param name="mode">Specification for how to round  if it is midway between two other numbers.</param>
	''' <returns>
	'''     The number nearest to  that contains a number of fractional digits equal to . If  has fewer fractional digits
	'''     than ,  is returned unchanged.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Round(d As [Decimal], decimals As Int32, mode As MidpointRounding) As [Decimal]
		Return Math.Round(d, decimals, mode)
	End Function
End Module



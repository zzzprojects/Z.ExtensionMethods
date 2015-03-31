
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_258

	''' <summary>
	'''     Returns the specified 16-bit signed integer value as an array of bytes.
	''' </summary>
	''' <param name="value">The number to convert.</param>
	''' <returns>An array of bytes with length 2.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetBytes(value As Int16) As [Byte]()
		Return BitConverter.GetBytes(value)
	End Function
End Module



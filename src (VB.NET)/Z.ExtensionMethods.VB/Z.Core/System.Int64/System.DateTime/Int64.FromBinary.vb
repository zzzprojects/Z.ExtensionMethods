
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_312

	''' <summary>
	'''     Deserializes a 64-bit binary value and recreates an original serialized  object.
	''' </summary>
	''' <param name="dateData">
	'''     A 64-bit signed integer that encodes the  property in a 2-bit field and the  property in
	'''     a 62-bit field.
	''' </param>
	''' <returns>An object that is equivalent to the  object that was serialized by the  method.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FromBinary(dateData As Int64) As DateTime
		Return DateTime.FromBinary(dateData)
	End Function
End Module



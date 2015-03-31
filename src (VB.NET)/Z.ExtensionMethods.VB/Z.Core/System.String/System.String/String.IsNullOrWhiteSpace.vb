
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_566

	''' <summary>
	'''     Indicates whether a specified string is null, empty, or consists only of white-space characters.
	''' </summary>
	''' <param name="value">The string to test.</param>
	''' <returns>true if the  parameter is null or , or if  consists exclusively of white-space characters.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsNullOrWhiteSpace(value As [String]) As [Boolean]
		Return [String].IsNullOrWhiteSpace(value)
	End Function
End Module



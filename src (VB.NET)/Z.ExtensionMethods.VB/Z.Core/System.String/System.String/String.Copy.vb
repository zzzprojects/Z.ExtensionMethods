
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_562

	''' <summary>
	'''     Creates a new instance of  with the same value as a specified .
	''' </summary>
	''' <param name="str">The string to copy.</param>
	''' <returns>A new string with the same value as .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Copy(str As [String]) As [String]
		Return [String].Copy(str)
	End Function
End Module



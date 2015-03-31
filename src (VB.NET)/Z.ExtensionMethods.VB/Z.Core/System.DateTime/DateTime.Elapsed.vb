
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_110

	''' <summary>
	'''     A DateTime extension method that elapsed the given datetime.
	''' </summary>
	''' <param name="datetime">The datetime to act on.</param>
	''' <returns>A TimeSpan.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Elapsed(datetime__1 As DateTime) As TimeSpan
		Return DateTime.Now - datetime__1
	End Function
End Module



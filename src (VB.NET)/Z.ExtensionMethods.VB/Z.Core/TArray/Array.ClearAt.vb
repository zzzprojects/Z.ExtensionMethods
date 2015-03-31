
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_634

	''' <summary>
	'''     A T[] extension method that clears at.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The arrayToClear to act on.</param>
	''' <param name="at">at.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ClearAt(Of T)(this As T(), at As Integer)
		Array.Clear(this, at, 1)
	End Sub
End Module



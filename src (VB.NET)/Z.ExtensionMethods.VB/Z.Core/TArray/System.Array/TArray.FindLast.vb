
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_641

	''' <summary>
	'''     A T[] extension method that searches for the first last.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="array">The array to act on.</param>
	''' <param name="match">Specifies the match.</param>
	''' <returns>The found last.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FindLast(Of T)(array__1 As T(), match As Predicate(Of T)) As T
		Return Array.FindLast(array__1, match)
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_639

	''' <summary>
	'''     A T[] extension method that searches for the first all.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="array">The array to act on.</param>
	''' <param name="match">Specifies the match.</param>
	''' <returns>The found all.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FindAll(Of T)(array__1 As T(), match As Predicate(Of T)) As T()
		Return Array.FindAll(array__1, match)
	End Function
End Module



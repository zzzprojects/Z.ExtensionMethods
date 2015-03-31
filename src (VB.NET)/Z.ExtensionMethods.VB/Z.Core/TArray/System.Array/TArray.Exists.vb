
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_637

	''' <summary>
	'''     A T[] extension method that exists.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="array">The array to act on.</param>
	''' <param name="match">Specifies the match.</param>
	''' <returns>true if it succeeds, false if it fails.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Exists(Of T)(array__1 As T(), match As Predicate(Of T)) As [Boolean]
		Return Array.Exists(array__1, match)
	End Function
End Module



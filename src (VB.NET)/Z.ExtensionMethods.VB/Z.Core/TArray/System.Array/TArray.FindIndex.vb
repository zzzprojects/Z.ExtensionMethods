
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_640

	''' <summary>
	'''     A T[] extension method that searches for the first index.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="array">The array to act on.</param>
	''' <param name="match">Specifies the match.</param>
	''' <returns>The found index.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FindIndex(Of T)(array__1 As T(), match As Predicate(Of T)) As Int32
		Return Array.FindIndex(array__1, match)
	End Function

	''' <summary>
	'''     A T[] extension method that searches for the first index.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="array">The array to act on.</param>
	''' <param name="startIndex">The start index.</param>
	''' <param name="match">Specifies the match.</param>
	''' <returns>The found index.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FindIndex(Of T)(array__1 As T(), startIndex As Int32, match As Predicate(Of T)) As Int32
		Return Array.FindIndex(array__1, startIndex, match)
	End Function

	''' <summary>
	'''     A T[] extension method that searches for the first index.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="array">The array to act on.</param>
	''' <param name="startIndex">The start index.</param>
	''' <param name="count">Number of.</param>
	''' <param name="match">Specifies the match.</param>
	''' <returns>The found index.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FindIndex(Of T)(array__1 As T(), startIndex As Int32, count As Int32, match As Predicate(Of T)) As Int32
		Return Array.FindIndex(array__1, startIndex, count, match)
	End Function
End Module



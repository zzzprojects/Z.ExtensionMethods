
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_643

	''' <summary>
	'''     A T[] extension method that applies an operation to all items in this collection.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="array">The array to act on.</param>
	''' <param name="action">The action.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ForEach(Of T)(array__1 As T(), action As Action(Of T))
		Array.ForEach(array__1, action)
	End Sub
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.ObjectModel

Public Module Extensions_636

	''' <summary>
	'''     A T[] extension method that converts an array to a read only.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="array">The array to act on.</param>
	''' <returns>A list of.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function AsReadOnly(Of T)(array__1 As T()) As ReadOnlyCollection(Of T)
		Return Array.AsReadOnly(array__1)
	End Function
End Module



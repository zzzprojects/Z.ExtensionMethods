
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_633

	''' <summary>
	'''     A T[] extension method that clears all described by @this.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' ###
	''' <returns>.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ClearAll(Of T)(this As T())
		Array.Clear(this, 0, this.Length)
	End Sub
End Module



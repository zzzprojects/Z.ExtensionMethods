
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_834

	''' <summary>
	'''     A T extension method that query if '@this' is subclass of.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="type">The Type to process.</param>
	''' <returns>true if subclass of, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsSubclassOf(Of T)(this As T, type As Type) As Boolean
		Return this.[GetType]().IsSubclassOf(type)
	End Function
End Module



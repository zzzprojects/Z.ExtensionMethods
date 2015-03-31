
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_330

	''' <summary>
	'''     An object extension method that query if '@this' is assignable from.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true if assignable from, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsAssignableFrom(Of T)(this As Object) As Boolean
		Dim type As Type = this.[GetType]()
		Return type.IsAssignableFrom(GetType(T))
	End Function

	''' <summary>
	'''     An object extension method that query if '@this' is assignable from.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="targetType">Type of the target.</param>
	''' <returns>true if assignable from, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsAssignableFrom(this As Object, targetType As Type) As Boolean
		Dim type As Type = this.[GetType]()
		Return type.IsAssignableFrom(targetType)
	End Function
End Module



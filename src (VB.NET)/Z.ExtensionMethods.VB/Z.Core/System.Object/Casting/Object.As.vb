
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_328

	''' <summary>
	'''     An object extension method that cast anonymous type to the specified type.
	''' </summary>
	''' <typeparam name="T">Generic type parameter. The specified type.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The object as the specified type.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function [As](Of T)(this As Object) As T
		Return DirectCast(this, T)
	End Function
End Module



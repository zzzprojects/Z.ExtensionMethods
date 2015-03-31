
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_816

	''' <summary>
	'''     An object extension method that gets custom attributes.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="inherit">true to inherit.</param>
	''' <returns>An array of object.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(this As Object, inherit As Boolean) As Object()
		Return this.[GetType]().GetCustomAttributes(inherit)
	End Function

	''' <summary>
	'''     An object extension method that gets custom attributes.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="inherit">true to inherit.</param>
	''' <returns>An array of object.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(Of T As Attribute)(this As Object, inherit As Boolean) As Object()
		Return this.[GetType]().GetCustomAttributes(GetType(T), inherit)
	End Function
End Module



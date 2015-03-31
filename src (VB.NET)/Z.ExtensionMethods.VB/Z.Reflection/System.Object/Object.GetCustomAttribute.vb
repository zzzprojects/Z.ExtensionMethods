
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_814

	''' <summary>
	'''     An object extension method that gets the first custom attribute.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="attribute">The attribute.</param>
	''' <param name="inherit">true to inherit.</param>
	''' <returns>The custom attribute.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttribute(this As Object, attribute As Type, inherit As Boolean) As Object
		Return this.[GetType]().GetCustomAttributes(attribute, inherit)(0)
	End Function

	''' <summary>
	'''     An object extension method that gets custom attribute.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="inherit">true to inherit.</param>
	''' <returns>The custom attribute.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttribute(Of T As Attribute)(this As Object, inherit As Boolean) As T
		Return DirectCast(this.[GetType]().GetCustomAttributes(GetType(T), inherit)(0), T)
	End Function
End Module



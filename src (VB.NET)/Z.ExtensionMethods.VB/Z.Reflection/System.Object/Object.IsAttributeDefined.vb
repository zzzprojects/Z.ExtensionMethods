
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_828

	''' <summary>
	'''     An object extension method that query if '@this' is attribute defined.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="attributeType">Type of the attribute.</param>
	''' <param name="inherit">true to inherit.</param>
	''' <returns>true if attribute defined, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsAttributeDefined(this As Object, attributeType As Type, inherit As Boolean) As Boolean
		Return this.[GetType]().IsDefined(attributeType, inherit)
	End Function

	''' <summary>
	'''     An object extension method that query if '@this' is attribute defined.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="inherit">true to inherit.</param>
	''' <returns>true if attribute defined, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsAttributeDefined(Of T As Attribute)(this As Object, inherit As Boolean) As Boolean
		Return this.[GetType]().IsDefined(GetType(T), inherit)
	End Function
End Module



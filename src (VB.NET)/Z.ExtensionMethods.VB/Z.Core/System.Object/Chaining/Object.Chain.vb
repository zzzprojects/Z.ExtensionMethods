
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_331

	''' <summary>
	'''     A T extension method that chains actions.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="action">The action.</param>
	''' <returns>The @this acted on.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Chain(Of T)(this As T, action As Action(Of T)) As T
		action(this)

		Return this
	End Function
End Module



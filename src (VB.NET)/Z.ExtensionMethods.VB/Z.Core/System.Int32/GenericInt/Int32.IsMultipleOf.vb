
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_273

	''' <summary>
	'''     An Int32 extension method that query if '@this' is multiple of.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="factor">The factor.</param>
	''' <returns>true if multiple of, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsMultipleOf(this As Int32, factor As Int32) As Boolean
		Return this Mod factor = 0
	End Function
End Module



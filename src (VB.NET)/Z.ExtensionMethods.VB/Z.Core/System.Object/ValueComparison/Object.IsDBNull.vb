
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_457

	''' <summary>
	'''     Returns an indication whether the specified object is of type .
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="value">An object.</param>
	''' <returns>true if  is of type ; otherwise, false.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsDBNull(Of T As Class)(value As T) As [Boolean]
		Return Convert.IsDBNull(value)
	End Function
End Module



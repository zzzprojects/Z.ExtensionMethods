
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_463

	''' <summary>
	'''     Gets the types of the objects in the specified array.
	''' </summary>
	''' <param name="args">An array of objects whose types to determine.</param>
	''' <returns>An array of  objects representing the types of the corresponding elements in .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetTypeArray(args As [Object]()) As Type()
		Return Type.GetTypeArray(args)
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_315

	''' <summary>
	'''     Converts the specified 64-bit signed integer, which contains an OLE Automation Currency value, to the
	'''     equivalent  value.
	''' </summary>
	''' <param name="cy">An OLE Automation Currency value.</param>
	''' <returns>A  that contains the equivalent of .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FromOACurrency(cy As Int64) As [Decimal]
		Return [Decimal].FromOACurrency(cy)
	End Function
End Module



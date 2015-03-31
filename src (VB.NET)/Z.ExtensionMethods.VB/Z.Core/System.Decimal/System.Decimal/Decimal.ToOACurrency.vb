
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_178

	''' <summary>
	'''     Converts the specified  value to the equivalent OLE Automation Currency value, which is contained in a 64-bit
	'''     signed integer.
	''' </summary>
	''' <param name="value">The decimal number to convert.</param>
	''' <returns>A 64-bit signed integer that contains the OLE Automation equivalent of .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToOACurrency(value As [Decimal]) As Int64
		Return [Decimal].ToOACurrency(value)
	End Function
End Module



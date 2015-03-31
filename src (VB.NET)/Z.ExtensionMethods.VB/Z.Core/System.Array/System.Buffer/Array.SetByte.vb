
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_65

	''' <summary>
	'''     Assigns a specified value to a byte at a particular location in a specified array.
	''' </summary>
	''' <param name="array">An array.</param>
	''' <param name="index">A location in the array.</param>
	''' <param name="value">A value to assign.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub SetByte(array As Array, index As Int32, value As [Byte])
		Buffer.SetByte(array, index, value)
	End Sub
End Module



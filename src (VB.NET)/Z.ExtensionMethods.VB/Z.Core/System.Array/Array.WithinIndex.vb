
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_53

	''' <summary>
	'''     An Array extension method that check if the array is lower then the specified index.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="index">Zero-based index of the.</param>
	''' <returns>true if it succeeds, false if it fails.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function WithinIndex(this As Array, index As Integer) As Boolean
		Return index >= 0 AndAlso index < this.Length
	End Function

	''' <summary>
	'''     An Array extension method that check if the array is lower then the specified index.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="index">Zero-based index of the.</param>
	''' <param name="dimension">(Optional) the dimension.</param>
	''' <returns>true if it succeeds, false if it fails.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function WithinIndex(this As Array, index As Integer, Optional dimension As Integer = 0) As Boolean
		Return index >= this.GetLowerBound(dimension) AndAlso index <= this.GetUpperBound(dimension)
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_213

	''' <summary>
	'''     Returns e raised to the specified power.
	''' </summary>
	''' <param name="d">A number specifying a power.</param>
	''' <returns>
	'''     The number e raised to the power . If  equals  or , that value is returned. If  equals , 0 is returned.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Exp(d As [Double]) As [Double]
		Return Math.Exp(d)
	End Function
End Module



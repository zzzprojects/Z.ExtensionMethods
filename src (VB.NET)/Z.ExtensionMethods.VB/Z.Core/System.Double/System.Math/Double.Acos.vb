
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_206

	''' <summary>
	'''     Returns the angle whose cosine is the specified number.
	''' </summary>
	''' <param name="d">
	'''     A number representing a cosine, where  must be greater than or equal to -1, but less than or
	'''     equal to 1.
	''' </param>
	''' <returns>An angle, ?, measured in radians, such that 0 ????-or-  if  &lt; -1 or  &gt; 1 or  equals .</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Acos(d As [Double]) As [Double]
		Return Math.Acos(d)
	End Function
End Module



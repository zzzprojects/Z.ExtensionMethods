
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_208

	''' <summary>
	'''     Returns the angle whose tangent is the specified number.
	''' </summary>
	''' <param name="d">A number representing a tangent.</param>
	''' <returns>
	'''     An angle, ?, measured in radians, such that -?/2 ????/2.-or-  if  equals , -?/2 rounded to double precision (-
	'''     1.5707963267949) if  equals , or ?/2 rounded to double precision (1.5707963267949) if  equals .
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Atan(d As [Double]) As [Double]
		Return Math.Atan(d)
	End Function
End Module



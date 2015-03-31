
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_606

	''' <summary>
	'''     A TimeSpan extension method that substract the specified TimeSpan to the current DateTime.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The current DateTime with the specified TimeSpan substracted from it.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Ago(this As TimeSpan) As DateTime
		Return DateTime.Now.Subtract(this)
	End Function
End Module



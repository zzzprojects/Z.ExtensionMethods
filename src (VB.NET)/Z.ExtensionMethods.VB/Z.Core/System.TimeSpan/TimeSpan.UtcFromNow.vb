
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_609

	''' <summary>
	'''     A TimeSpan extension method that add the specified TimeSpan to the current UTC (Coordinated Universal Time)
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The current UTC (Coordinated Universal Time) with the specified TimeSpan added to it.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function UtcFromNow(this As TimeSpan) As DateTime
		Return DateTime.UtcNow.Add(this)
	End Function
End Module



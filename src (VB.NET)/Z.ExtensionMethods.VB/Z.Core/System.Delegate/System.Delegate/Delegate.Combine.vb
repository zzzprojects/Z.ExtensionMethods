
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_196

	''' <summary>
	'''     Concatenates the invocation lists of two delegates.
	''' </summary>
	''' <param name="a">The delegate whose invocation list comes first.</param>
	''' <param name="b">The delegate whose invocation list comes last.</param>
	''' ###
	''' <returns>
	'''     A new delegate with an invocation list that concatenates the invocation lists of  and  in that order. Returns
	'''     if  is null, returns  if  is a null reference, and returns a null reference if both  and  are null references.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Combine(a As [Delegate], b As [Delegate]) As [Delegate]
		Return [Delegate].Combine(a, b)
	End Function
End Module



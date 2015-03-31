
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_67

	''' <summary>
	'''     A bool extension method that execute an Action if the value is true.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="action">The action to execute.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub IfTrue(this As Boolean, action As Action)
		If this Then
			action()
		End If
	End Sub
End Module



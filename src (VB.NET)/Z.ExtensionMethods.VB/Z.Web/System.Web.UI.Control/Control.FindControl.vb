
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Web.UI

Public Module Extensions_883

	''' <summary>
	'''     Searches the current naming container for a server control with the specified id parameter.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="id">The identifier for the control to be found.</param>
	''' <returns>The specified control, or a null reference if the specified control does not exist.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FindControl(Of T As Class)(this As Control, id As String) As T
		Return TryCast(this.FindControl(id), T)
	End Function
End Module



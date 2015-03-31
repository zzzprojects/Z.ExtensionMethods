
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Web.UI

Public Module Extensions_884

	''' <summary>
	'''     Searches recursively in the container and child container for a server control with the specified id
	'''     parameter.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="id">The identifier for the control to be found.</param>
	''' <returns>The specified control, or a null reference if the specified control does not exist.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FindControlRecursive(this As Control, id As String) As Control
		Dim rControl As Control = this.FindControl(id)

		If rControl Is Nothing Then
			For Each control As Control In this.Controls
				rControl = control.FindControl(id)
				If rControl IsNot Nothing Then
					Exit For
				End If
			Next
		End If

		Return rControl
	End Function

	''' <summary>
	'''     Searches recursively in the container and child container for a server control with the specified id
	'''     parameter.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="id">The identifier for the control to be found.</param>
	''' <returns>The specified control, or a null reference if the specified control does not exist.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FindControlRecursive(Of T As Class)(this As Control, id As String) As T
		Dim rControl As Control = this.FindControl(id)

		If rControl Is Nothing Then
			For Each control As Control In this.Controls
				rControl = control.FindControl(id)
				If rControl IsNot Nothing Then
					Exit For
				End If
			Next
		End If

		Return TryCast(rControl, T)
	End Function
End Module



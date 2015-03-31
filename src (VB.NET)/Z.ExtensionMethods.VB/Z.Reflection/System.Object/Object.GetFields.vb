
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_818

	''' <summary>An object extension method that gets the fields.</summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>An array of field information.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetFields(this As Object) As FieldInfo()
		Return this.[GetType]().GetFields()
	End Function

	''' <summary>An object extension method that gets the fields.</summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="bindingAttr">The binding attribute.</param>
	''' <returns>An array of field information.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetFields(this As Object, bindingAttr As BindingFlags) As FieldInfo()
		Return this.[GetType]().GetFields(bindingAttr)
	End Function
End Module



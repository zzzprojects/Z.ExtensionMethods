
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_824

	''' <summary>
	'''     A T extension method that gets a property.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="name">The name.</param>
	''' <returns>The property.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetProperty(Of T)(this As T, name As String) As PropertyInfo
		Return this.[GetType]().GetProperty(name)
	End Function

	''' <summary>
	'''     A T extension method that gets a property.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="name">The name.</param>
	''' <param name="bindingAttr">The binding attribute.</param>
	''' <returns>The property.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetProperty(Of T)(this As T, name As String, bindingAttr As BindingFlags) As PropertyInfo
		Return this.[GetType]().GetProperty(name, bindingAttr)
	End Function
End Module



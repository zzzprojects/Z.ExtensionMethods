
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_821

	''' <summary>
	'''     A T extension method that searches for the public method with the specified name.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="name">The string containing the name of the public method to get.</param>
	''' <returns>
	'''     An object that represents the public method with the specified name, if found; otherwise, null.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetMethod(Of T)(this As T, name As String) As MethodInfo
		Return this.[GetType]().GetMethod(name)
	End Function

	''' <summary>
	'''     A T extension method that searches for the specified method whose parameters match the specified argument
	'''     types and modifiers, using the specified binding constraints.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="name">The string containing the name of the public method to get.</param>
	''' <param name="bindingAttr">A bitmask comprised of one or more BindingFlags that specify how the search is conducted.</param>
	''' <returns>
	'''     An object that represents the public method with the specified name, if found; otherwise, null.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetMethod(Of T)(this As T, name As String, bindingAttr As BindingFlags) As MethodInfo
		Return this.[GetType]().GetMethod(name, bindingAttr)
	End Function
End Module



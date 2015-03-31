
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Linq
Imports System.Reflection

Public Module Extensions_827

	''' <summary>
	'''     An object extension method that executes the method on a different thread, and waits for the result.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="obj">The obj to act on.</param>
	''' <param name="methodName">Name of the method.</param>
	''' <param name="parameters">Options for controlling the operation.</param>
	''' <returns>An object.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function InvokeMethod(Of T)(obj As T, methodName As String, ParamArray parameters As Object()) As Object
		Dim type As Type = obj.[GetType]()
		Dim method As MethodInfo = type.GetMethod(methodName, parameters.[Select](Function(o) o.[GetType]()).ToArray())

		Return method.Invoke(obj, parameters)
	End Function

	''' <summary>
	'''     An object extension method that executes the method on a different thread, and waits for the result.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="obj">The obj to act on.</param>
	''' <param name="methodName">Name of the method.</param>
	''' <param name="parameters">Options for controlling the operation.</param>
	''' <returns>A T.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function InvokeMethod(Of T)(obj As Object, methodName As String, ParamArray parameters As Object()) As T
		Dim type As Type = obj.[GetType]()
		Dim method As MethodInfo = type.GetMethod(methodName, parameters.[Select](Function(o) o.[GetType]()).ToArray())

		Dim value As Object = method.Invoke(obj, parameters)
		Return (If(TypeOf value Is T, DirectCast(value, T), Nothing))
	End Function
End Module



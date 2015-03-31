
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Globalization
Imports System.Reflection

Public Module Extensions_610

	''' <summary>
	'''     A Type extension method that creates an instance.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="bindingAttr">The binding attribute.</param>
	''' <param name="binder">The binder.</param>
	''' <param name="args">The arguments.</param>
	''' <param name="culture">The culture.</param>
	''' <returns>The new instance.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function CreateInstance(Of T)(this As Type, bindingAttr As BindingFlags, binder As Binder, args As [Object](), culture As CultureInfo) As T
		Return DirectCast(Activator.CreateInstance(this, bindingAttr, binder, args, culture), T)
	End Function

	''' <summary>
	'''     A Type extension method that creates an instance.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="bindingAttr">The binding attribute.</param>
	''' <param name="binder">The binder.</param>
	''' <param name="args">The arguments.</param>
	''' <param name="culture">The culture.</param>
	''' <param name="activationAttributes">The activation attributes.</param>
	''' <returns>The new instance.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function CreateInstance(Of T)(this As Type, bindingAttr As BindingFlags, binder As Binder, args As [Object](), culture As CultureInfo, activationAttributes As [Object]()) As T
		Return DirectCast(Activator.CreateInstance(this, bindingAttr, binder, args, culture, activationAttributes), T)
	End Function

	''' <summary>
	'''     A Type extension method that creates an instance.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="args">The arguments.</param>
	''' <returns>The new instance.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function CreateInstance(Of T)(this As Type, args As [Object]()) As T
		Return DirectCast(Activator.CreateInstance(this, args), T)
	End Function

	''' <summary>
	'''     A Type extension method that creates an instance.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="args">The arguments.</param>
	''' <param name="activationAttributes">The activation attributes.</param>
	''' <returns>The new instance.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function CreateInstance(Of T)(this As Type, args As [Object](), activationAttributes As [Object]()) As T
		Return DirectCast(Activator.CreateInstance(this, args, activationAttributes), T)
	End Function

	''' <summary>
	'''     A Type extension method that creates an instance.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The new instance.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function CreateInstance(Of T)(this As Type) As T
		Return DirectCast(Activator.CreateInstance(this), T)
	End Function

	''' <summary>
	'''     A Type extension method that creates an instance.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="nonPublic">true to non public.</param>
	''' <returns>The new instance.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function CreateInstance(Of T)(this As Type, nonPublic As [Boolean]) As T
		Return DirectCast(Activator.CreateInstance(this, nonPublic), T)
	End Function
End Module



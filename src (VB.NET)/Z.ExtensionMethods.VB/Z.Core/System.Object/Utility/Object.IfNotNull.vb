
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_449

	''' <summary>A T extension method that execute an action when the value is not null.</summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="action">The action.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub IfNotNull(Of T As Class)(this As T, action As Action(Of T))
		If this IsNot Nothing Then
			action(this)
		End If
	End Sub

	''' <summary>
	'''     A T extension method that the function result if not null otherwise default value.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <typeparam name="TResult">Type of the result.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="func">The function.</param>
	''' <returns>The function result if @this is not null otherwise default value.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IfNotNull(Of T As Class, TResult)(this As T, func As Func(Of T, TResult)) As TResult
		Return If(this IsNot Nothing, func(this), Nothing)
	End Function

	''' <summary>
	'''     A T extension method that the function result if not null otherwise default value.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <typeparam name="TResult">Type of the result.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="func">The function.</param>
	''' <param name="defaultValue">The default value.</param>
	''' <returns>The function result if @this is not null otherwise default value.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IfNotNull(Of T As Class, TResult)(this As T, func As Func(Of T, TResult), defaultValue As TResult) As TResult
		Return If(this IsNot Nothing, func(this), defaultValue)
	End Function

	''' <summary>
	'''     A T extension method that the function result if not null otherwise default value.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <typeparam name="TResult">Type of the result.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="func">The function.</param>
	''' <param name="defaultValueFactory">The default value factory.</param>
	''' <returns>The function result if @this is not null otherwise default value.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IfNotNull(Of T As Class, TResult)(this As T, func As Func(Of T, TResult), defaultValueFactory As Func(Of TResult)) As TResult
		Return If(this IsNot Nothing, func(this), defaultValueFactory())
	End Function
End Module



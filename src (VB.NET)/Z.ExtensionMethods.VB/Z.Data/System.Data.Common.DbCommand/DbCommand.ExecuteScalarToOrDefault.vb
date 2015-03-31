
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data.Common

Public Module Extensions_654

	''' <summary>
	'''     A DbCommand extension method that executes the scalar to or default operation.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>A T.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteScalarToOrDefault(Of T)(this As DbCommand) As T
		Try
			Return this.ExecuteScalar().[To](Of T)()
		Catch generatedExceptionName As Exception
			Return Nothing
		End Try
	End Function

	''' <summary>
	'''     A DbCommand extension method that executes the scalar to or default operation.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="defaultValue">The default value.</param>
	''' <returns>A T.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteScalarToOrDefault(Of T)(this As DbCommand, defaultValue As T) As T
		Try
			Return this.ExecuteScalar().[To](Of T)()
		Catch generatedExceptionName As Exception
			Return defaultValue
		End Try
	End Function

	''' <summary>
	'''     A DbCommand extension method that executes the scalar to or default operation.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="defaultValueFactory">The default value factory.</param>
	''' <returns>A T.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteScalarToOrDefault(Of T)(this As DbCommand, defaultValueFactory As Func(Of DbCommand, T)) As T
		Try
			Return this.ExecuteScalar().[To](Of T)()
		Catch generatedExceptionName As Exception
			Return defaultValueFactory(this)
		End Try
	End Function
End Module



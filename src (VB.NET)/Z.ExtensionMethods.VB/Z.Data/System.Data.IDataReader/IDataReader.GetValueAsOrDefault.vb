
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data

Public Module Extensions_675

	''' <summary>
	'''     An IDataReader extension method that gets value as or default.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="index">Zero-based index of the.</param>
	''' <returns>The value as or default.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetValueAsOrDefault(Of T)(this As IDataReader, index As Integer) As T
		Try
			Return DirectCast(this.GetValue(index), T)
		Catch
			Return Nothing
		End Try
	End Function

	''' <summary>
	'''     An IDataReader extension method that gets value as or default.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="index">Zero-based index of the.</param>
	''' <param name="defaultValue">The default value.</param>
	''' <returns>The value as or default.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetValueAsOrDefault(Of T)(this As IDataReader, index As Integer, defaultValue As T) As T
		Try
			Return DirectCast(this.GetValue(index), T)
		Catch
			Return defaultValue
		End Try
	End Function

	''' <summary>
	'''     An IDataReader extension method that gets value as or default.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="index">Zero-based index of the.</param>
	''' <param name="defaultValueFactory">The default value factory.</param>
	''' <returns>The value as or default.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetValueAsOrDefault(Of T)(this As IDataReader, index As Integer, defaultValueFactory As Func(Of IDataReader, Integer, T)) As T
		Try
			Return DirectCast(this.GetValue(index), T)
		Catch
			Return defaultValueFactory(this, index)
		End Try
	End Function

	''' <summary>
	'''     An IDataReader extension method that gets value as or default.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="columnName">Name of the column.</param>
	''' <returns>The value as or default.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetValueAsOrDefault(Of T)(this As IDataReader, columnName As String) As T
		Try
			Return DirectCast(this.GetValue(this.GetOrdinal(columnName)), T)
		Catch
			Return Nothing
		End Try
	End Function

	''' <summary>
	'''     An IDataReader extension method that gets value as or default.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="columnName">Name of the column.</param>
	''' <param name="defaultValue">The default value.</param>
	''' <returns>The value as or default.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetValueAsOrDefault(Of T)(this As IDataReader, columnName As String, defaultValue As T) As T
		Try
			Return DirectCast(this.GetValue(this.GetOrdinal(columnName)), T)
		Catch
			Return defaultValue
		End Try
	End Function

	''' <summary>
	'''     An IDataReader extension method that gets value as or default.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="columnName">Name of the column.</param>
	''' <param name="defaultValueFactory">The default value factory.</param>
	''' <returns>The value as or default.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetValueAsOrDefault(Of T)(this As IDataReader, columnName As String, defaultValueFactory As Func(Of IDataReader, String, T)) As T
		Try
			Return DirectCast(this.GetValue(this.GetOrdinal(columnName)), T)
		Catch
			Return defaultValueFactory(this, columnName)
		End Try
	End Function
End Module



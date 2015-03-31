
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Common

Public Module Extensions_655

	''' <summary>
	'''     Enumerates execute entities in this collection.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="parameters">Options for controlling the operation.</param>
	''' <param name="commandType">Type of the command.</param>
	''' <param name="transaction">The transaction.</param>
	''' <returns>An enumerator that allows foreach to be used to process execute entities in this collection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteEntities(Of T As New)(this As DbConnection, cmdText As String, parameters As DbParameter(), commandType As CommandType, transaction As DbTransaction) As IEnumerable(Of T)
		Using command As DbCommand = this.CreateCommand()
			command.CommandText = cmdText
			command.CommandType = commandType
			command.Transaction = transaction

			If parameters IsNot Nothing Then
				command.Parameters.AddRange(parameters)
			End If

			Using reader As IDataReader = command.ExecuteReader()
				Return reader.ToEntities(Of T)()
			End Using
		End Using
	End Function

	''' <summary>
	'''     Enumerates execute entities in this collection.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="commandFactory">The command factory.</param>
	''' <returns>An enumerator that allows foreach to be used to process execute entities in this collection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteEntities(Of T As New)(this As DbConnection, commandFactory As Action(Of DbCommand)) As IEnumerable(Of T)
		Using command As DbCommand = this.CreateCommand()
			commandFactory(command)

			Using reader As IDataReader = command.ExecuteReader()
				Return reader.ToEntities(Of T)()
			End Using
		End Using
	End Function

	''' <summary>
	'''     Enumerates execute entities in this collection.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <returns>An enumerator that allows foreach to be used to process execute entities in this collection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteEntities(Of T As New)(this As DbConnection, cmdText As String) As IEnumerable(Of T)
		Return this.ExecuteEntities(Of T)(cmdText, Nothing, CommandType.Text, Nothing)
	End Function

	''' <summary>
	'''     Enumerates execute entities in this collection.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="transaction">The transaction.</param>
	''' <returns>An enumerator that allows foreach to be used to process execute entities in this collection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteEntities(Of T As New)(this As DbConnection, cmdText As String, transaction As DbTransaction) As IEnumerable(Of T)
		Return this.ExecuteEntities(Of T)(cmdText, Nothing, CommandType.Text, transaction)
	End Function

	''' <summary>
	'''     Enumerates execute entities in this collection.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="commandType">Type of the command.</param>
	''' <returns>An enumerator that allows foreach to be used to process execute entities in this collection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteEntities(Of T As New)(this As DbConnection, cmdText As String, commandType As CommandType) As IEnumerable(Of T)
		Return this.ExecuteEntities(Of T)(cmdText, Nothing, commandType, Nothing)
	End Function

	''' <summary>
	'''     Enumerates execute entities in this collection.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="commandType">Type of the command.</param>
	''' <param name="transaction">The transaction.</param>
	''' <returns>An enumerator that allows foreach to be used to process execute entities in this collection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteEntities(Of T As New)(this As DbConnection, cmdText As String, commandType As CommandType, transaction As DbTransaction) As IEnumerable(Of T)
		Return this.ExecuteEntities(Of T)(cmdText, Nothing, commandType, transaction)
	End Function

	''' <summary>
	'''     Enumerates execute entities in this collection.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="parameters">Options for controlling the operation.</param>
	''' <returns>An enumerator that allows foreach to be used to process execute entities in this collection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteEntities(Of T As New)(this As DbConnection, cmdText As String, parameters As DbParameter()) As IEnumerable(Of T)
		Return this.ExecuteEntities(Of T)(cmdText, parameters, CommandType.Text, Nothing)
	End Function

	''' <summary>
	'''     Enumerates execute entities in this collection.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="parameters">Options for controlling the operation.</param>
	''' <param name="transaction">The transaction.</param>
	''' <returns>An enumerator that allows foreach to be used to process execute entities in this collection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteEntities(Of T As New)(this As DbConnection, cmdText As String, parameters As DbParameter(), transaction As DbTransaction) As IEnumerable(Of T)
		Return this.ExecuteEntities(Of T)(cmdText, parameters, CommandType.Text, transaction)
	End Function

	''' <summary>
	'''     Enumerates execute entities in this collection.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="parameters">Options for controlling the operation.</param>
	''' <param name="commandType">Type of the command.</param>
	''' <returns>An enumerator that allows foreach to be used to process execute entities in this collection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExecuteEntities(Of T As New)(this As DbConnection, cmdText As String, parameters As DbParameter(), commandType As CommandType) As IEnumerable(Of T)
		Return this.ExecuteEntities(Of T)(cmdText, parameters, commandType, Nothing)
	End Function
End Module



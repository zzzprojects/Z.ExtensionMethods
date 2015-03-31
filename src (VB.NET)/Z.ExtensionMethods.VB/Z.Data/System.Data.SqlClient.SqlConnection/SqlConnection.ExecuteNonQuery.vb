
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data
Imports System.Data.SqlClient

Public Module Extensions_697

	''' <summary>
	'''     A SqlConnection extension method that executes the non query operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="parameters">Options for controlling the operation.</param>
	''' <param name="commandType">Type of the command.</param>
	''' <param name="transaction">The transaction.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExecuteNonQuery(this As SqlConnection, cmdText As String, parameters As SqlParameter(), commandType As CommandType, transaction As SqlTransaction)
		Using command As SqlCommand = this.CreateCommand()
			command.CommandText = cmdText
			command.CommandType = commandType
			command.Transaction = transaction

			If parameters IsNot Nothing Then
				command.Parameters.AddRange(parameters)
			End If

			command.ExecuteNonQuery()
		End Using
	End Sub

	''' <summary>
	'''     A SqlConnection extension method that executes the non query operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="commandFactory">The command factory.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExecuteNonQuery(this As SqlConnection, commandFactory As Action(Of SqlCommand))
		Using command As SqlCommand = this.CreateCommand()
			commandFactory(command)

			command.ExecuteNonQuery()
		End Using
	End Sub

	''' <summary>
	'''     A SqlConnection extension method that executes the non query operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExecuteNonQuery(this As SqlConnection, cmdText As String)
		this.ExecuteNonQuery(cmdText, Nothing, CommandType.Text, Nothing)
	End Sub

	''' <summary>
	'''     A SqlConnection extension method that executes the non query operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="transaction">The transaction.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExecuteNonQuery(this As SqlConnection, cmdText As String, transaction As SqlTransaction)
		this.ExecuteNonQuery(cmdText, Nothing, CommandType.Text, transaction)
	End Sub

	''' <summary>
	'''     A SqlConnection extension method that executes the non query operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="commandType">Type of the command.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExecuteNonQuery(this As SqlConnection, cmdText As String, commandType As CommandType)
		this.ExecuteNonQuery(cmdText, Nothing, commandType, Nothing)
	End Sub

	''' <summary>
	'''     A SqlConnection extension method that executes the non query operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="commandType">Type of the command.</param>
	''' <param name="transaction">The transaction.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExecuteNonQuery(this As SqlConnection, cmdText As String, commandType As CommandType, transaction As SqlTransaction)
		this.ExecuteNonQuery(cmdText, Nothing, commandType, transaction)
	End Sub

	''' <summary>
	'''     A SqlConnection extension method that executes the non query operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="parameters">Options for controlling the operation.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExecuteNonQuery(this As SqlConnection, cmdText As String, parameters As SqlParameter())
		this.ExecuteNonQuery(cmdText, parameters, CommandType.Text, Nothing)
	End Sub

	''' <summary>
	'''     A SqlConnection extension method that executes the non query operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="parameters">Options for controlling the operation.</param>
	''' <param name="transaction">The transaction.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExecuteNonQuery(this As SqlConnection, cmdText As String, parameters As SqlParameter(), transaction As SqlTransaction)
		this.ExecuteNonQuery(cmdText, parameters, CommandType.Text, transaction)
	End Sub

	''' <summary>
	'''     A SqlConnection extension method that executes the non query operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="cmdText">The command text.</param>
	''' <param name="parameters">Options for controlling the operation.</param>
	''' <param name="commandType">Type of the command.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ExecuteNonQuery(this As SqlConnection, cmdText As String, parameters As SqlParameter(), commandType As CommandType)
		this.ExecuteNonQuery(cmdText, parameters, commandType, Nothing)
	End Sub
End Module



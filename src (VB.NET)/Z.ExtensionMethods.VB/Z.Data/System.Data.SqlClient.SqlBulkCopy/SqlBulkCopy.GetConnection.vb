
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data.SqlClient
Imports System.Reflection

Public Module Extensions_687

	''' <summary>A SqlBulkCopy extension method that gets a connection.</summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The connection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetConnection(this As SqlBulkCopy) As SqlConnection
		Dim type As Type = this.[GetType]()
		Dim field As FieldInfo = type.GetField("_connection", BindingFlags.NonPublic Or BindingFlags.Instance)
		' ReSharper disable PossibleNullReferenceException
		Return TryCast(field.GetValue(this), SqlConnection)
		' ReSharper restore PossibleNullReferenceException
	End Function
End Module



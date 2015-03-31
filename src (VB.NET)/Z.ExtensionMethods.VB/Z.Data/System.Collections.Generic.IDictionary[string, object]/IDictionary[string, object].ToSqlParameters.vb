
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Linq

Public Module Extensions_646

	''' <summary>
	'''     An IDictionary&lt;string,object&gt; extension method that converts the @this to a SQL parameters.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a SqlParameter[].</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToSqlParameters(this As IDictionary(Of String, Object)) As SqlParameter()
		Return this.[Select](Function(x) New SqlParameter(x.Key, x.Value)).ToArray()
	End Function
End Module



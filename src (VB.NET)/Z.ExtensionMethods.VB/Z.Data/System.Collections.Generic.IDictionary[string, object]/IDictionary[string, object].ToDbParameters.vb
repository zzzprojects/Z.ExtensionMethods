
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Data.Common
Imports System.Linq

Public Module Extensions_645

	''' <summary>
	'''     An IDictionary&lt;string,object&gt; extension method that converts this object to a database parameters.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="command">The command.</param>
	''' <returns>The given data converted to a DbParameter[].</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToDbParameters(this As IDictionary(Of String, Object), command As DbCommand) As DbParameter()
		Return this.[Select](Function(x) 
		Dim parameter As DbParameter = command.CreateParameter()
		parameter.ParameterName = x.Key
		parameter.Value = x.Value
		Return parameter

End Function).ToArray()
	End Function

	''' <summary>
	'''     An IDictionary&lt;string,object&gt; extension method that converts this object to a database parameters.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="connection">The connection.</param>
	''' <returns>The given data converted to a DbParameter[].</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToDbParameters(this As IDictionary(Of String, Object), connection As DbConnection) As DbParameter()
		Dim command As DbCommand = connection.CreateCommand()

		Return this.[Select](Function(x) 
		Dim parameter As DbParameter = command.CreateParameter()
		parameter.ParameterName = x.Key
		parameter.Value = x.Value
		Return parameter

End Function).ToArray()
	End Function
End Module



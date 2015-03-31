
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Specialized
Imports System.Text
Imports System.Web

Public Module Extensions_575

	''' <summary>
	'''     Parses a query string into a  using  encoding.
	''' </summary>
	''' <param name="query">The query string to parse.</param>
	''' <returns>A  of query parameters and values.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ParseQueryString(query As [String]) As NameValueCollection
		Return HttpUtility.ParseQueryString(query)
	End Function

	''' <summary>
	'''     Parses a query string into a  using the specified .
	''' </summary>
	''' <param name="query">The query string to parse.</param>
	''' <param name="encoding">The  to use.</param>
	''' <returns>A  of query parameters and values.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ParseQueryString(query As [String], encoding As Encoding) As NameValueCollection
		Return HttpUtility.ParseQueryString(query, encoding)
	End Function
End Module



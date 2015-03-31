
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Web

Public Module Extensions_861

	''' <summary>
	'''     A HttpResponse extension method that sets the status.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="code">The code.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub SetStatus(this As HttpResponse, code As Integer)
		this.StatusCode = code
	End Sub

	''' <summary>
	'''     A HttpResponse extension method that sets the status.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="code">The code.</param>
	''' <param name="endResponse">true to end response.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub SetStatus(this As HttpResponse, code As Integer, endResponse As Boolean)
		this.StatusCode = code

		If endResponse Then
			this.[End]()
		End If
	End Sub

	''' <summary>
	'''     A HttpResponse extension method that sets the status.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="code">The code.</param>
	''' <param name="description">The description.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub SetStatus(this As HttpResponse, code As Integer, description As String)
		this.StatusCode = code
		this.StatusDescription = description
	End Sub

	''' <summary>
	'''     A HttpResponse extension method that sets the status.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="code">The code.</param>
	''' <param name="description">The description.</param>
	''' <param name="endResponse">true to end response.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub SetStatus(this As HttpResponse, code As Integer, description As String, endResponse As Boolean)
		this.StatusCode = code
		this.StatusDescription = description

		If endResponse Then
			this.[End]()
		End If
	End Sub
End Module



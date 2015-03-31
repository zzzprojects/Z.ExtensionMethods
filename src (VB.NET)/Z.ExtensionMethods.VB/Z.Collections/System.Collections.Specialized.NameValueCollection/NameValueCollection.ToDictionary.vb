
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Collections.Specialized

Public Module Extensions_37

	''' <summary>
	'''     A NameValueCollection extension method that converts the @this to a dictionary.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as an IDictionary&lt;string,object&gt;</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToDictionary(this As NameValueCollection) As IDictionary(Of String, Object)
		Dim dict = New Dictionary(Of String, Object)()

		If this IsNot Nothing Then
			For Each key As String In this.AllKeys
				dict.Add(key, this(key))
			Next
		End If

		Return dict
	End Function
End Module



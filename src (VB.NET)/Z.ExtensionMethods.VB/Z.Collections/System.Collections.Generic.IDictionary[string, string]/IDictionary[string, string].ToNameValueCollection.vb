
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Collections.Specialized

Public Module Extensions_20

	''' <summary>
	'''     An IDictionary&lt;string,string&gt; extension method that converts the @this to a name value collection.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a NameValueCollection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToNameValueCollection(this As IDictionary(Of String, String)) As NameValueCollection
		If this Is Nothing Then
			Return Nothing
		End If

		Dim col = New NameValueCollection()
        For Each item As Object In this
            col.Add(item.Key, item.Value)
        Next
		Return col
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Dynamic

Public Module Extensions_19

	''' <summary>
	'''     An IDictionary&lt;string,object&gt; extension method that converts the @this to an expando.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as an ExpandoObject.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToExpando(this As IDictionary(Of String, Object)) As ExpandoObject
		Dim expando = New ExpandoObject()
		Dim expandoDict = DirectCast(expando, IDictionary(Of String, Object))

        For Each item As Object In this
            If TypeOf item.Value Is IDictionary(Of String, Object) Then
                Dim d = DirectCast(item.Value, IDictionary(Of String, Object))
                expandoDict.Add(item.Key, d.ToExpando())
            Else
                expandoDict.Add(item)
            End If
        Next

		Return expando
	End Function
End Module



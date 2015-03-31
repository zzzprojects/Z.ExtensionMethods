
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Data.SqlClient

Public Module Extensions_703

	''' <summary>
	'''     A SqlParameterCollection extension method that adds a range with value to 'values'.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="values">The values.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub AddRangeWithValue(this As SqlParameterCollection, values As Dictionary(Of String, Object))
        For Each keyValuePair As Object In values
            this.AddWithValue(keyValuePair.Key, keyValuePair.Value)
        Next
	End Sub
End Module



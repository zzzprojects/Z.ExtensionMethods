
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Data
Imports System.Dynamic

Public Module Extensions_666

	''' <summary>A DataRow extension method that converts the @this to an expando object.</summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a dynamic.</returns>
    <System.Runtime.CompilerServices.Extension> _
    Public Function ToExpandoObject(this As DataRow) As Object
        Dim entity As Object = New ExpandoObject()
        Dim expandoDict = DirectCast(entity, IDictionary(Of String, Object))

        For Each column As DataColumn In this.Table.Columns
            expandoDict.Add(column.ColumnName, this(column))
        Next

        Return expandoDict
    End Function
End Module



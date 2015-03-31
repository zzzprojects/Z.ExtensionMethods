
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Data
Imports System.Dynamic

Public Module Extensions_670

	''' <summary>
	'''     Enumerates to expando objects in this collection.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as an IEnumerable&lt;dynamic&gt;</returns>
	''' ###
	''' <typeparam name="T">Generic type parameter.</typeparam>
    <System.Runtime.CompilerServices.Extension> _
    Public Function ToExpandoObjects(this As DataTable) As IEnumerable(Of Object)
        Dim list = New List(Of Object)()

        For Each dr As DataRow In this.Rows
            Dim entity As Object = New ExpandoObject()
            Dim expandoDict = DirectCast(entity, IDictionary(Of String, Object))

            For Each column As DataColumn In this.Columns
                expandoDict.Add(column.ColumnName, dr(column))
            Next


            list.Add(entity)
        Next

        Return list
    End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Data
Imports System.Dynamic
Imports System.Linq

Public Module Extensions_683

	''' <summary>
	'''     Enumerates to expando objects in this collection.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as an IEnumerable&lt;dynamic&gt;</returns>
    <System.Runtime.CompilerServices.Extension> _
    Public Function ToExpandoObjects(this As IDataReader) As IEnumerable(Of Object)
        Dim columnNames As Dictionary(Of Integer, KeyValuePair(Of Integer, String)) = Enumerable.Range(0, this.FieldCount).[Select](Function(x) New KeyValuePair(Of Integer, String)(x, this.GetName(x))).ToDictionary(Function(pair) pair.Key)

        Dim list = New List(Of Object)()

        While this.Read()
            Dim entity As Object = New ExpandoObject()
            Dim expandoDict = DirectCast(entity, IDictionary(Of String, Object))

            Enumerable.Range(0, this.FieldCount).ToList().ForEach(Sub(x) expandoDict.Add(columnNames(x).Value, this(x)))

            list.Add(entity)
        End While

        Return list
    End Function
End Module



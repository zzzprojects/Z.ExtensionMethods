
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data
Imports System.Data.Common

Public Module Extensions_649

	''' <summary>
	'''     A DbCommand extension method that executes the expando object operation.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>A dynamic.</returns>
    <System.Runtime.CompilerServices.Extension> _
    Public Function ExecuteExpandoObject(this As DbCommand) As Object
        Using reader As IDataReader = this.ExecuteReader()
            reader.Read()
            Return reader.ToExpandoObject()
        End Using
    End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Common

Public Module Extensions_650

	''' <summary>
	'''     Enumerates execute expando objects in this collection.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>
	'''     An enumerator that allows foreach to be used to process execute expando objects in this collection.
	''' </returns>
    <System.Runtime.CompilerServices.Extension> _
    Public Function ExecuteExpandoObjects(this As DbCommand) As IEnumerable(Of Object)
        Using reader As IDataReader = this.ExecuteReader()
            Return reader.ToExpandoObjects()
        End Using
    End Function
End Module



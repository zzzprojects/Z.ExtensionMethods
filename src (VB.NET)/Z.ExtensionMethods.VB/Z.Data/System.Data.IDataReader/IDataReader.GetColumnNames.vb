
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Data
Imports System.Linq

Public Module Extensions_673

	''' <summary>
	'''     Gets the column names in this collection.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>An enumerator that allows foreach to be used to get the column names in this collection.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetColumnNames(this As IDataRecord) As IEnumerable(Of String)
        Return Enumerable.Range(0, this.FieldCount).Select(Function(x) this.GetName(x)).ToList()
	End Function
End Module



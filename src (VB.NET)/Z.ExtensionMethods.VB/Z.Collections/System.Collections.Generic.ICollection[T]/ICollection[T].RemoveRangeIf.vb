
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic

Public Module Extensions_16

    ''' <summary>
    '''     An ICollection&lt;T&gt; extension method that removes range item that satisfy the predicate.
    ''' </summary>
    ''' <typeparam name="T">Generic type parameter.</typeparam>
    ''' <param name="this">The @this to act on.</param>
    ''' <param name="predicate">The predicate.</param>
    ''' <param name="values">A variable-length parameters list containing values.</param>
    <System.Runtime.CompilerServices.Extension> _
    Public Sub RemoveRangeIf(Of T)(this As ICollection(Of T), predicate As Func(Of T, Boolean), ParamArray values As T())
        For Each value As T In values
            If predicate(value) Then
                this.Remove(value)
            End If
        Next
    End Sub
End Module



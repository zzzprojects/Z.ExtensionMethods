
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_60

    ''' <summary>
    '''     Reverses the sequence of the elements in the entire one-dimensional .
    ''' </summary>
    ''' <param name="array">The one-dimensional  to reverse.</param>
    <System.Runtime.CompilerServices.Extension> _
    Public Sub Reverse(array__1 As Array)
        Array.Reverse(array__1)
    End Sub

    ''' <summary>
    '''     Reverses the sequence of the elements in a range of elements in the one-dimensional .
    ''' </summary>
    ''' <param name="array">The one-dimensional  to reverse.</param>
    ''' <param name="index">The starting index of the section to reverse.</param>
    ''' <param name="length">The number of elements in the section to reverse.</param>
    <System.Runtime.CompilerServices.Extension> _
    Public Sub Reverse(array__1 As Array, index As Int32, length As Int32)
        Array.Reverse(array__1, index, length)
    End Sub
End Module



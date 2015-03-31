
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_170

    ''' <summary>
    '''     Returns the result of multiplying the specified  value by negative one.
    ''' </summary>
    ''' <param name="d">The value to negate.</param>
    ''' <returns>A decimal number with the value of , but the opposite sign.-or- Zero, if  is zero.</returns>
    <System.Runtime.CompilerServices.Extension> _
    Public Function Negate(d As [Decimal]) As [Decimal]
        Return [Decimal].Negate(d)
    End Function
End Module



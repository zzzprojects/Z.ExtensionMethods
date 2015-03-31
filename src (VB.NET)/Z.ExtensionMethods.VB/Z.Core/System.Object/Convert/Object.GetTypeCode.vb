
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_335

    ''' <summary>
    '''     Returns the  for the specified object.
    ''' </summary>
    ''' <param name="value">An object that implements the  interface.</param>
    ''' <returns>The  for , or  if  is null.</returns>
    <System.Runtime.CompilerServices.Extension> _
    Public Function GetTypeCode(value As [Object]) As TypeCode
        Return Convert.GetTypeCode(value)
    End Function
End Module



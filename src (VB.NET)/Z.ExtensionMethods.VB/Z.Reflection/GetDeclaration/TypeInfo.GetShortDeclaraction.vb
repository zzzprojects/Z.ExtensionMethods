
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_813

    <System.Runtime.CompilerServices.Extension> _
    Friend Function GetShortDeclaraction(this As Type) As String
        If this = GetType(Boolean) Then
            Return "bool"
        End If
        If this = GetType(Byte) Then
            Return "byte"
        End If
        If this = GetType(Char) Then
            Return "char"
        End If
        If this = GetType(Decimal) Then
            Return "decimal"
        End If
        If this = GetType(Double) Then
            Return "double"
        End If
        If this = GetType([Enum]) Then
            Return "enum"
        End If
        If this = GetType(Single) Then
            Return "float"
        End If
        If this = GetType(Integer) Then
            Return "int"
        End If
        If this = GetType(Long) Then
            Return "long"
        End If
        If this = GetType(Object) Then
            Return "object"
        End If
        If this = GetType(SByte) Then
            Return "sbyte"
        End If
        If this = GetType(Short) Then
            Return "short"
        End If
        If this = GetType(String) Then
            Return "string"
        End If
        If this = GetType(UInteger) Then
            Return "uint"
        End If
        If this = GetType(ULong) Then
            Return "ulong"
        End If
        If this = GetType(UShort) Then
            Return "ushort"
        End If

        Return this.Name
    End Function
End Module



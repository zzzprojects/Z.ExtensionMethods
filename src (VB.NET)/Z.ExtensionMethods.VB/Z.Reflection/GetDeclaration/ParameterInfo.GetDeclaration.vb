
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text

Public Module Extensions_810

	<System.Runtime.CompilerServices.Extension> _
	Public Function GetDeclaraction(this As ParameterInfo) As String
		Dim sb = New StringBuilder()

		this.GetDeclaraction(sb)
		Return sb.ToString()
	End Function

    <System.Runtime.CompilerServices.Extension> _
    Friend Sub GetDeclaraction(this As ParameterInfo, sb As StringBuilder)
        ' retval attribute
        Dim attributes = New List(Of String)()

        Dim typeName As String
        Dim elementType As Type = this.ParameterType.GetElementType()

        If elementType IsNot Nothing Then
            typeName = this.ParameterType.Name.Replace(elementType.Name, elementType.GetShortDeclaraction())
        Else
            typeName = this.ParameterType.GetShortDeclaraction()
        End If


        If Attribute.IsDefined(this, GetType(ParamArrayAttribute)) Then
            sb.Append("params ")
        ElseIf this.Position = 0 AndAlso this.Member.IsDefined(GetType(ExtensionAttribute)) Then
            sb.Append("this ")
        End If

        If this.IsIn Then
            attributes.Add("In")
        End If
        If this.IsOut Then
            If typeName.Contains("&") Then
                typeName = typeName.Replace("&", "")
                sb.Append("out ")
            Else
                attributes.Add("Out")
            End If
        ElseIf this.ParameterType.IsByRef Then
            typeName = typeName.Replace("&", "")
            sb.Append("ref ")
        End If
        sb.Append(typeName)

        sb.Append(" ")
        sb.Append(this.Name)

        If this.IsOptional Then
            If this.DefaultValue <> Missing.Value Then
                sb.Append(" = " + this.DefaultValue)
            Else
                attributes.Add("Optional")
            End If
        End If


        Dim attribute__1 As String = If(attributes.Count > 0, "[" + String.Join(", ", attributes) + "] ", "")
        sb.Insert(0, attribute__1)
    End Sub
End Module



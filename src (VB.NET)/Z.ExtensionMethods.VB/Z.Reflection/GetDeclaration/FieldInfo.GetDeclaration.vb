
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Linq
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text

Public Module Extensions_807

	<System.Runtime.CompilerServices.Extension> _
	Public Function GetDeclaraction(this As FieldInfo) As String
		Dim isConstant As Boolean = False
		Dim sb = New StringBuilder()
		Dim requiredTypes As Type() = this.GetRequiredCustomModifiers()

		' Visibility
		If this.IsPublic Then
			sb.Append("public ")
		ElseIf this.IsPrivate Then
			sb.Append("private ")
		ElseIf this.IsFamily Then
			sb.Append("protected ")
		ElseIf this.IsAssembly Then
			sb.Append("internal ")
		Else
			sb.Append("protected internal ")
		End If

		' Modifier
		If this.IsStatic Then
			If this.IsLiteral Then
				isConstant = True
				sb.Append("const ")
			Else
				sb.Append("static ")
			End If
		ElseIf this.IsInitOnly Then
			sb.Append("readonly ")
		End If


		If requiredTypes.Any(Function(x) x = GetType(IsVolatile)) Then
			sb.Append("volatile ")
		End If


		sb.Append(this.FieldType.GetShortDeclaraction())
		sb.Append(" ")

		sb.Append(this.Name)

		If isConstant Then
			sb.Append(" = " + this.GetRawConstantValue())
		End If
		sb.Append(";")

		Return sb.ToString()
	End Function
End Module



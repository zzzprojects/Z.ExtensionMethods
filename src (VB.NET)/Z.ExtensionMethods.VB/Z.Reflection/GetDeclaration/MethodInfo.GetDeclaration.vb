
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Linq
Imports System.Reflection
Imports System.Text

Public Module Extensions_809

	<System.Runtime.CompilerServices.Extension> _
	Public Function GetDeclaraction(this As MethodInfo) As String
		Dim sb = New StringBuilder()

		If this.IsPublic Then
			sb.Append("public ")
		ElseIf this.IsFamily Then
			sb.Append("protected ")
		ElseIf this.IsAssembly Then
			sb.Append("internal ")
		ElseIf this.IsPrivate Then
			sb.Append("private ")
		Else
			sb.Append("protected internal ")
		End If

		' Modifier
		If this.IsAbstract Then
			sb.Append("abstract ")
		ElseIf this.GetBaseDefinition().DeclaringType <> this.DeclaringType Then
			sb.Append("override ")
		ElseIf this.IsVirtual Then
			sb.Append("virtual ")
		ElseIf this.IsStatic Then
			sb.Append("static ")
		End If

		sb.Append(this.ReturnType.GetShortDeclaraction())
		sb.Append(" ")

		sb.Append(this.Name)

		If this.IsGenericMethod Then
			sb.Append("<")

			Dim arguments As Type() = this.GetGenericArguments()

			sb.Append(String.Join(", ", arguments.[Select](Function(x) x.GetShortDeclaraction())))

			sb.Append(">")
		End If

		sb.Append("(")

		Dim parameters As ParameterInfo() = this.GetParameters()

		sb.Append(String.Join(", ", parameters.[Select](Function(x) x.GetDeclaraction())))

		sb.Append(")")

		Return sb.ToString()
	End Function
End Module



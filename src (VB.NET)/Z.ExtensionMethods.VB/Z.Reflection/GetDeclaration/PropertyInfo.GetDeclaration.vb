
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Linq
Imports System.Reflection
Imports System.Text

Public Module Extensions_811

	<System.Runtime.CompilerServices.Extension> _
	Public Function GetDeclaraction(this As PropertyInfo) As String
		Dim sb = New StringBuilder()

		Dim canRead As Boolean = this.CanRead
		Dim canWrite As Boolean = this.CanWrite
		Dim readLevel As Integer = 9
		Dim writeLevel As Integer = 9
		Dim readVisibility As String = ""
		Dim writeVisibility As String = ""

		Dim isAbstract As Boolean = False
		Dim isVirtual As Boolean = False
		Dim isStatic As Boolean = False
		Dim isOverride As Boolean = False
		Dim genericMethod As MethodInfo = Nothing
		Dim type As Type = this.DeclaringType
		' Set visibility
		If canRead Then
			Dim method As MethodInfo = this.GetGetMethod(True)
			isAbstract = method.IsAbstract
			isVirtual = method.IsVirtual
			isStatic = method.IsStatic
			isOverride = method.GetBaseDefinition().DeclaringType <> method.DeclaringType

			If method.IsPublic Then
				readLevel = 1
				readVisibility = "public "
			ElseIf method.IsFamily Then
				readLevel = 2
				readVisibility = "protected "
			ElseIf method.IsAssembly Then
				readLevel = 3
				readVisibility = "internal "
			ElseIf method.IsPrivate Then
				readLevel = 5
				readVisibility = "private "
			Else
				readLevel = 4
				readVisibility = "protected internal "
			End If
		End If
		If canWrite Then
			Dim method As MethodInfo = this.GetSetMethod(True)
			isAbstract = method.IsAbstract
			isVirtual = method.IsVirtual
			isStatic = method.IsStatic
			isOverride = method.GetBaseDefinition().DeclaringType <> method.DeclaringType

			If method.IsPublic Then
				writeLevel = 1
				writeVisibility = "public "
			ElseIf method.IsFamily Then
				writeLevel = 2
				writeVisibility = "protected "
			ElseIf method.IsAssembly Then
				writeLevel = 3
				writeVisibility = "internal "
			ElseIf method.IsPrivate Then
				writeLevel = 5
				writeVisibility = "private "
			Else
				writeLevel = 4
				writeVisibility = "protected internal "
			End If
		End If

		' Visibility
		If canRead AndAlso canWrite Then
			sb.Append(If(readLevel <= writeLevel, readVisibility, writeVisibility))
		ElseIf canRead Then
			sb.Append(readVisibility)
		Else
			sb.Append(writeVisibility)
		End If

		' Modifier
		If isAbstract Then
			sb.Append("abstract ")
		ElseIf isOverride Then
			sb.Append("override ")
		ElseIf isVirtual Then
			sb.Append("virtual ")
		ElseIf isStatic Then
			sb.Append("static ")
		End If

		If genericMethod Is Nothing Then
			sb.Append(this.PropertyType.GetShortDeclaraction())
		Else
			sb.Append(genericMethod.ReturnType.Name)
		End If

		sb.Append(" ")

		Dim indexerParameter As ParameterInfo() = this.GetIndexParameters()

		If indexerParameter.Length > 0 Then
			sb.Append("this")
			sb.Append("[")
			sb.Append(String.Join(", ", indexerParameter.[Select](Function(x) x.ParameterType.GetShortDeclaraction() + " " + x.Name)))
			sb.Append("]")
		Else
			sb.Append(this.Name)
		End If
		sb.Append(" ")


		this.GetSetMethod()

		sb.Append("{ ")
		If this.CanRead Then
			If readLevel > writeLevel Then
				sb.Append(readVisibility)
			End If
			sb.Append("get; ")
		End If
		If this.CanWrite Then
			If writeLevel > readLevel Then
				sb.Append(writeVisibility)
			End If
			sb.Append("set; ")
		End If
		sb.Append("}")

		Return sb.ToString()
	End Function
End Module



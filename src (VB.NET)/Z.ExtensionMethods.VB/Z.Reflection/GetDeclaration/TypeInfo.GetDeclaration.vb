
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Linq
Imports System.Text

Public Module Extensions_812

	<System.Runtime.CompilerServices.Extension> _
	Public Function GetDeclaraction(this As Type) As String
		Dim sb = New StringBuilder()

		' Visibility
		sb.Append(If(this.IsPublic, "public ", "internal "))

		' Modified
		If this.IsAbstract Then
			If this.IsSealed Then
				sb.Append("static ")
			Else
				sb.Append("abstract ")

			End If
		End If


		' Type
		sb.Append(If(this.IsInterface, "interface ", "class "))


		If this.IsGenericType Then
			sb.Append(this.Name.Substring(0, this.Name.IndexOf("`"C)))

			Dim arguments = this.GetGenericArguments()
			Dim definition As Type = this.GetGenericTypeDefinition()
			Dim genericTypes As Type() = definition.GetGenericArguments()

			sb.Append("<")
			sb.Append(String.Join(", ", genericTypes.[Select](Function(x) 
			Dim constraint As Type() = x.GetGenericParameterConstraints()

			Return x.GetGenericParameterConstraints()

End Function)))
			sb.Append(">")
		Else
			' Name
			sb.Append(this.Name)
		End If

		Dim baseTypeSetted As Boolean = False
		If this.BaseType IsNot Nothing AndAlso this.BaseType <> GetType(Object) Then
			baseTypeSetted = True
			sb.Append(" : ")
			sb.Append(this.BaseType.Name)
		End If

		Dim interfaces As Type() = this.GetInterfaces()
		If interfaces.Length > 0 Then
			If baseTypeSetted Then
				sb.Append(", ")
				sb.Append(String.Join(", ", interfaces.[Select](Function(x) x.Name)))
			Else
				sb.Append(" : ")

				sb.Append(String.Join(", ", interfaces.[Select](Function(x) x.Name)))

			End If
		End If

		Dim type As Type() = this.GetNestedTypes()

		Return sb.ToString()
		'if (@this == typeof (bool))
		'{
		'    return "bool";
		'}
		'if (@this == typeof (byte))
		'{
		'    return "byte";
		'}
		'if (@this == typeof (char))
		'{
		'    return "char";
		'}
		'if (@this == typeof (decimal))
		'{
		'    return "decimal";
		'}
		'if (@this == typeof (double))
		'{
		'    return "double";
		'}
		'if (@this == typeof (Enum))
		'{
		'    return "enum";
		'}
		'if (@this == typeof (float))
		'{
		'    return "float";
		'}
		'if (@this == typeof (int))
		'{
		'    return "int";
		'}
		'if (@this == typeof (long))
		'{
		'    return "long";
		'}
		'if (@this == typeof (object))
		'{
		'    return "object";
		'}
		'if (@this == typeof (sbyte))
		'{
		'    return "sbyte";
		'}
		'if (@this == typeof (short))
		'{
		'    return "short";
		'}
		'if (@this == typeof (string))
		'{
		'    return "string";
		'}
		'if (@this == typeof (uint))
		'{
		'    return "uint";
		'}
		'if (@this == typeof (ulong))
		'{
		'    return "ulong";
		'}
		'if (@this == typeof (ushort))
		'{
		'    return "ushort";
		'}

		Return this.Name
	End Function
End Module



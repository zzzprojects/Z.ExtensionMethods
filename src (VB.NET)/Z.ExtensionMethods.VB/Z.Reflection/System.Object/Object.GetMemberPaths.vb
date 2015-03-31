
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Reflection

Public Module Extensions_820

	''' <summary>A T extension method that gets member paths.</summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="path">Full pathname of the file.</param>
	''' <returns>An array of member information.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetMemberPaths(Of T)(this As T, path As String) As MemberInfo()
		Dim lastType As Type = this.[GetType]()
		Dim paths As String() = path.Split("."C)

		Dim memberPaths = New List(Of MemberInfo)()

		For Each item As String In paths
			Dim propertyInfo As PropertyInfo = lastType.GetProperty(item)
			Dim fieldInfo As FieldInfo = lastType.GetField(item)

			If propertyInfo IsNot Nothing Then
				memberPaths.Add(propertyInfo)
				lastType = propertyInfo.PropertyType
			End If
			If fieldInfo IsNot Nothing Then
				memberPaths.Add(fieldInfo)
				lastType = fieldInfo.FieldType
			End If
		Next

		Return memberPaths.ToArray()
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.ComponentModel
Imports System.Linq

Public Module Extensions_238

	''' <summary>
	'''     An object extension method that gets description attribute.
	''' </summary>
	''' <param name="value">The value to act on.</param>
	''' <returns>The description attribute.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributeDescription(value As [Enum]) As String
		Dim attr = TryCast(value.[GetType]().GetField(value.ToString()).GetCustomAttributes(GetType(DescriptionAttribute), False).FirstOrDefault(), DescriptionAttribute)
		Return attr.Description
	End Function
End Module



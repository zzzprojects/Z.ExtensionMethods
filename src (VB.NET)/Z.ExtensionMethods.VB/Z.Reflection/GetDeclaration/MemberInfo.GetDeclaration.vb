
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_808

	<System.Runtime.CompilerServices.Extension> _
	Public Function GetDeclaraction(this As MemberInfo) As String
		Select Case this.MemberType
			Case MemberTypes.Field
				Return DirectCast(this, FieldInfo).GetDeclaraction()
			Case MemberTypes.[Property]
				Return DirectCast(this, PropertyInfo).GetDeclaraction()
			Case MemberTypes.Constructor
				Return DirectCast(this, ConstructorInfo).GetDeclaraction()
			Case MemberTypes.Method
				Return DirectCast(this, MethodInfo).GetDeclaraction()
			Case MemberTypes.TypeInfo
				Return DirectCast(this, Type).GetDeclaraction()
			Case MemberTypes.NestedType
				Return DirectCast(this, Type).GetDeclaraction()
			Case MemberTypes.[Event]
				Return DirectCast(this, EventInfo).GetDeclaraction()
			Case Else
				Return Nothing
		End Select
	End Function
End Module



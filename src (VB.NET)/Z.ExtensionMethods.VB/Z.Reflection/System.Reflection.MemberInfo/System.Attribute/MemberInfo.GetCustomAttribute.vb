
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_841

	''' <summary>
	'''     Retrieves a custom attribute applied to a member of a type. Parameters specify the member, and the type of
	'''     the custom attribute to search for.
	''' </summary>
	''' <param name="element">
	'''     An object derived from the  class that describes a constructor, event, field, method, or
	'''     property member of a class.
	''' </param>
	''' <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	''' <returns>
	'''     A reference to the single custom attribute of type  that is applied to , or null if there is no such
	'''     attribute.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttribute(element As MemberInfo, attributeType As Type) As Attribute
		Return Attribute.GetCustomAttribute(element, attributeType)
	End Function

	''' <summary>
	'''     Retrieves a custom attribute applied to a member of a type. Parameters specify the member, the type of the
	'''     custom attribute to search for, and whether to search ancestors of the member.
	''' </summary>
	''' <param name="element">
	'''     An object derived from the  class that describes a constructor, event, field, method, or
	'''     property member of a class.
	''' </param>
	''' <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	''' <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
	''' <returns>
	'''     A reference to the single custom attribute of type  that is applied to , or null if there is no such
	'''     attribute.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttribute(element As MemberInfo, attributeType As Type, inherit As [Boolean]) As Attribute
		Return Attribute.GetCustomAttribute(element, attributeType, inherit)
	End Function
End Module



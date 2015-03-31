
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_842

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, and
	'''     the type of the custom attribute to search for.
	''' </summary>
	''' <param name="element">
	'''     An object derived from the  class that describes a constructor, event, field, method, or
	'''     property member of a class.
	''' </param>
	''' <param name="type">The type, or a base type, of the custom attribute to search for.</param>
	''' <returns>
	'''     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
	'''     attributes exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As MemberInfo, type As Type) As Attribute()
		Return Attribute.GetCustomAttributes(element, type)
	End Function

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, the
	'''     type of the custom attribute to search for, and whether to search ancestors of the member.
	''' </summary>
	''' <param name="element">
	'''     An object derived from the  class that describes a constructor, event, field, method, or
	'''     property member of a class.
	''' </param>
	''' <param name="type">The type, or a base type, of the custom attribute to search for.</param>
	''' <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
	''' <returns>
	'''     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
	'''     attributes exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As MemberInfo, type As Type, inherit As [Boolean]) As Attribute()
		Return Attribute.GetCustomAttributes(element, type, inherit)
	End Function

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to a member of a type. A parameter specifies the member.
	''' </summary>
	''' <param name="element">
	'''     An object derived from the  class that describes a constructor, event, field, method, or
	'''     property member of a class.
	''' </param>
	''' <returns>
	'''     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
	'''     exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As MemberInfo) As Attribute()
		Return Attribute.GetCustomAttributes(element)
	End Function

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, the
	'''     type of the custom attribute to search for, and whether to search ancestors of the member.
	''' </summary>
	''' <param name="element">
	'''     An object derived from the  class that describes a constructor, event, field, method, or
	'''     property member of a class.
	''' </param>
	''' <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
	''' <returns>
	'''     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
	'''     exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As MemberInfo, inherit As [Boolean]) As Attribute()
		Return Attribute.GetCustomAttributes(element, inherit)
	End Function
End Module



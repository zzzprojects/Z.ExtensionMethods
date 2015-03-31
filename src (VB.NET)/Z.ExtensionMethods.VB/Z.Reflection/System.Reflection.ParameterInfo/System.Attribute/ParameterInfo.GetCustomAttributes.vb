
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_848

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to a method parameter. A parameter specifies the method
	'''     parameter.
	''' </summary>
	''' <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
	''' <returns>
	'''     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
	'''     exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As ParameterInfo) As Attribute()
		Return Attribute.GetCustomAttributes(element)
	End Function

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to a method parameter. Parameters specify the method
	'''     parameter, and the type of the custom attribute to search for.
	''' </summary>
	''' <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
	''' <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	''' <returns>
	'''     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
	'''     attributes exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As ParameterInfo, attributeType As Type) As Attribute()
		Return Attribute.GetCustomAttributes(element, attributeType)
	End Function

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to a method parameter. Parameters specify the method
	'''     parameter, the type of the custom attribute to search for, and whether to search ancestors of the method
	'''     parameter.
	''' </summary>
	''' <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
	''' <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	''' <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
	''' <returns>
	'''     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
	'''     attributes exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As ParameterInfo, attributeType As Type, inherit As [Boolean]) As Attribute()
		Return Attribute.GetCustomAttributes(element, attributeType, inherit)
	End Function

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to a method parameter. Parameters specify the method
	'''     parameter, and whether to search ancestors of the method parameter.
	''' </summary>
	''' <param name="element">An object derived from the  class that describes a parameter of a member of a class.</param>
	''' <param name="inherit">If true, specifies to also search the ancestors of  for custom attributes.</param>
	''' <returns>
	'''     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
	'''     exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As ParameterInfo, inherit As [Boolean]) As Attribute()
		Return Attribute.GetCustomAttributes(element, inherit)
	End Function
End Module



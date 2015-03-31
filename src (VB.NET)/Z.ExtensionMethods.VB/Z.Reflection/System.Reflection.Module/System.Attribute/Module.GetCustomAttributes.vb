
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_845

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to a module. Parameters specify the module, and the type
	'''     of the custom attribute to search for.
	''' </summary>
	''' <param name="element">An object derived from the  class that describes a portable executable file.</param>
	''' <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	''' <returns>
	'''     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
	'''     attributes exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As [Module], attributeType As Type) As Attribute()
		Return Attribute.GetCustomAttributes(element, attributeType)
	End Function

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to a module. A parameter specifies the module.
	''' </summary>
	''' <param name="element">An object derived from the  class that describes a portable executable file.</param>
	''' <returns>
	'''     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
	'''     exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As [Module]) As Attribute()
		Return Attribute.GetCustomAttributes(element)
	End Function

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to a module. Parameters specify the module, and an
	'''     ignored search option.
	''' </summary>
	''' <param name="element">An object derived from the  class that describes a portable executable file.</param>
	''' <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
	''' <returns>
	'''     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
	'''     exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As [Module], inherit As [Boolean]) As Attribute()
		Return Attribute.GetCustomAttributes(element, inherit)
	End Function

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to a module. Parameters specify the module, the type of
	'''     the custom attribute to search for, and an ignored search option.
	''' </summary>
	''' <param name="element">An object derived from the  class that describes a portable executable file.</param>
	''' <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	''' <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
	''' <returns>
	'''     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
	'''     attributes exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As [Module], attributeType As Type, inherit As [Boolean]) As Attribute()
		Return Attribute.GetCustomAttributes(element, attributeType, inherit)
	End Function
End Module



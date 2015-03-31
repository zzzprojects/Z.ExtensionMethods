
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_839

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, and the
	'''     type of the custom attribute to search for.
	''' </summary>
	''' <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
	''' <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	''' <returns>
	'''     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
	'''     attributes exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As Assembly, attributeType As Type) As Attribute()
		Return Attribute.GetCustomAttributes(element, attributeType)
	End Function

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, the type
	'''     of the custom attribute to search for, and an ignored search option.
	''' </summary>
	''' <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
	''' <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	''' <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
	''' <returns>
	'''     An  array that contains the custom attributes of type  applied to , or an empty array if no such custom
	'''     attributes exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As Assembly, attributeType As Type, inherit As [Boolean]) As Attribute()
		Return Attribute.GetCustomAttributes(element, attributeType, inherit)
	End Function

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to an assembly. A parameter specifies the assembly.
	''' </summary>
	''' <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
	''' <returns>
	'''     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
	'''     exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As Assembly) As Attribute()
		Return Attribute.GetCustomAttributes(element)
	End Function

	''' <summary>
	'''     Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, and an
	'''     ignored search option.
	''' </summary>
	''' <param name="element">An object derived from the  class that describes a reusable collection of modules.</param>
	''' <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
	''' <returns>
	'''     An  array that contains the custom attributes applied to , or an empty array if no such custom attributes
	'''     exist.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetCustomAttributes(element As Assembly, inherit As [Boolean]) As Attribute()
		Return Attribute.GetCustomAttributes(element, inherit)
	End Function
End Module



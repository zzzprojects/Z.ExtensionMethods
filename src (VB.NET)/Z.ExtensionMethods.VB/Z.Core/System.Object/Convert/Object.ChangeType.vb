
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_334

	''' <summary>
	'''     Returns an object of the specified type whose value is equivalent to the specified object.
	''' </summary>
	''' <param name="value">An object that implements the  interface.</param>
	''' <param name="typeCode">The type of object to return.</param>
	''' <returns>
	'''     An object whose underlying type is  and whose value is equivalent to .-or-A null reference (Nothing in Visual
	'''     Basic), if  is null and  is , , or .
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ChangeType(value As [Object], typeCode As TypeCode) As [Object]
		Return Convert.ChangeType(value, typeCode)
	End Function

	''' <summary>
	'''     Returns an object of the specified type whose value is equivalent to the specified object. A parameter
	'''     supplies culture-specific formatting information.
	''' </summary>
	''' <param name="value">An object that implements the  interface.</param>
	''' <param name="typeCode">The type of object to return.</param>
	''' <param name="provider">An object that supplies culture-specific formatting information.</param>
	''' <returns>
	'''     An object whose underlying type is  and whose value is equivalent to .-or- A null reference (Nothing in
	'''     Visual Basic), if  is null and  is , , or .
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ChangeType(value As [Object], typeCode As TypeCode, provider As IFormatProvider) As [Object]
		Return Convert.ChangeType(value, typeCode, provider)
	End Function

	''' <summary>
	'''     Returns an object of the specified type and whose value is equivalent to the specified object.
	''' </summary>
	''' <param name="value">An object that implements the  interface.</param>
	''' <param name="conversionType">The type of object to return.</param>
	''' <returns>
	'''     An object whose type is  and whose value is equivalent to .-or-A null reference (Nothing in Visual Basic), if
	'''     is null and  is not a value type.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ChangeType(value As [Object], conversionType As Type) As [Object]
		Return Convert.ChangeType(value, conversionType)
	End Function

	''' <summary>
	'''     Returns an object of the specified type whose value is equivalent to the specified object. A parameter
	'''     supplies culture-specific formatting information.
	''' </summary>
	''' <param name="value">An object that implements the  interface.</param>
	''' <param name="conversionType">The type of object to return.</param>
	''' <param name="provider">An object that supplies culture-specific formatting information.</param>
	''' <returns>
	'''     An object whose type is  and whose value is equivalent to .-or- , if the  of  and  are equal.-or- A null
	'''     reference (Nothing in Visual Basic), if  is null and  is not a value type.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ChangeType(value As [Object], conversionType As Type, provider As IFormatProvider) As [Object]
		Return Convert.ChangeType(value, conversionType, provider)
	End Function

	''' <summary>
	'''     Returns an object of the specified type and whose value is equivalent to the specified object.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="value">An object that implements the  interface.</param>
	''' <returns>
	'''     An object whose type is  and whose value is equivalent to .-or-A null reference (Nothing in Visual Basic), if
	'''     is null and  is not a value type.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ChangeType(Of T)(value As [Object]) As [Object]
		Return DirectCast(Convert.ChangeType(value, GetType(T)), T)
	End Function

	''' <summary>
	'''     Returns an object of the specified type whose value is equivalent to the specified object. A parameter
	'''     supplies culture-specific formatting information.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="value">An object that implements the  interface.</param>
	''' <param name="provider">An object that supplies culture-specific formatting information.</param>
	''' <returns>
	'''     An object whose type is  and whose value is equivalent to .-or- , if the  of  and  are equal.-or- A null
	'''     reference (Nothing in Visual Basic), if  is null and  is not a value type.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ChangeType(Of T)(value As [Object], provider As IFormatProvider) As [Object]
		Return DirectCast(Convert.ChangeType(value, GetType(T), provider), T)
	End Function
End Module



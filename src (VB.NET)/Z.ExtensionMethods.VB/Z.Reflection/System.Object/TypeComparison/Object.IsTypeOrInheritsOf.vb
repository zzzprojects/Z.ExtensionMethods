
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_836

	''' <summary>
	'''     A T extension method that query if '@this' is type or inherits of.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="type">The type.</param>
	''' <returns>true if type or inherits of, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsTypeOrInheritsOf(Of T)(this As T, type As Type) As Boolean
		Dim objectType As Type = this.[GetType]()

		While True
			If objectType.Equals(type) Then
				Return True
			End If

			If (objectType = objectType.BaseType) OrElse (objectType.BaseType Is Nothing) Then
				Return False
			End If

			objectType = objectType.BaseType
		End While
	End Function
End Module



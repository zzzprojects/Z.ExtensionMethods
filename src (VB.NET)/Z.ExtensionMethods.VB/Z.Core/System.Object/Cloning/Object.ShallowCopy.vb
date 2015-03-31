
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_333

	''' <summary>
	'''     A T extension method that shallow copy.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>A T.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ShallowCopy(Of T)(this As T) As T
		Dim method As MethodInfo = this.[GetType]().GetMethod("MemberwiseClone", BindingFlags.NonPublic Or BindingFlags.Instance)
		Return DirectCast(method.Invoke(this, Nothing), T)
	End Function
End Module



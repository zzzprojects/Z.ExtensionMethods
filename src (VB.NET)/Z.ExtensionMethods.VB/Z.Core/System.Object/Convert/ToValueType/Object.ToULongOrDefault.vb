
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_443

	''' <summary>
	'''     An object extension method that converts this object to an u long or default.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The given data converted to an ulong.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToULongOrDefault(this As Object) As ULong
		Try
			Return Convert.ToUInt64(this)
		Catch generatedExceptionName As Exception
			Return 0
		End Try
	End Function

	''' <summary>
	'''     An object extension method that converts this object to an u long or default.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="defaultValue">The default value.</param>
	''' <returns>The given data converted to an ulong.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToULongOrDefault(this As Object, defaultValue As ULong) As ULong
		Try
			Return Convert.ToUInt64(this)
		Catch generatedExceptionName As Exception
			Return defaultValue
		End Try
	End Function

	''' <summary>
	'''     An object extension method that converts this object to an u long or default.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="defaultValueFactory">The default value factory.</param>
	''' <returns>The given data converted to an ulong.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToULongOrDefault(this As Object, defaultValueFactory As Func(Of ULong)) As ULong
		Try
			Return Convert.ToUInt64(this)
		Catch generatedExceptionName As Exception
			Return defaultValueFactory()
		End Try
	End Function
End Module



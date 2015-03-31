
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_497

	''' <summary>
	'''     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
	'''     Object instance in a specified array.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="arg0">The argument 0.</param>
	''' <returns>
	'''     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
	'''     instances of Object in args.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FormatWith(this As [String], arg0 As [Object]) As [String]
		Return [String].Format(this, arg0)
	End Function

	''' <summary>
	'''     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
	'''     Object instance in a specified array.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="arg0">The argument 0.</param>
	''' <param name="arg1">The first argument.</param>
	''' <returns>
	'''     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
	'''     instances of Object in args.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FormatWith(this As [String], arg0 As [Object], arg1 As [Object]) As [String]
		Return [String].Format(this, arg0, arg1)
	End Function

	''' <summary>
	'''     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
	'''     Object instance in a specified array.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="arg0">The argument 0.</param>
	''' <param name="arg1">The first argument.</param>
	''' <param name="arg2">The second argument.</param>
	''' <returns>
	'''     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
	'''     instances of Object in args.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FormatWith(this As [String], arg0 As [Object], arg1 As [Object], arg2 As [Object]) As [String]
		Return [String].Format(this, arg0, arg1, arg2)
	End Function

	''' <summary>
	'''     Replaces the format item in a specified String with the text equivalent of the value of a corresponding
	'''     Object instance in a specified array.
	''' </summary>
	''' <param name="this">A String containing zero or more format items.</param>
	''' <param name="values">An Object array containing zero or more objects to format.</param>
	''' <returns>
	'''     A copy of format in which the format items have been replaced by the String equivalent of the corresponding
	'''     instances of Object in args.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FormatWith(this As String, ParamArray values As Object()) As String
		Return [String].Format(this, values)
	End Function
End Module



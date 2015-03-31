
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_412

	''' <summary>
	'''     An object extension method that converts the @this to a nullable s byte.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a sbyte?</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToNullableSByte(this As Object) As System.Nullable(Of SByte)
		If this Is Nothing OrElse this = DBNull.Value Then
			Return Nothing
		End If

		Return Convert.ToSByte(this)
	End Function
End Module



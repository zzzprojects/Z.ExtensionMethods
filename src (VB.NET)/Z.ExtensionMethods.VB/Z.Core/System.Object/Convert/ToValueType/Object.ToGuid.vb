
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_376

	''' <summary>
	'''     An object extension method that converts the @this to a unique identifier.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as a GUID.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToGuid(this As Object) As Guid
		Return New Guid(this.ToString())
	End Function
End Module



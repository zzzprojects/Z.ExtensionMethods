
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_612

	''' <summary>
	'''     Creates a proxy for the well-known object indicated by the specified type and URL.
	''' </summary>
	''' <param name="type">The type of the well-known object to which you want to connect.</param>
	''' <param name="url">The URL of the well-known object.</param>
	''' <returns>A proxy that points to an endpoint served by the requested well-known object.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetObject(type As Type, url As [String]) As [Object]
		Return Activator.GetObject(type, url)
	End Function

	''' <summary>
	'''     Creates a proxy for the well-known object indicated by the specified type, URL, and channel data.
	''' </summary>
	''' <param name="type">The type of the well-known object to which you want to connect.</param>
	''' <param name="url">The URL of the well-known object.</param>
	''' <param name="state">Channel-specific data or null.</param>
	''' <returns>A proxy that points to an endpoint served by the requested well-known object.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetObject(type As Type, url As [String], state As [Object]) As [Object]
		Return Activator.GetObject(type, url, state)
	End Function
End Module



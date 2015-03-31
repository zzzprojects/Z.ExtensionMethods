
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Net

Public Module Extensions_802

	''' <summary>
	'''     A WebRequest extension method that gets the WebRequest response or the WebException response.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The WebRequest response or WebException response.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetResponseSafe(this As WebRequest) As WebResponse
		Try
			Return this.GetResponse()
		Catch e As WebException
			Return e.Response
		End Try
	End Function
End Module



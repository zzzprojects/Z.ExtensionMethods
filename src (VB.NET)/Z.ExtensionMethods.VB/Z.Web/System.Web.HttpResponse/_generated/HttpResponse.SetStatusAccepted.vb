
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Web

Public Module Extensions_862

	''' <summary>
	'''     A HttpResponse extension method that sets the response to status code 202 (Accepted.).
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub SetStatusAccepted(this As HttpResponse)
		this.StatusCode = 202
		this.StatusDescription = "Accepted."
	End Sub
End Module



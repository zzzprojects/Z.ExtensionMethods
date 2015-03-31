
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Net

Public Module Extensions_293

	''' <summary>
	'''     Converts an integer value from host byte order to network byte order.
	''' </summary>
	''' <param name="host">The number to convert, expressed in host byte order.</param>
	''' <returns>An integer value, expressed in network byte order.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function HostToNetworkOrder(host As Int32) As Int32
		Return IPAddress.HostToNetworkOrder(host)
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data

Public Module Extensions_678

	''' <summary>
	'''     An IDataReader extension method that query if '@this' is database null.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="name">The name.</param>
	''' <returns>true if database null, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsDBNull(this As IDataReader, name As String) As Boolean
		Return this.IsDBNull(this.GetOrdinal(name))
	End Function
End Module



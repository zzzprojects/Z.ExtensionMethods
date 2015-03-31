
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_493

	''' <summary>
	'''     A string extension method that escape XML.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>A string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function EscapeXml(this As String) As String
		Return this.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("""", "&quot;").Replace("'", "&apos;")
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO

Public Module Extensions_781

	''' <summary>
	'''     A FileInfo extension method that gets directory name.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The directory name.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetDirectoryName(this As FileInfo) As [String]
		Return this.Directory.Name
	End Function
End Module



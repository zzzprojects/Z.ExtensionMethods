
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Web

Public Module Extensions_860

	''' <summary>
	'''     A HttpResponse extension method that sends an attachment.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="fullPathToFile">The full path to file.</param>
	''' <param name="outputFileName">Filename of the output file.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub SendAttachment(this As HttpResponse, fullPathToFile As String, outputFileName As String)
		this.Clear()
		this.AddHeader("content-disposition", Convert.ToString("attachment; filename=") & outputFileName)
		this.WriteFile(fullPathToFile)
		this.ContentType = ""
		this.[End]()
	End Sub
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Text

Public Module Extensions_604

	''' <summary>
	'''     A StringBuilder extension method that appends a line format.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="format">Describes the format to use.</param>
	''' <param name="args">A variable-length parameters list containing arguments.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub AppendLineFormat(this As StringBuilder, format As String, ParamArray args As Object())
		this.AppendLine(String.Format(format, args))
	End Sub

	''' <summary>
	'''     A StringBuilder extension method that appends a line format.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="format">Describes the format to use.</param>
	''' <param name="args">A variable-length parameters list containing arguments.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub AppendLineFormat(this As StringBuilder, format As String, args As List(Of IEnumerable(Of Object)))
		this.AppendLine(String.Format(format, args))
	End Sub
End Module



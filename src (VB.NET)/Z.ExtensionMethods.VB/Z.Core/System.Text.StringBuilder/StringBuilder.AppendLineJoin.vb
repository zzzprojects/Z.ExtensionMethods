
Imports System.Collections.Generic
Imports System.Text

Public Module Extensions_605

	''' <summary>A StringBuilder extension method that appends a line join.</summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="separator">The separator.</param>
	''' <param name="values">The values.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub AppendLineJoin(Of T)(this As StringBuilder, separator As String, values As IEnumerable(Of T))
		this.AppendLine(String.Join(separator, values))
	End Sub

	''' <summary>A StringBuilder extension method that appends a line join.</summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="separator">The separator.</param>
	''' <param name="values">The values.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub AppendLineJoin(this As StringBuilder, separator As String, ParamArray values As Object())
		this.AppendLine(String.Join(separator, values))
	End Sub
End Module



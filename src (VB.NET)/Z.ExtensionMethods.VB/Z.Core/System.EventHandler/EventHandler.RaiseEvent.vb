
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_242

	''' <summary>
	'''     An EventHandler extension method that raises the event event.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="sender">Source of the event.</param>
    <System.Runtime.CompilerServices.Extension> _
    Public Sub [RaiseEvent](this As EventHandler, sender As Object)
        this(sender, Nothing)
    End Sub

	''' <summary>
	'''     An EventHandler extension method that raises.
	''' </summary>
	''' <param name="handler">The handler to act on.</param>
	''' <param name="sender">Source of the event.</param>
	''' <param name="e">Event information.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Raise(handler As EventHandler, sender As Object, e As EventArgs)
        handler(sender, e)
	End Sub

	''' <summary>
	'''     An EventHandler&lt;TEventArgs&gt; extension method that raises the event event.
	''' </summary>
	''' <typeparam name="TEventArgs">Type of the event arguments.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="sender">Source of the event.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub [RaiseEvent](Of TEventArgs As EventArgs)(this As EventHandler(Of TEventArgs), sender As Object)
        this(sender, Activator.CreateInstance(Of TEventArgs)())
	End Sub

	''' <summary>
	'''     An EventHandler&lt;TEventArgs&gt; extension method that raises the event event.
	''' </summary>
	''' <typeparam name="TEventArgs">Type of the event arguments.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="sender">Source of the event.</param>
	''' <param name="e">Event information to send to registered event handlers.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub [RaiseEvent](Of TEventArgs As EventArgs)(this As EventHandler(Of TEventArgs), sender As Object, e As TEventArgs)
        this(sender, e)
	End Sub
End Module



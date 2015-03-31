
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Windows.Forms

Public Module Extensions_886

	''' <summary>
	'''     A Form extension method that set the window form to full screen mode to the specified screen.
	''' </summary>
	''' <param name="form">The form to act on.</param>
	''' <param name="screen">(Optional) the screen to act on.</param>
	<System.Runtime.CompilerServices.Extension> _
	Public Sub ToFullScreen(form As Form, Optional screen__1 As Integer = 0)
		form.WindowState = FormWindowState.Maximized
		form.StartPosition = FormStartPosition.Manual
		form.Bounds = Screen.AllScreens(screen__1).Bounds
	End Sub
End Module



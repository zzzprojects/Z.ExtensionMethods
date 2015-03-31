
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_253

	''' <summary>
	'''     An Int16 extension method that query if '@this' is prime.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true if prime, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsPrime(this As Int16) As Boolean
		If this = 1 OrElse this = 2 Then
			Return True
		End If

		If this Mod 2 = 0 Then
			Return False
		End If

        Dim sqrt = Convert.ToInt16(Math.Sqrt(this))
		Dim t As Int64 = 3
		While t <= sqrt
			If this Mod t = 0 Then
				Return False
			End If
			t = t + 2
		End While

		Return True
	End Function
End Module



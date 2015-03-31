
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_564

	''' <summary>
	'''     Retrieves the system&#39;s reference to the specified .
	''' </summary>
	''' <param name="str">A string to search for in the intern pool.</param>
	''' <returns>
	'''     The system&#39;s reference to , if it is interned; otherwise, a new reference to a string with the value of .
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Intern(str As [String]) As [String]
		Return [String].Intern(str)
	End Function
End Module



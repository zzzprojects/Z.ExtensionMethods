
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

Public Module Extensions_332

	''' <summary>
	'''     A T extension method that makes a deep copy of '@this' object.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>the copied object.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function DeepClone(Of T)(this As T) As T
		Dim formatter As IFormatter = New BinaryFormatter()
		Using stream = New MemoryStream()
			formatter.Serialize(stream, this)
			stream.Seek(0, SeekOrigin.Begin)
			Return DirectCast(formatter.Deserialize(stream), T)
		End Using
	End Function
End Module




' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Data

Public Module Extensions_672

	''' <summary>
	'''     An IDataReader extension method that applies an operation to all items in this collection.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="action">The action.</param>
	''' <returns>An IDataReader.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ForEach(this As IDataReader, action As Action(Of IDataReader)) As IDataReader
		While this.Read()
			action(this)
		End While

		Return this
	End Function
End Module


